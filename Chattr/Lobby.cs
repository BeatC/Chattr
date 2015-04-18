using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattr
{
    class Lobby
    {
        public Lobby(string title, List<User> users)
        {
            this.title = title;
            this.users = users;
        }

        // Method providing sending new Message to the Lobby history
        public bool PushMessage(Message msg)
        {
            User author = msg.Author;
            if (this.UserInList(author) && author.Permission == Permission.WRITE)
            {
                this.messages.Add(msg);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method providing adding new users to the Lobby instance.
        // The first argument is new User, the second - User, who adds (for checking the permissions)
        public bool AddUser(User newUser, User editor)
        {
            if (this.UserInList(editor) && editor.Permission == Permission.WRITE)
            {
                this.users.Add(newUser);
                return true;
            }
            else
                return false;
        }

        // Method providing removing users in the Lobby instance.
        // The first argument is the name of the removable User,
        // The second one is the name of the person, who removes (checks permission)
        public bool RemoveUser(User remUser, User editor)
        {
            if (this.UserInList(editor) && editor.Permission == Permission.WRITE)
                return this.users.Remove(remUser);
            else
                return false;
        }

        // Checks if the user in the list of users for this current lobby
        private bool UserInList (User user) {
            return true;
        }

        private List<User> users;
        private List<Message> messages;
        private string title;

        public List<User> Users
        {
            get
            {
                return this.users;
            }
        }

        public List<Message> Messages
        {
            get
            {
                return this.messages;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
        }
    }
}
