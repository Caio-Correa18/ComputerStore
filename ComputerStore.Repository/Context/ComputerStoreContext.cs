using ComputerStore.Domain.Entity;
using ComputerStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ComputerStore.Repository.Context
{
    public class ComputerStoreContext : DbContext
    {
        public ComputerStoreContext(DbContextOptions<ComputerStoreContext>? options = null ) : base(options)
        {
            Database.EnsureCreated();
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
                optionsBuilder.UseMySQL
                ("server=localhost;database=ComputerStore;user=root;password=");
             
            


        }

        
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ProductOrService> ProductOrServices { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<TicketUser> TicketUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Ticket>(new TicketMap().Configure);
            modelBuilder.Entity<ProductOrService>(new ProductOrServiceMap().Configure);
            modelBuilder.Entity<Supplier>(new SupplierMap().Configure);
            modelBuilder.Entity<Client>(new ClientMap().Configure);
            modelBuilder.Entity<Sale>(new SaleMap().Configure);
            modelBuilder.Entity<TicketUser>(new TicketUserMap().Configure);
       

        }
    }
}
