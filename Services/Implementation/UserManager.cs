using Services.CustomModels;
using System.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using Models;
using Data;

namespace Services.Implementation
{
    public class UserManager : IUserManager
    {

        private WebStoreDbContext context;
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public string LoginUser(LoginModel loginModel)
        {
            return " ";
        }

        public string RegisterUser(RegisterModel model)
        {
            try
            {
                using (context = new WebStoreDbContext())
                {
                    Person user = context.People.Where(x => x.Email == model.Email).FirstOrDefault();
                    if (user == null)
                    {
                        Person person = new Person()
                        {
                            Email = model.Email,
                            Password = model.Password, // PasswordHash
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            CreatedAt=DateTime.Now,
                            IsDeleted=false
                        };

                        context.People.Add(person);
                        context.SaveChanges();

                        return "";
                    }

                }
                return "Not added";
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
