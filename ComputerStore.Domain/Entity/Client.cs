using ComputerStore.Domain.Base;
using ComputerStore.Domain.Enum;


namespace ComputerStore.Domain.Entity
{
    public class Client : BaseEntity<int>
    {
        public Client() { }


        public Client(int id,string name,int phone,string email, 
                TypeClient typeClient, string document) : base(id)
        {
            Name = name;
            Phone = phone;
            Email = email;
            TypeCLient = typeClient;
            Document = document;

        }

        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        
        public TypeClient TypeCLient { get; set; }        
        public string Document { get; set; }
    }

    

}
