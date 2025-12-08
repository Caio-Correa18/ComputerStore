using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Domain.Entity;

namespace ComputerStore.App.ViewModel
{
    public class UserViewModel
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Boolean IsEnable { get; set; }

    }
}
