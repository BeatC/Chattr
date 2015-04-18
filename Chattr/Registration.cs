using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattr
{
    class Registration
    {
        public Registration(User user = null)
        {
            this.RegisteredUser = user;
        }

        public bool SignUp()
        {
            if (this.RegisteredUser != null)
            {
                return true;
            }
            return false;
        }

        public User RegisteredUser { get; set; }
    }
}
