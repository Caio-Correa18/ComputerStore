using ComputerStore.Domain.Entity;
using ComputerStore.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.App.ViewModel
{
    public class ProductOrServiceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Storage { get; set; }
        public decimal Price { get; set; }
        public Supplier? Supplier { get; set; }
        public TypeServiceOrProduct Type { get; set; }

    }
}
