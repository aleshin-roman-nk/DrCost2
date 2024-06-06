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
	public class EmplMonthDocRepoSQLite : IEmplMonthDocRepo
	{
		private readonly AppData db;

		public EmplMonthDocRepoSQLite(AppData db)
		{
			this.db = db;
		}

		public EmplMonthDoc? Clone(string unameFrom, string unameTo)
		{
			var srcDoc = db.EmplMonthDocs
				.Include(x => x.Employees)
				.ThenInclude(x => x.Payments)
				.FirstOrDefault(x => x.uname.Equals(unameFrom));

			if (srcDoc == null) return null;

			var destDoc = db.EmplMonthDocs
				.Include(x => x.Employees)
				.ThenInclude(x => x.Payments)
				.FirstOrDefault(x => x.uname.Equals(unameTo));

			if (destDoc == null) return null;

			// clear current image
			foreach (var empl in destDoc.Employees)
			{
				db.Employees.Remove(empl);
				foreach (var pay in empl.Payments)
				{
					db.EmplPayments.Remove(pay);
				}
			}
			db.SaveChanges();


			foreach (var srcEmpl in srcDoc.Employees)
			{
				var newEmpl = new EmployeeDb
				{
					cash = srcEmpl.cash,
					employeeSourceId = srcEmpl.employeeSourceId,
					name = srcEmpl.name,
					payDocId = destDoc.id
				};

				foreach (var srcPay in srcEmpl.Payments)
				{
					newEmpl.Payments.Add(new EmplPaymentDb
					{
						amount = srcPay.amount,
						completed = srcPay.completed,
						description = srcPay.description,
						emplPaymentSourceId = srcPay.emplPaymentSourceId,
						name = srcPay.name,
						price = srcPay.price,
						tagId = srcPay.tagId,
					});
				}

				db.Employees.Add(newEmpl);
			}

			db.SaveChanges();

			return this.Get(unameTo);
		}

		public EmplMonthDoc? Create(string uname)
		{
			if(db.EmplMonthDocs.Any(x => x.uname.Equals(uname)))
				return null;

			var doc = new EmplMonthDocDb
			{
				uname = uname
			};

			db.EmplMonthDocs.Add(doc);

			db.SaveChanges();

			return new EmplMonthDoc
			{
				uname = doc.uname,
				id = doc.id
			};
		}

		public EmplMonthDoc? Get(string uname)
		{
			var docDb = db.EmplMonthDocs.FirstOrDefault(doc => doc.uname.Equals(uname));

			if (docDb == null) return null;

			var employeesDb = db.Employees
				.Include(empl => empl.Payments)
					.ThenInclude(p => p.EmplPaymentTag)
				.Where(empl => empl.payDocId == docDb.id)
				.ToArray();

			var doc = new EmplMonthDoc
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
