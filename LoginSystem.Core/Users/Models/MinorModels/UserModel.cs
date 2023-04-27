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

        public UserModel(string FirstName, string LastName, string Email, string Password)
        {
            _id++;
            Id = _id;

            this.FirstName = FirstName;

            this.LastName = LastName;

            this.Email = Email;

            this.Password = Password;
        }
    }
}




   


