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
            Addition addition = new Addition(first, second);
            Console.WriteLine(first + " + " + second + " = " + addition.Sum);
            Substraction substraction = new Substraction(first, second);
            Console.WriteLine(first + " - " + second + " = " + substraction.Sub);
            Multiplication multiplication = new Multiplication(first, second);
            Console.WriteLine(first + " * " + second + " = " + multiplication.Mul);
        }
    }
}