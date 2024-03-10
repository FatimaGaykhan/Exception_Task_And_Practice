using System;
namespace Exception_Tasks.Models
{
	public class User:BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }


	}
}

