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

        public static bool IsUniqueEmail(string model)
        {
            return _emails.Find(x => x == model) == null;
                
        }
    }
}
