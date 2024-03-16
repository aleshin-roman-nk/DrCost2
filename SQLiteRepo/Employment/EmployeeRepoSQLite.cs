using Core.Employment.dto;
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

		public Employee Create(CreateEmployeeDto es)
		{
			var newEmpl = new EmployeeDb
			{
				cash = es.source.cash,
				employeeSourceId = es.source.id,
				name = es.source.name,
				payDocId = es.documentId
			};

			db.Employees.Add(newEmpl);
			db.SaveChanges();

			var res = new Employee
			{
				id = newEmpl.id,
				name = newEmpl.name,
				cash = newEmpl.cash,
				employeeSourceId = newEmpl.employeeSourceId,
				payDocId = newEmpl.payDocId
			};

			return res;
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
						Payments = new List<EmplPayment>()
					})
					.ToArray();
		}

		public IEnumerable<Employee> Get(int documentId)
		{
			return db.Employees
				.Where(x => x.payDocId == documentId)
				.Select(x => new Employee
				{
					cash = x.cash,
					employeeSourceId = x.employeeSourceId,
					payDocId = x.payDocId,
					id = x.id,
					name = x.name
				})
				.ToArray();
		}
	}
}
