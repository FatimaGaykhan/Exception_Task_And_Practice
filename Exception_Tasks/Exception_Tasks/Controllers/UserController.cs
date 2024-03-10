using System;
using Exception_Tasks.Models;
using Exception_Tasks.Services;

namespace Exception_Tasks.Controllers
{
	public class UserController
	{
		private readonly UserService _userService;
		public UserController()
		{
			_userService = new UserService();
		}

		public void GetAll()
		{
			User[] users = _userService.GetAll();
			foreach (var user in users)
			{
				Console.WriteLine($"{user.Name} {user.Surname} {user.Age} {user.Email} {user.Password}");
			}
		}

		public void Login()
		{
			Console.WriteLine("Please Enter Your Email:");
			string email = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password:");
            string password = Console.ReadLine();
            var result = _userService.Login(_userService.GetAll(),email,password);
			Console.WriteLine(result);
		}
	}
}

