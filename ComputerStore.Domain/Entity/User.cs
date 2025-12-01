

using ComputerStore.Domain.Base;

namespace ComputerStore.Domain.Entity
{
    public class User : BaseEntity<int>
    {
        public User() { }

        public User(int id,string name,Boolean isEnable,
            string login, string password) : base(id)
        {
            Name = name;            
            Login = login;
            Password = password;
            IsEnable = isEnable;

        }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Boolean IsEnable { get; set; }
        
    }

    
}
