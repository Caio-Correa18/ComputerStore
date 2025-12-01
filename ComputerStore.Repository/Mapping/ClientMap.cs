using ComputerStore.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Repository.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            

            builder.ToTable("Client");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TypeCLient).HasConversion<string>().IsRequired();
            builder.Property( x => x.Document).IsRequired().HasMaxLength(100);
            
        }
    }
}
