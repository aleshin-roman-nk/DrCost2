using Core.Employment.dto;
using Core.Employment.entity;
using Core.Employment.repos;
using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.services
{
	/*
	 * решено документ обновлять полностью
	 * - при любом изменении, отдавать новый документ, который будет отрисовываться на странице
	 * ! нет времени оптимизировать. не перспективный проект
	 * 
	 */

	public class EmplMonthDocService
	{
		private readonly IEmplMonthDocRepo employmentDocRepo;
		private readonly IEmployeeSourceRepo employeeSourceRepo;
		private readonly IEmployeeRepo employeeRepo;
		private readonly IEmplPaymentRepo emplPaymentRepo;

		private EmplMonthDoc? _emplMonthDoc = null;

		public event EventHandler<EmplMonthDoc?>? OnEmplMonthDocChanged;

		public EmplMonthDocService(
			IEmplMonthDocRepo employmentDocRepo,
			IEmployeeSourceRepo employeeSourceRepo,
			IEmployeeRepo employeeRepo,
			IEmplPaymentRepo emplPaymentRepo
			)
		{
			this.employmentDocRepo = employmentDocRepo;
			this.employeeSourceRepo = employeeSourceRepo;
			this.employeeRepo = employeeRepo;
			this.emplPaymentRepo = emplPaymentRepo;
		}

		public void loadDocument(int year, int month)
		{
			var docname = $"{year}.{month}";
			_emplMonthDoc = employmentDocRepo.Get(docname);
			updateEmplMonthDocTotals();
			OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
		}

		public void CreateNewDoc(int year, int month)
		{
			var docname = $"{year}.{month}";
			var doc = employmentDocRepo.Create(docname);

			if (doc != null)
			{
				_emplMonthDoc = doc;
				updateEmplMonthDocTotals();
				OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
			}
		}

		public void EnsureAllActiveCreated()
		{
			if (_emplMonthDoc == null) return;

			var allEmployeeSource = employeeSourceRepo.GetAllActive();

			var existingEmpls = employeeRepo.Get(_emplMonthDoc.id).ToList();

			var employees = allEmployeeSource
				.Where(src => !existingEmpls.Any(x => x.employeeSourceId == src.id))
				.Select(src => new Employee
				{
					cash = src.cash,
					employeeSourceId = src.id,
					name = src.name,
					payDocId = _emplMonthDoc.id
				});

			if (!employees.Any()) return;

			var newEmpls = employeeRepo.CreateRange(employees);

			//existingEmpls.AddRange(newEmpls);

			// не знаю почему у существующего employee теряется Payments
			// нет времени копаться
			_emplMonthDoc.Employees = employeeRepo.Get(_emplMonthDoc.id).ToList();

			//_emplMonthDoc.Employees = existingEmpls;

			updateEmplMonthDocTotals();
			OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
		}

		public void CreateEmployee(EmployeeSource es)
		{
			if (_emplMonthDoc == null) return;

			CreateEmployeeDto o = new CreateEmployeeDto
			{
				documentId = _emplMonthDoc.id,
				source = es
			};

			var e = employeeRepo.Create(o);

			_emplMonthDoc.Employees.ToList().Add(e);

			updateEmplMonthDocTotals();
			OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
		}

		public void CreateEmplPayment(EmplPayment payment)
		{
			if (_emplMonthDoc == null) return;

			var empl = _emplMonthDoc.Employees
				.FirstOrDefault(e => e.id == payment.employeeId);

			if (empl == null) return;

			var p = emplPaymentRepo.Create(payment);

			// in-memory create
			empl.Payments?.Add(p);

			updateEmplMonthDocTotals();
			OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
		}

		public void DeleteEmplPayment(EmplPayment payment)
		{
			if (_emplMonthDoc == null) return;

			var empl = _emplMonthDoc.Employees
				.FirstOrDefault(e => e.id == payment.employeeId);

			if (empl == null) return;

			emplPaymentRepo.Delete(payment);

			// in-memory delete
			var p = empl.Payments?.FirstOrDefault(e => e.id == payment.id);

			if(p == null) return;

			empl.Payments?.Remove(p);

			updateEmplMonthDocTotals();
			OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
		}

		public void UpdateEmplPayment(EmplPayment payment)
		{
			if (_emplMonthDoc == null) return;

			var empl = _emplMonthDoc.Employees
				.FirstOrDefault(e => e.id == payment.employeeId);

			if (empl == null) return;

			emplPaymentRepo.Update(payment);

			// in-memory update
			int i = empl.Payments.FindIndex(x => x.id == payment.id);

			if(i == -1) return;

			empl.Payments[i] = payment;

			updateEmplMonthDocTotals();
			OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
		}

		public void CloneLastDocumentInto(int fromYear, int fromMonth, int toYear, int toMonth)
		{
			var r = employmentDocRepo.Clone($"{fromYear}.{fromMonth}", $"{toYear}.{toMonth}");

			if(r != null)
			{
				_emplMonthDoc = r;
				OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
			}
		}

		public void DeleteEmployee(Employee employee)
		{
			if (_emplMonthDoc == null) return;

			var e = _emplMonthDoc.Employees.FirstOrDefault(x => x.id == employee.id);

			if(e == null) return;

			if (employeeRepo.Delete(e))
			{
				_emplMonthDoc.Employees.Remove(e);
				OnEmplMonthDocChanged?.Invoke(this, _emplMonthDoc);
			}
		}

		private void updateEmplMonthDocTotals()
		{
			if (_emplMonthDoc == null) return;

			_emplMonthDoc.ops = calcOps(_emplMonthDoc);
			_emplMonthDoc.fot = calcFot(_emplMonthDoc);
			_emplMonthDoc.total = calcTotal(_emplMonthDoc);
		}

		private decimal calcTotal(EmplMonthDoc d)
		{
			return d.Employees.Sum(x => x.sum);
		}

		private decimal calcFot(EmplMonthDoc d)
		{
			decimal fot = 0;

			foreach (var employee in d.Employees)
			{
				fot += employee.Payments
					.Where(p => p.tagName.Equals("FOT"))
					.Sum(x => x.sum);
			}

			return fot;
		}

		private decimal calcOps(EmplMonthDoc d)
		{
			decimal ops = 0;

			foreach (var employee in d.Employees)
			{
				ops += employee.Payments
					.Where(p => p.tagName.Equals("OPS"))
					.Sum(x => x.sum);
			}

			return ops;
		}
	}
}
