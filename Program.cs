using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            int firstInt = Convert.ToInt32(Console.ReadLine());

            Addition addition = new Addition();
            Console.WriteLine(first + " + " + second + " = " + addition.add(first, second));

            Subtraction subtraction = new Subtraction();
            Console.WriteLine(first + " / " + second + " = " + subtraction.sub(first, second));

            Multiplication multiplication = new Multiplication();
            Console.WriteLine(first + " / " + second + " = " + multiplication.mul(first, second));

            Division division = new Division();
            Console.WriteLine(first + " / " + second + " = " + division.div(first, second));

            Factorial factorial = new Factorial();
            Console.WriteLine(firstInt + "!" +  " = " + factorial.fac(firstInt));

        }
    }
}