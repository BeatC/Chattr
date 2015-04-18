using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattr
{
    class Program
    {
        static void Main(string[] args)
        {
            User me = new User("BeatCoder", "password", Permission.WRITE);
            Lobby frontend = me.CreateLobby("Frontend Development");

            User johnDoe = new User("JohnDoe", "pass", Permission.WRITE);
            User janeSmith = new User("JaneSmith", "pass", Permission.WRITE);
            frontend.AddUser(johnDoe, me);
            frontend.AddUser(janeSmith, me);

            foreach (var list in frontend.Users)
            {
                Console.WriteLine(list.Login);
            }
            Console.ReadKey(true);
        }
    }
}
