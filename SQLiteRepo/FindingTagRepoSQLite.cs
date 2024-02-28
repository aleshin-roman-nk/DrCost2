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

		public FindingTag Add(FindingTag pr)
		{
			throw new NotImplementedException();
		}

		public void Delete(FindingTag pr)
		{
			throw new NotImplementedException();
		}

		public FindingTag Get(int id)
		{
			throw new NotImplementedException();
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
