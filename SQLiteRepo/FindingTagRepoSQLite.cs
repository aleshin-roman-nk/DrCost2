using AutoMapper;
using Core.entity;
using Core.repos;
using SQLiteRepo.ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteRepo
{
	public class FindingTagRepoSQLite : IFindingTagRepo
	{
		private readonly AppData db;
		IMapper mapper;

		public FindingTagRepoSQLite(AppData db)
		{
			this.db = db;

			var mapCfg = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<FindingTag, FindingTagDb>().ReverseMap();
			});

			mapper = mapCfg.CreateMapper();
		}

		public FindingTag Create(string tagName)
		{
			FindingTagDb t = new FindingTagDb { name = tagName };

			db.FindingTags.Add(t);
			db.SaveChanges();

			return new FindingTag { name = t.name, id = t.id };
		}

		public IEnumerable<FindingTag> GetAll()
		{
			return db.FindingTags.Select(x => mapper.Map<FindingTag>(x)).ToArray();
		}

		public FindingTag Update(FindingTag pr)
		{
			throw new NotImplementedException();
		}
	}
}
