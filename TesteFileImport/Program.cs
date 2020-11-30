using System;
using TesteFileImport.Codenation.Challenge.Models;

namespace TesteFileImport
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeContext fakeContext = new FakeContext();

            var teste = fakeContext.GetFakeData<User>();

            foreach (var user in teste)
            {
                Console.WriteLine($"Id: {user.Id} - Name: {user.FullName}");
            }
        }
    }
}