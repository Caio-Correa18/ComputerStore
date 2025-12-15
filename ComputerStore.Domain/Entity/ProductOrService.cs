

using ComputerStore.Domain.Base;
using ComputerStore.Domain.Enum;

namespace ComputerStore.Domain.Entity
{
    public class ProductOrService : BaseEntity<int>
    {
        public ProductOrService() { }

        public ProductOrService(int id,string name,int storage,decimal price,
            TypeServiceOrProduct type, Supplier supplier) : base(id)
        {
            Name = name;
            Storage = storage;
            Price = price;
            Type = type;
            Supplier = supplier;
            

        }

        public string Name { get; set; }
        public int Storage { get; set; }
        public decimal Price { get; set; }
        public Supplier? Supplier { get; set; }
        public TypeServiceOrProduct Type { get; set; }
       
    }

    
}
