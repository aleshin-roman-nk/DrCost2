using Core.Employment.entity;
using Core.Employment.repos;
using Microsoft.EntityFrameworkCore;
using SQLiteRepo.Employment.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment
{
	public class EmploymentDocRepoSQLite : IEmploymentDocRepo
	{
		private readonly AppData db;

		public EmploymentDocRepoSQLite(AppData db)
		{
			this.db = db;
		}

		public PaymentMainDoc? Create(string uname)
		{
			if(db.PaymentMainDocs.Any(x => x.uname.Equals(uname)))
				return null;

			var doc = new PaymentMainDocDb
			{
				uname = uname
			};

			db.PaymentMainDocs.Add(doc);

			db.SaveChanges();

			return new PaymentMainDoc
			{
				uname = doc.uname,
				id = doc.id
			};
		}

		public PaymentMainDoc? Get(string uname)
		{
			var docDb = db.PaymentMainDocs.FirstOrDefault(doc => doc.uname.Equals(uname));

			if (docDb == null) return null;

			var employeesDb = db.Employees
				.Include(empl => empl.Payments)
					.ThenInclude(p => p.EmplPaymentTag)
				.Where(empl => empl.payDocId == docDb.id)
				.ToArray();

			var doc = new PaymentMainDoc
			{
				id = docDb.id,
				uname = docDb.uname
			};

			List<Employee> employees = new List<Employee>();

			foreach (var item in employeesDb)
			{
				var employee = new Employee
				{
					cash = item.cash,
					employeeSourceId = item.employeeSourceId,
					id = item.id,
					name = item.name,
					payDocId = item.payDocId
				};

				List<EmplPayment> emplPayments = new List<EmplPayment>();
				foreach (var emplPayment in item.Payments)
				{
					emplPayments.Add(new EmplPayment
					{
						amount = emplPayment.amount,
						employeeId = emplPayment.employeeId,
						id = emplPayment.id,
						name= emplPayment.name,
						price = emplPayment.price,
						tagId = emplPayment.tagId,
						tagName = emplPayment.EmplPaymentTag.name,
						completed = emplPayment.completed,
						description = emplPayment.description,
						emplPaymentSourceId = emplPayment.emplPaymentSourceId
					});
				}

				employee.Payments = emplPayments;

				employees.Add(employee);
			}

			doc.Employees = employees;

			return doc;
		}
	}
}
