using Exception_Tasks.Controllers;
using Exception_Tasks.Models;

//Factorial _factorial = new Factorial();
//var result = _factorial.GetFactorialOfNumber(-5);
//if (result.FactorialResult==null)
//{
//    Console.WriteLine(result.ExceptionMessage);
//}
//else
//{
//    Console.WriteLine(result.FactorialResult);
//}

UserController userController = new();
//userController.GetAll();
userController.Login();

