using System;
using Exception_Tasks.Models;

namespace Exception_Tasks.Services.Interfaces
{
	public interface IUserService
	{
		public User[] GetAll(); 
		public string Login(User[] users,string email,string password);
	}
}

