

using ComputerStore.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Repository.Mapping
{
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IssueDate);
            builder.Property(x => x.Budget);
            builder.Property(x => x.Status).HasMaxLength(30);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.DeadLine);
            builder.Property(x => x.Solution).HasMaxLength(1000);
            builder.HasOne(x => x.Client);
            // Listas das tabelas de relação N para N
            builder.HasMany(x => x.SaleItens).WithOne(x => x.Ticket).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.TicketUsers).WithOne(x => x.Ticket).OnDelete(DeleteBehavior.Cascade);

        }
    }
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantity);
            builder.Property(x => x.TotalValue);
            builder.Property(x => x.UnityValue);
            //Chaves estrangeiras
            builder.HasOne(x => x.ProductOrService);
            builder.HasOne(x => x.Ticket).WithMany(x => x.SaleItens).OnDelete(DeleteBehavior.Cascade);

        }
    }

    public class TicketUserMap : IEntityTypeConfiguration<TicketUser>
    {
        public void Configure(EntityTypeBuilder<TicketUser> builder)
        {
            builder.ToTable("Ticket User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AssignmentDate);
            //Chaves estrangeiras
            builder.HasOne(x => x.User);
            builder.HasOne(x => x.Ticket).WithMany(x => x.TicketUsers).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
