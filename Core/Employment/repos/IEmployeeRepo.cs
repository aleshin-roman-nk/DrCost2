using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.repos
{
	public interface IEmployeeRepo
	{
		IEnumerable<Employee> CreateRange(IEnumerable<Employee> employees);
	}
}
