using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.dto
{
	public class CreateEmployeeDto
	{
		public int documentId {  get; set; }
		public EmployeeSource? source { get; set; }
	}
}
