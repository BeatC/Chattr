using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattr
{
    class User
    {
        public User(string login, string pass, Permission perm)
        {
            if (this.VerifyLogin(login))
            {
                this.login = login;
            }
            else
            {
                // TODO: Generate an Error while creating of user (login)
            }

            if (this.VerifyPassword(pass))
            {
                this.password = pass;
            }
            else
            {
                // TODO: generate an Error while creating of object (pass)
            }

            this.permission = perm;
        }

        public bool SendMessage()
        {
            return true;
        }

        public Lobby CreateLobby(string title)
        {
            List<User> users = new List<User>();
            users.Add(this);
            return new Lobby(title, users);
        }

        public bool ChangePassword()
        {
            return true;
        }

        protected bool VerifyPassword(string pass)
        {
            return true;
        }

        protected bool VerifyLogin(string login)
        {
            return true;
        }

        private string login;
        private string password;
        private Permission permission;

        public string Login { get { return this.login; } }
        
        // Property representing encrypted user password
        public string Password { get { return this.password; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        
        // Signature defines text signature that can be attached to each message
        // sent by this instance of User
        public string Signature { get; set; }

        // Permission property defines permissions for each user
        // For example, User can be permitted to read only messages
        // Or he/she can send messages but doesn't have permissions to remove the last
        public Permission Permission { get { return this.permission; } }
    }
}
