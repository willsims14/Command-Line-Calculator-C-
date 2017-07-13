using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static decimal add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public static decimal divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            decimal final_result;
            decimal num1, num2;
            Console.WriteLine("Enter an operator.");
            var userInput = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (userInput)
            {
                case '+':
                    final_result = add(num1, num2);
                    break;
                case '-':
                    final_result = subtract(num1, num2);
                    break;
                case '*':
                    final_result = multiply(num1, num2);
                    break;
                case '/':
                    final_result = divide(num1, num2);
                    break;
                default:
                    final_result = 0;
                    break;
            }

            Console.WriteLine("FINAL RESULT: " + final_result);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}










