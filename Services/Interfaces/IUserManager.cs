using Services.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserManager 
    {
        string RegisterUser(RegisterModel registerModel);
        string LoginUser(LoginModel loginModel);
        void DeleteUser(int id);
        void DeleteUser(string email);
    }
}
