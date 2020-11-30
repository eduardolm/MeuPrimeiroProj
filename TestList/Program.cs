using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = new List<User>
            {
                new User(1, "nome1", "email1", "username1", "senha1", "fone1", 0),
                new User(2, "nome2", "email2", "username2", "senha2", "fone2", 1),
                new User(3, "nome3", "email3", "username3", "senha3", "fone3", 0),
                new User(4, "nome4", "email4", "username4", "senha4", "fone4", 1),
                new User(5, "nome5", "email5", "username5", "senha5", "fone5", 0)
            };

            var id = 1;
            var indice = userList.FindIndex(x => x.Id == id);
            userList.Remove(userList[indice]);
            foreach (var VARIABLE in userList)
            {
                Console.WriteLine(VARIABLE.FullName);
            }
        }
    }
}