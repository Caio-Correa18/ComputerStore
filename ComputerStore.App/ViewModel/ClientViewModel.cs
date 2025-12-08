using ComputerStore.Domain.Entity;
using ComputerStore.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.App.ViewModel
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public TypeClient TypeCLient { get; set; }
        public string Document { get; set; }

    }
}
