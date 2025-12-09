using ComputerStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.App.Others
{
    public static class Session
    {
        public static User? LoggedInUser{ get; set; }
        public static bool IsLogged => LoggedInUser != null;
        public static void Logout()
        {
            LoggedInUser = null;
        }
    }
}
