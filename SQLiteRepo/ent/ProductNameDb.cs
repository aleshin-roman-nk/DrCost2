using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.ent
{
	[Table("ProductNames")]
	public class ProductNameDb
	{
		public int id { get; set; }
		public string name { get; set; }
		public int ProductCategoryId { get; set; }
		public int findingTagId { get; set; }
	}
}
