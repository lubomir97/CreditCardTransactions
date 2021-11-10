using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    class CardAccountConfiguration : IEntityTypeConfiguration<CardAccount>
    {
        public void Configure(EntityTypeBuilder<CardAccount> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .HasOne(c => c.Clients)
                .WithMany(c => c.CardAccounts)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(c => c.Amount)
                .HasPrecision(18, 4);

        }
    }
}
