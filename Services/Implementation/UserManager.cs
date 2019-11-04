using Services.CustomModels;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class UserManager : IUserManager
    {
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public void LoginUser(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(RegisterModel registerModel)
        {
            throw new NotImplementedException();
        }
    }
}
