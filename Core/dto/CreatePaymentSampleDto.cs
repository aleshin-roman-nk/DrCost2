using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.dto
{
	public class CreatePaymentSampleDto
	{
		public string? name { get; set; }
		public int tagId { get; set; }
		public int categoryId { get; set; }
	}
}
