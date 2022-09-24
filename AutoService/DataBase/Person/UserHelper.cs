using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoService.Person
{
    public static class UserHelper
    {

        public static void InitializeUsers()
        {
            List<IBasicUserModel> users = new List<IBasicUserModel>
            {
                new UserModel { Id = 1, FirstName = "Adelina", LastName = "Krywaczuk",
                    Email = "example.gmail.com", PhoneNumber = "575575676" }
            };

           }
    }
}
