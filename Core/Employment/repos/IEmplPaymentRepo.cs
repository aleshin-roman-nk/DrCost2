﻿using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Employment.repos
{
	public interface IEmplPaymentRepo
	{
		EmplPayment Create(EmplPayment payment);
		bool Delete(EmplPayment payment);
		bool Update(EmplPayment payment);
	}
}
