using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello... Thank you for tryng my application. It computes the factorial of a number.");
            //Console.ReadLine();
            Console.WriteLine("Enter a number.");

            try
            {
                
                    Int64 number = Convert.ToInt64(Console.ReadLine());

                    Int64 result = Factorial(number);
                if (result == 0)
                {
                    Console.WriteLine("You cannot compute the factorial of a negative number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The factorial of " + number + " is " + result);
                    Console.ReadLine();
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+ " Enter a valid number.");
                Console.ReadLine();
                //throw;
            }
            

        }


        protected static Int64 Factorial(Int64 num)
        {
            Int64 result = 1;
            

            
            //I did not want to return a string or throw exception. So, I chose zero.
            if (num < 0)
            {
               result = 0;
            }

            if (num == 0 || num == 1)
            {
                result = 1;
            }
            for (Int64 i = 1; i < num + 1; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
