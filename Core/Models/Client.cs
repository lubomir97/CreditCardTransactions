using Core.Enums;
using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Client
    {
        public  int Id {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email{ get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Status Status { get; set; }
        public ICollection<CardAccount> CardAccounts { get; set; }
    }
}
