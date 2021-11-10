using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class CardAccountTransactionTypeConfiguration : IEntityTypeConfiguration<CardAccountTransactionType>
    {
        public void Configure(EntityTypeBuilder<CardAccountTransactionType> builder)
        {
            builder.HasKey(s => s.Id);

            builder
                .HasIndex(s => s.Name)
                .IsUnique();

            builder
                .HasIndex(s => s.SystemName)
                .IsUnique();
        }
    }
}
