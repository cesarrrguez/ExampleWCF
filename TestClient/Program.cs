using System;
using ServiceReference;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new LoginServiceClient();

            Console.WriteLine("Enter login:");
            var login = Console.ReadLine();

            Console.WriteLine("Enter password:");
            var password = Console.ReadLine();

            var user = new User
            {
                Login = login,
                Password = password
            };

            var result = client.ValidateLoginAsync(user).Result;
            Console.WriteLine(result ? "Successful connection" : "Failed connection");
        }
    }
}
