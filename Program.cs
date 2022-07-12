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
            string equation = Console.ReadLine();

            // Next part of code it's like a block of certain mathematic action

            // converting input to CharArray

            char[] eqArray = equation.ToCharArray();

            // declaring variables

            string first = "", second = "", op = "";
            double firstNum = 0, secondNum = 0, equal = 0;

            // for math actions which beginning with number

            if (Char.IsNumber(eqArray[0]) || eqArray[0] == '-')
            {

                // determines negative or positive the first number

                int i = 0;
                if (eqArray[0] == '-')
                {
                    first += '-';
                    i++;
                }

                // adding a name of the first number to string 'first'

                for (; Char.IsNumber(eqArray[i]) || eqArray[i] == '.'; i++)
                {
                    first += eqArray[i];
                }

                // adding a name of the operator(symbol) to string 'op'

                op += eqArray[i];


                //              FACTORIAL


                // determines a symbol of the operator 

                if (op == "!")
                {

                    // to outputting error if not whole number

                    if (first.Contains("."))
                    {
                        Console.WriteLine($"Can't do this!\n {first} - isn't a whole number!");
                    }


                    // to outputting error if not positive number

                    if (first.Contains("-"))
                    {
                        Console.WriteLine($"Can't do this!\n {first} - isn't a positive number!");
                    }


                    // if factorial's conditions is ok, startes doing the action

                    else
                    {
                        int firstInt = Convert.ToInt32(first);
                        Factorial factorial = new Factorial();
                        Console.WriteLine(firstInt + "!" + " = " + factorial.fac(firstInt));
                    }
                }
                else
                {
                    i++;
                    for (; i < eqArray.Length; i++)
                    {
                        second += eqArray[i];
                    }


                    // to convert string 'first' and 'second' to double 'firstNum' and 'secondNum'

                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);



                    //        ARITHMETIC OPERATIONS


                    // determines a symbol of the operator


                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        if (op == "+")
                        {
                            Addition addition = new Addition();
                            Console.WriteLine(first + " + " + second + " = " + addition.add(firstNum, secondNum));
                        }
                        if (op == "-")
                        {
                            Subtraction subtraction = new Subtraction();
                            Console.WriteLine(first + " - " + second + " = " + subtraction.sub(firstNum, secondNum));
                        }
                        if (op == "*")
                        {
                            Multiplication multiplication = new Multiplication();
                            Console.WriteLine(first + " * " + second + " = " + multiplication.mul(firstNum, secondNum));
                        }
                        if (op == "/")
                        {
                            Division division = new Division();
                            Console.WriteLine(first + " / " + second + " = " + division.div(firstNum, secondNum));
                        }
                    }

                    //     MATHEMATICAL POWER OF THE NUMBER


                    // Math Power outputting uses unicodes of symbols in this program

                    Console.OutputEncoding = Encoding.Unicode;
                    if (op == "^")
                    {
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
                        Console.WriteLine(first + powOutput + " = " + power.pow(firstNum, secondNum));
                    }
                }
            }



            // checking first character again, for next group of actions

            if (!Char.IsNumber(eqArray[0]) && eqArray[0] != '-')
            {

                // determinate operator and first number

                int i = 0;
                for (; !Char.IsNumber(eqArray[i]) && eqArray[i] != '-'; i++)
                {
                    op += eqArray[i];
                }

                for (; i < eqArray.Length; i++)
                {
                    first += eqArray[i];
                }

                // converting to double 'firstNum' 

                firstNum = Convert.ToDouble(first);



                // SQUARE ROOT       

                if (op.Contains('V')|| op.Contains('v'))
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    SquareRoot squareRoot = new SquareRoot();
                    Console.WriteLine("\u221A" + firstNum + " = " + squareRoot.sqrt(firstNum)); 
                }

                // TRIGONOMETRIC ACTIONS

                if (op == "cos")
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.Write("cos(" + first + "\u00B0) = ");
                    equal = Math.Cos(firstNum);
                }
                if (op == "sin")
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.Write("sin(" + first + "\u00B0) = ");
                    equal = Math.Sin(firstNum);
                }
                if (op == "tan")
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.Write("tan(" + first + "\u00B0) = ");
                    equal = Math.Tan(firstNum);
                }
                Console.Write(equal);

            }
        }
    }
}