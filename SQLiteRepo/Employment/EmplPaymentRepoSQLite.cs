using Core.Employment.entity;
using Core.Employment.repos;
using SQLiteRepo.Employment.ent;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLiteRepo.Employment
{
	public class EmplPaymentRepoSQLite : IEmplPaymentRepo
	{
		private readonly AppData db;

		public EmplPaymentRepoSQLite(AppData db)
		{
			this.db = db;
		}
		public EmplPayment Create(EmplPayment payment)
		{
			var payToCreate = new EmplPaymentDb
			{
				completed = payment.completed,
				amount = payment.amount,
				description = payment.description,
				employeeId = payment.employeeId,
				emplPaymentSourceId = payment.emplPaymentSourceId,
				name = payment.name,
				price = payment.price,
				tagId = payment.tagId
			};

			db.EmplPayments.Add(payToCreate);
			db.SaveChanges();

			var tag = db.EmplPaymentTags.FirstOrDefault(x => x.id == payToCreate.tagId);

			var res = new EmplPayment
			{
				id = payToCreate.id,
				description = payToCreate.description,
				completed = payToCreate.completed,
				amount = payToCreate.amount,
				employeeId = payToCreate.employeeId,
				name = payToCreate.name,
				price = payToCreate.price,
				tagId = payToCreate.tagId,
				tagName = tag.name
			};

			return res;
		}

		public bool Delete(EmplPayment payment)
		{
			var o = db.EmplPayments.FirstOrDefault(x => x.id == payment.id);
			if (o == null) return false;

            db.EmplPayments.Remove(o);
			return db.SaveChanges() > 0;
		}

		public bool Update(EmplPayment payment)
		{
			var pToUpdate = db.EmplPayments.FirstOrDefault(x => x.id == payment.id);

			if (pToUpdate == null) return false;

			pToUpdate.amount = payment.amount;
			pToUpdate.completed = payment.completed;
			pToUpdate.description = payment.description;
			pToUpdate.price = payment.price;

			return db.SaveChanges() > 0;
		}
	}
}
