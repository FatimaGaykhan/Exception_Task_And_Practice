using System;
using Exception_Tasks.Helpers.Constants;
using Exception_Tasks.Helpers.Exceptions;
using Exception_Tasks.Helpers.Responses;

namespace Exception_Tasks.Models
{
	public class Factorial
	{
		public FactorialResponse GetFactorialOfNumber(int n)
		{
            //try
            //{
            //    int result = 1;
            //    if (n < 0)
            //    {
            //        throw new NegativeNumberException("Number cannot be a negative");
            //    }

            //    for (int i = 1; i <= n; i++)
            //    {
            //        result *= i;
            //    }

            //    return result.ToString();
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //}

            try
            {
                int result = 1;
                if (n < 0)
                {
                    throw  new NegativeNumberException(FactorialResponseMessages.NegativeNumber);
                }

                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return new FactorialResponse { FactorialResult = result };

            }
            catch (Exception ex)
            {
                return new FactorialResponse { ExceptionMessage=ex.Message};
            }



        }
	}
}

