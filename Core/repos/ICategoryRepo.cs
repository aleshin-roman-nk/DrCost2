﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.entity;

namespace Core.repos
{
    public interface ICategoryRepo: IRepo<ProductCategory>
	{
		IEnumerable<ProductCategory> GetAll();
	}
}
