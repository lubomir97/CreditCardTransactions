using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    class CardAccountStatusTypeConfiguration : IEntityTypeConfiguration<CardAccountStatusType>
    {
        public void Configure(EntityTypeBuilder<CardAccountStatusType> builder)
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
