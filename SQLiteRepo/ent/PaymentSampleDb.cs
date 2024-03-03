using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.ent
{
	[Table("PaymentSamples")]
	public class PaymentSampleDb
	{
		public int id { get; set; }
		public string name { get; set; }
		public int categoryId { get; set; }
		public int findingTagId { get; set; }
		public PaymentCategoryDb category {  get; set; }
		public FindingTagDb findingTag { get; set; }
	}
}
