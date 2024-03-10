using Core.Employment.entity;
using Core.Employment.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.services
{
	public class EmploymentDocService
	{
		private readonly IEmploymentDocRepo employmentDocRepo;
		private readonly IEmployeeSourceRepo employeeSourceRepo;
		private readonly IEmployeeRepo employeeRepo;
		private readonly IEmplPaymentRepo emplPaymentRepo;

		public EmploymentDocService(
			IEmploymentDocRepo employmentDocRepo,
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

		public PaymentMainDoc? Get(string uname)
		{
			return employmentDocRepo.Get(uname);
		}

		public PaymentMainDoc? Create(string uname)
		{
			return employmentDocRepo.Create(uname);
		}

		public void AddAllEmployees(PaymentMainDoc paymentMainDoc)
		{
			var allEmployeeSource = employeeSourceRepo.GetAll();

			var employees = allEmployeeSource
				.Select(src => new Employee
				{
					cash = src.cash,
					employeeSourceId = src.id,
					name = src.name,
					payDocId = paymentMainDoc.id
				});

			if (paymentMainDoc.Employees.Count() == 0)
			{
				paymentMainDoc.Employees = employeeRepo.CreateRange(employees);
				return;
			}
		}

		public EmplPayment Add(EmplPayment payment)
		{
			return emplPaymentRepo.Create(payment);
		}
	}
}
