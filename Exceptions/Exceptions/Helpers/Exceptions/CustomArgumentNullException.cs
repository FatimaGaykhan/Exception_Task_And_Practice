using System;
namespace Exceptions.Helpers.Exceptions
{
	public class CustomArgumentNullException:Exception
	{
		public CustomArgumentNullException(string msj):base(msj)
		{
		}
		public CustomArgumentNullException(string parametr, string msj)
		{
			 
		}
	}
}

