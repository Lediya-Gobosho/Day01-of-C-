﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExerciseInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a mathematical equation");

            string equation = Console.ReadLine();
            string operation = equation.Substring(1, 1);
            int number1 = Convert.ToInt32(equation.Substring(0, 1));
            int number2 = Convert.ToInt32(equation.Substring(2));

            double? result = null;

            double Val = 5.6;

            if (operation == "+")
                result = number1 + number2;
            else if (operation == "-")
                result = number1 - number2;
            else if (operation == "*")
                result = number1 * number2;
            else if (operation == "/")
                result = Convert.ToDouble(number1) / number2;

            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine("Cannot calculate value");

            Console.ReadLine();

        }
    }
}
