using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ClientStatusTypeConfiguration : IEntityTypeConfiguration<ClientStatusType>
    {
        public void Configure(EntityTypeBuilder<ClientStatusType> builder)
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
