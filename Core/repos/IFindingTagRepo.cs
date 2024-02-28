using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repos
{
	public interface IFindingTagRepo: IRepo<FindingTag>
	{
		IEnumerable<FindingTag> GetAll();
	}
}
