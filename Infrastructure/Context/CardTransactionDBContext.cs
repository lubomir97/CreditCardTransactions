using Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Context
{
    public class CardTransactionDBContext : DbContext
    {
        public DbSet<CardAccount> CardAccounts { get; set; }
        public DbSet<CardAccountStatusType> CardAccountStatusTypes { get; set; }
        public DbSet<CardAccountTransaction> CardAccountTransactions { get; set; }
        public DbSet<CardAccountTransactionType> CardAccountTransactionTypes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientStatusType> ClientStatusTypes { get; set; }

        public CardTransactionDBContext(DbContextOptions<CardTransactionDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
