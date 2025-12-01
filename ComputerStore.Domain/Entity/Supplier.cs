

using ComputerStore.Domain.Base;

namespace ComputerStore.Domain.Entity
{
    public class Supplier : BaseEntity<int>
    {
        public Supplier() { }

        public Supplier(int id, string name, int phone, string email,
            string document,string adress) : base(id)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Document = document;
            Adress = adress;

        }

        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string Adress { get; set; }

    }
}
