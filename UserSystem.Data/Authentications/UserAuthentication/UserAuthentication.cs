using LoginSystem.Core.Users.Models.MinorModels;
using LoginSystem.Core.Validations.UserValidation;
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



        public static string GetFirstName()
        {
            Console.WriteLine("Please, add Name:");

            string NewFirstName = Console.ReadLine();

            while (UserValidator.FirstNameValidator(NewFirstName))
            {
                Console.WriteLine("Please, add valid Name:");

                NewFirstName = Console.ReadLine();
            }

            return NewFirstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please, add Surname:");

            string NewLastName = Console.ReadLine();

            while(UserValidator.LastNameValidator(NewLastName))
            {
                Console.WriteLine("Please, add valid Surname:");

                NewLastName = Console.ReadLine();
            }

            return NewLastName;
        }

        public static string GetEmail()
        {
            Console.WriteLine("Please, add Email:");

            string NewEmail = Console.ReadLine();

            while(UserValidator.EmailValidator(NewEmail))
            {
                Console.WriteLine("Please, add valid Email:");

                NewEmail = Console.ReadLine();
            }

            return NewEmail;
        }

        public static string GetPassword()
        {
            Console.WriteLine("Please, add Password:");

            string NewPassword = Console.ReadLine();

            while (UserValidator.PasswordValidator(NewPassword))
            {
                Console.WriteLine("Please, add valid Password");

                Console.WriteLine("Ypur password must have at least:");

                Console.WriteLine("8 characters (max 30)");

                Console.WriteLine("1 special character");

                Console.WriteLine("");


                NewPassword = Console.ReadLine();
            }

            return NewPassword;
        }
                

            
        


            
        

        public bool Autentication(string Email, string Password)
        {
            return UserList.Find(user => user.Email == Email && user.Password == Password) != null;
        }





    }
}

      






