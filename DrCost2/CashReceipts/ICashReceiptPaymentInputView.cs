﻿using DrCost2.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.CashReceipts
{
	public interface ICashReceiptPaymentInputView
	{
		void ShowModal();
		event EventHandler<EnteredPaymentDto> Completed;
	}
}
