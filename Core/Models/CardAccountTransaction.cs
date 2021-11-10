using System;

namespace Core.Models
{
    public class CardAccountTransaction
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int CorrespondedCardId { get; set; }
        public CardAccount CardAccount { get; set; }
        public DateTime TimeStamp { get; set; }
        public int OperationType { get; set; }
        public CardAccountTransactionType CardAccountTransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }

    }
}
