using ComputerStore.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComputerStore.Repository.Mapping
{
    public class ProductOrServiceMap : IEntityTypeConfiguration<ProductOrService>
    {
        public void Configure(EntityTypeBuilder<ProductOrService> builder)
        {
            builder.ToTable("Product or Service");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Price);
            builder.Property(x => x.Storage);
            builder.Property(x => x.Type).HasConversion<string>().IsRequired();
            builder.HasOne(x => x.Supplier);

        }
    }
    
}
