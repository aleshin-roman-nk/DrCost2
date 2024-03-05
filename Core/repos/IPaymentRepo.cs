using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.dto;
using Core.entity;

namespace Core.repos
{
    public interface IPaymentRepo
	{
		IEnumerable<Payment> Get(int year, int month);
		IEnumerable<Payment> Get(DateTime dtFrom, DateTime dtTo);
		IEnumerable<Payment> GetAll();
		decimal GetTotalSpend();

		void CreateRange(IEnumerable<CreatePaymentDto> dtos);
	}
}
