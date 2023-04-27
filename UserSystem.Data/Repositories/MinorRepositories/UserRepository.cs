using LoginSystem.Core.Users.Models.MinorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSystem.Data.Repositories.BaseRepositories;

namespace UserSystem.Data.Repositories.MinorRepositories
{
    public class UserRepository : BaseRepository<UserModel>
    {
        private static readonly List<string> _emails = new List<string>();

        static UserRepository()
        {
            List<UserModel> Users = UserRepository.GetAllAsync();

            Users.Add(new UserModel("Nilgun", "Babazade", "nilgun@gmail.com", "1234"));

        }

        public static bool IsUniqueEmail(string Email)
        {
            return _emails.Find(email => email == Email) == null;
        }

    }
}

            


        

      
   
