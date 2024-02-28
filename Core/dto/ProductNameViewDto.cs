using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.dto
{
	public class ProductNameViewDto
	{
		IEnumerable<ProductCategory>? productCategories { get; }
		IEnumerable<FindingTag>? findingTags { get; }
	}
}
