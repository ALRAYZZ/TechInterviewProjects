using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionProcessor.Enums;

namespace TransactionProcessor.Classes
{
    public class Transaction
    {
		private static int _idCount = 0; // Simple static property to generate unique IDs
		private readonly int _id;
		private readonly decimal _amount;
		private readonly TransactionType _transactionType;
		private readonly DateTime _dateTime = DateTime.Now;
		
		public Transaction(decimal amount, TransactionType transactionType)
		{
			if (amount <= 0)
			{
				throw new ArgumentException("Amount must be a positive value.");
			}


			_id = _idCount++;
			_amount = amount;
			_transactionType = transactionType;
		}

		public int Id => _id;
		public decimal Amount => _amount;
		public TransactionType TransactionType => _transactionType;
		public DateTime DateTime => _dateTime;
	}
}
