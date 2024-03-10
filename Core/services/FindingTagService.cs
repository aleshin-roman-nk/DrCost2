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
		private readonly IFindingTagRepo findingTagRepo;

		public FindingTagService(IFindingTagRepo findingTagRepo)
		{
			this.findingTagRepo = findingTagRepo;
		}
		public IEnumerable<FindingTag> GetAll()
		{
			return findingTagRepo.GetAll();
		}

		public FindingTag Create(string tagName)
		{
			return findingTagRepo.Create(tagName);
		}
	}
}
