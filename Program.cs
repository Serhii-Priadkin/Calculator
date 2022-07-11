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
            Console.WriteLine(first + " - " + second + " = " + subtraction.sub(first, second));

            Multiplication multiplication = new Multiplication();
            Console.WriteLine(first + " * " + second + " = " + multiplication.mul(first, second));

            Division division = new Division();
            Console.WriteLine(first + " / " + second + " = " + division.div(first, second));

            Factorial factorial = new Factorial();
            Console.WriteLine(firstInt + "!" +  " = " + factorial.fac(firstInt));

            Power power = new Power();
            string secondPow = second.ToString();
            string powOutput = "";
            string[] powerAr = { "\u2070", "\u00b9", "\u00b2", "\u00b3", "\u2074", "\u2075", "\u2076", "\u2077", "\u2078", "\u2079" };

            for (int a = 0; a < secondPow.Length; a++)
            {
                if (secondPow[a] == '.')
                {
                    powOutput += "\u00B7";
                }
                if (secondPow[a] == '-')
                {
                    powOutput += "\u207B";
                }
                for (int b = 0; b < powerAr.Length; b++)
                {
                    if (secondPow[a].ToString() == b.ToString())
                    {
                        powOutput += powerAr[b];
                    }

                }
            }
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(first + powOutput + " = " + power.pow(first, second));

            SquareRoot squareRoot = new SquareRoot();
            Console.WriteLine("\u221A" + first + " = " + squareRoot.sqrt(first));

        }
    }
}