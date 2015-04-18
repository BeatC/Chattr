using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattr
{
    class Authentication
    {
        public Authentication(string login, string pass)
        {
            this.Login = login;
            this.Password = pass;
        }

        public bool SignIn()
        {
            // Implement authentication through XHR
            return true;
        }

        public string Password { get; set; }
        public string Login { get; set; }
    }
}
