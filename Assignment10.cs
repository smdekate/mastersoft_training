using System;

// Custom namespace
namespace ExceptionNamespace
{
    // Class handling all exceptions
    class ExceptionHandler
    {
        public void HandleDivision(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
            }
        }
    }
}


namespace Assignment10
{
    using ExceptionNamespace; // Import the exception handling namespace

    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandler exceptionHandler = new ExceptionHandler();

            // Taking user input for division
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            exceptionHandler.HandleDivision(num1, num2);

            Console.ReadKey();
        }
    }
}
