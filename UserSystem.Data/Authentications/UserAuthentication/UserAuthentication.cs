using LoginSystem.Core.Users.Models.MinorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSystem.Data.Repositories.MinorRepositories;

namespace UserSystem.Data.Authentications.UserAuthentication
{
    public class UserAuthentication
    {
        List<UserModel> UserList = UserRepository.GetAllAsync();

        

        

        public bool Autentication (string Email, string Password)
        {
            return UserList.Find(user => user.Email == Email && user.Password == Password) != null;
        }
    }
}

      






