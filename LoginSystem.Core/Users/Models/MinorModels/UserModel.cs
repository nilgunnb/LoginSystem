using LoginSystem.Core.Users.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Core.Users.Models.MinorModels
{
    public class UserModel : BaseModel
    {
        private static int _id;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
