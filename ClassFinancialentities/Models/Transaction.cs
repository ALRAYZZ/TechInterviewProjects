using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFinancialEntities.Models
{
    public class Transaction
    {
        private readonly Guid _id;
		private readonly int _receiverAccId;
        private readonly int _senderAccId;
        private readonly decimal _amount;

        
        public Transaction(decimal amount, int senderAccId, int receiverAccId)
        {
            _id = new Guid();
            _receiverAccId = receiverAccId;
            _senderAccId = senderAccId;
            _amount = amount;
        }

        // Read only properties
        public Guid Id => _id;
        public int ReceiverAccId => _receiverAccId;
        public int SenderAccId => _senderAccId;
        public decimal Amount => _amount;
    }
}
