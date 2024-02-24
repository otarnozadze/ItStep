using System.ComponentModel.Design;

namespace calculatorlProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex);
               Console.WriteLine("lets try again");
               Calculator();
            }
            #region Methods
            void Calculator()
            {
                Console.WriteLine("Choose first number");
                if (double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine();
                }
                else
                {
                    throw new Exception("Please choose valid number");
                }
                Console.WriteLine("Choose second number");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine();
                }
                else
                {
                    throw new Exception("Please choose valid number");
                }
                Console.WriteLine("Choose operation +, -, *, / ");
                char.TryParse(Console.ReadLine(), out char operation);

                if (operation == '+')
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (operation == '-')
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (operation == '*')
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (operation == '/')
                {
                    if(num2== 0)
                    {
                        throw new DivideByZeroException("you cannot divide by zero");
                    }
                    Console.WriteLine(num1 / num2);
                }
                else
                {
                   throw new Exception("Please choose correct operation");
                }
            }
            #endregion
        }
    }   
}