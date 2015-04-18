using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattr
{
    // READ flag provides read-only permissions for the User in this current Lobby
    // WRITE flag provides read and write permissions for the User in this current Lobby
    // SUDO - the same as WRITE but it provides some advanced features like changing of lobby
    // title, removing users, clearing the history of messages
    enum Permission { READ = 0, WRITE, SUDO};
}
