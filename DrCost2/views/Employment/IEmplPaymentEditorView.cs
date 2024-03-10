using Core.Employment.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCost2.views.Employment
{
	public interface IEmplPaymentEditorView
	{
		void ShowModal(EmplPayment emplPayment);
		event EventHandler<EmplPayment> Completed;
	}
}
