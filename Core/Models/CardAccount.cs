using Core.Enums;
using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class CardAccount
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Clients { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Status Status { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public ICollection<CardAccountTransaction> CardAccountTransactions { get; set; }
    }
}
