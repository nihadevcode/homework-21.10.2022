using homework_21._10._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework_21._10._2022.Models
{
    class Calculation : ICalculation
    {
        public string Calculator()
        {
            Console.WriteLine("Please enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the operation (ex: +, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Please enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;
            }
            Console.WriteLine("Result is:");
            return result.ToString();
        }
    }
}
