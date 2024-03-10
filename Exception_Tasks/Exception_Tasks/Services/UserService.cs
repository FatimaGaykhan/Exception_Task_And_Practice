using System;
using Exception_Tasks.Helpers.Exceptions;
using Exception_Tasks.Models;
using Exception_Tasks.Services.Interfaces;

namespace Exception_Tasks.Services
{
    public class UserService : IUserService
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                Id=1,
                Name = "Fatima",
                Surname = "Gaykhanova",
                Age = 22,
                Email = "fatima@code.edu.az",
                Password = "Fatya123"
            };
            User user2 = new()
            {
                Id=2,
                Name = "Sadigkhan",
                Surname = "Gaykhanov",
                Age = 26,
                Email = "sadigkhan@code.edu.az",
                Password = "Sadigkhan123"
            };
            User user3 = new()
            {
                Id=3,
                Name = "Inji",
                Surname = "Gaykhanova",
                Age = 27,
                Email = "inji@code.edu.az",
                Password = "Inji123"
            };

            User[] users = { user1, user2, user3 };
            return users;
        }

        public string Login(User[] users,string email, string password)
        {
            string message = "";
            try
            {
                if (password.Length < 6)
                {
                    throw new PasswordLengthException("Password length must be greater than 6");
                }
                //users.Where(m => m.Email.Equals(email) && m.Password.Equals(password));
                foreach (var user in users)
                {
                    if (user.Email==email&&user.Password==password)
                    {
                        message = "Login Succesfully";
                        break;
                    }
                    else
                    {
                        throw new LoginFailedException("Login Failed.Password or Email is Wrong");
                    }
                }

                return message;


            }
            catch (Exception ex)
            {
                return message = ex.Message;
            }

        }
      


    }
}

