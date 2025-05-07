using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClassFinancialEntities.Models
{
    public class Account
    {
		private readonly int Id;
		public int OwnerId { get; }
		public string Name { get; }
		public decimal Balance { get; set; }


		public Account(int ownerId, string name, decimal initialBalance)
		{
			Id = new Random().Next(1, 10000);
			OwnerId = ownerId;
			Name = name;
			Balance = initialBalance;
		}
		public bool Withdraw(decimal quantity)
		{
			if (Balance <= quantity)
			{
				throw new InvalidOperationException("Balance is smaller than the quantity you wanna withdraw");
			}
			else
			{
				Balance -= quantity;
				return true;
			}
		}
		public Transaction CreateTransaction(decimal amount, int senderAccId, int receiverAccId)
		{
			Transaction transfer = new Transaction(amount, senderAccId, receiverAccId);
			Console.WriteLine($"Transaction created for {transfer.Amount} from {transfer.SenderAccId} to {transfer.ReceiverAccId}");
			return transfer;
		}
	}

}
