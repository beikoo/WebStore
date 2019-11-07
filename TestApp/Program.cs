using System;
using Services.Implementation;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager um = new UserManager();
            um.RegisterUser(new Services.Models.RegisterModel() { Email = "tesst@da.bg", FirstName = "dd", LastName = "dd", Password = "Dd123dd!1", ConfirmPassword = "Dd123dd!1" });
        }
    }
}
