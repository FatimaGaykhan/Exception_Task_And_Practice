using Exceptions.Helpers.Exceptions;

void Calculate()
{
    bool isCorrectCalculate = true;
    try
    {
        int a = 5;
        int b = 0;
        //var result = a / b;
        //Console.WriteLine(result);
      
        int[] arr = { 1, 2, 3 };
        //arr[5] = 100;

    }
    catch (Exception ex)
    {
        isCorrectCalculate = false;
    }
    finally
    {
        SendMessage(isCorrectCalculate);
    }
}
//Calculate();

void SendMessage(bool isCorrectCalculate)
{
    if (isCorrectCalculate)
    {
        Console.WriteLine("Your Message Successfully");
    }
    else
    {
        Console.WriteLine("Your message failed");
    }
}

string GetById(int? id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException(nameof(id),"Salam, Menem exception");

            throw new CustomArgumentNullException("Argument Cannot Be Null");
        }

        //ArgumentNullException.ThrowIfNull(id);


        return "Kamran Bey";
    }
    catch (Exception ex)
    {
        return ex.Message;
    }
}

var result=GetById(null);
Console.WriteLine(result);

 