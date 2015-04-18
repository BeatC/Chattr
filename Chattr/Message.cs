using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattr
{
    class Message
    {
        public Message(User author, MessageContent content)
        {

        }

        public bool EditContent(User editor)
        {
            if (editor == null)
            {
                editor = this.author;
            }
            return true;
        }

        private User author;
        private MessageContent content;


        // Author and Content are read-only properties. There is provided methods for
        // Changing of message content, but Author should have permission to do this
        public User Author
        {
            get {
                return this.author;
            }
        }

        public MessageContent Content
        {
            get
            {
                return this.content;
            }
        }
    }
}
