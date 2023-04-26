using LoginSystem.Core.Users.Models.MinorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserSystem.Data.Repositories.MinorRepositories;

namespace LoginSystem.Core.Validations.UserValidation
{
    public static class UserValidator
    {


        public static async Task<bool> FirstNameValidator(string FirstName)
        {
            Regex FirstNameRegex = new Regex(@"^[A-Za-z]{3,30}");

            return FirstNameRegex.IsMatch(FirstName);
        }

        public static async Task<bool> LastNameValidator(string LastName)
        {
            Regex LastNameRegex = new Regex(@"^[A-Za-z]{5,20}");

            return LastNameRegex.IsMatch(LastName);
        }

        public static async Task<bool> EmailValidator(string Email)
        {
            

            Regex EmailRegex = new Regex(@"\.) +[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            return EmailRegex.IsMatch(Email) && UserRepository.IsUniqueEmail(Email);
        }

        public static async Task<bool> PasswordValidator(string Password)
        {

            Regex PassswordRegex = new Regex(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$");

            return PassswordRegex.IsMatch(Password);
        }
    }
}
















