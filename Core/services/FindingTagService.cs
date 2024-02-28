using Core.entity;
using Core.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.services
{
	public class FindingTagService
	{
		private readonly IFindingTagRepo repo;

		public FindingTagService(IFindingTagRepo repo)
		{
			this.repo = repo;
		}

		public IEnumerable<FindingTag> GetAll()
		{
			return repo.GetAll();
		}
	}
}
