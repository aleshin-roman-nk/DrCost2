﻿using Core.CashReceipts.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CashReceipts
{
	public class CashReceiptService
	{
		private readonly ICashReceiptRepo cashReceiptRepo;

		public CashReceiptService(ICashReceiptRepo cashReceiptRepo)
		{
			this.cashReceiptRepo = cashReceiptRepo;
		}

		public IEnumerable<CashReceipt> GetAll()
		{
			return cashReceiptRepo.GetAll();
		}

		public CashReceipt Create(CreateCashReceiptDto dto)
		{
			return cashReceiptRepo.Create(dto);
		}
	}
}
