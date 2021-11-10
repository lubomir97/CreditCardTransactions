using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class CardAccountTransactionConfiguration : IEntityTypeConfiguration<CardAccountTransaction>
    {
        public void Configure(EntityTypeBuilder<CardAccountTransaction> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .HasOne(c => c.CardAccount)
                .WithMany(c => c.CardAccountTransactions)
                .HasForeignKey(c => c.CardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(c => c.CardAccount)
                .WithMany(c => c.CardAccountTransactions)
                .HasForeignKey(c => c.CorrespondedCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(c => c.CardAccountTransactionType)
                .WithMany(c => c.CardAccountTransactions)
                .HasForeignKey(c => c.OperationType)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(c => c.Amount)
                .HasPrecision(18, 4);
        }
    }
}
