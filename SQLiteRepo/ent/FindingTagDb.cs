using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo.ent
{
	[Table("FindingTags")]
	public class FindingTagDb
	{
		public int id { get; set; }
		public string name { get; set; }
	}
}
