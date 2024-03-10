using Core.Employment.entity;
using Core.Employment.repos;
using SQLiteRepo.Employment.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.Employment
{
	public class EmployeeRepoSQLite : IEmployeeRepo
	{
		private readonly AppData db;

		public EmployeeRepoSQLite(AppData db)
		{
			this.db = db;
		}
		public IEnumerable<Employee> CreateRange(IEnumerable<Employee> employees)
		{
			var employeesDb = employees
				.Select(e => new EmployeeDb
				{
					cash = e.cash,
					employeeSourceId = e.employeeSourceId,
					name = e.name,
					payDocId = e.payDocId,
				})
				.ToArray();

			db.Employees.AddRange(employeesDb);

			db.SaveChanges();

			return employeesDb
					.Select(eDb => new Employee
					{
						cash = eDb.cash,
						employeeSourceId = eDb.employeeSourceId,
						name = eDb.name,
						id = eDb.id,
						payDocId = eDb.payDocId,
						Payments = new List<EmplPayment>().ToArray()
					})
					.ToArray();
		}
	}
}
