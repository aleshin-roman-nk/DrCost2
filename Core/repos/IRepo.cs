﻿using Core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repos
{
	public interface IRepo<TEntity>
		where TEntity : class
	{
		public TEntity Add(TEntity pr);
		public TEntity Update(TEntity pr);
		public void Delete(TEntity pr);
		public TEntity Get(int id);
	}
}
