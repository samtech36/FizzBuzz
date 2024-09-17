namespace FizzBuzz;

public class Program
{
    public static void Main(string[] args)
    {
        //introduction of the program
       Console.WriteLine("Hello. Welcome to FizzBuzz!");
       Console.WriteLine("Please enter a number:");
       
       //enter the number
       int userInput = Convert.ToInt32(Console.ReadLine()); 
       
       //generate the output
       Program program = new Program();
       string result = program.FizzBuzz(userInput);
       Console.WriteLine(result);
       
       
        
    }
    
    //public method that accepts a number
    public string FizzBuzz(int divisible)
    {
        
        
        if (divisible % 3 == 0 && divisible % 5 == 0)
        {
           return "fizzbuzz";
        }
        else if (divisible % 3 == 0)
        {
            return "fizz";
        }
        else if (divisible % 5 == 0)
        {
            return "buzz";
        }
        else
        {
           return "not fizz nor buzz";
        }



    }

}