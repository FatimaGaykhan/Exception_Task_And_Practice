using System;
namespace Exception_Tasks.Helpers.Exceptions
{
	public class PasswordLengthException:Exception
	{
		public PasswordLengthException(string msj):base(msj)
		{
		}
	}
}

