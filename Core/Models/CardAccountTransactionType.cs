using System.Collections.Generic;

namespace Core.Models
{
    public class CardAccountTransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }

        public ICollection<CardAccountTransaction> CardAccountTransactions { get; set; }
    }
}
