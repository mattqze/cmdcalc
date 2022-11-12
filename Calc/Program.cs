using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "help")
            {
                Console.WriteLine("Usage:\n\tnumber + number\n\tnumber - number\n\tnumber x number\n\tnumber / number\n\tsqrt number\n\t-sqrt number\n\tnumber %o number\nNote:\n\tIf you would like to complain\n\tabout having only 2 numbers,\n\tplease make your own calculator by hand instead. =)\n");
                return;
            }
            //Define variables for argument 0 operations.
            double answer = 0;
            string first1 = null;
            string second1 = null;
            //Use try/catch due to index out of range error.
            try
            {
                first1 = args[0];
                second1 = args[1];
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.Write("Error: Missing/Misplaced Number and Operation");
                return;
            }
            if (args[0] == "sqrt")
            {
                //Calculate Square Root of first argument.
                answer = Math.Sqrt(int.Parse(args[1]));
                //Display answer.
                Console.Write(answer);
                //End.
                return;
            }
            if (args[0] == "-sqrt")
            {
                //Calculate Square Root of first argument.
                answer = Math.Sqrt(int.Parse(args[1]));
                //Display answer.
                Console.Write("-"+answer);
                //End.
                return;
            }
            //Define Numbers for normal operations.
            double first = 0;
            double second = 0;
            try
            {
                first = Convert.ToDouble(args[0]);
                second = Convert.ToDouble(args[2]);
            }
            catch(System.FormatException)
            {
                //Use this incase of misinputed arguments, allows default in switch to work.
            }
            switch (args[1])
            {
                //Check arguments for math operation sign, do work based on what sign.
                case "+":
                    //Add first number to second number.
                    answer = first + second;
                    //Display answer.
                    Console.Write(answer);
                    //End.
                    break;
                case "-":
                    //Subtract first number from second number.
                    answer = first - second;
                    //Display answer.
                    Console.Write(answer);
                    //End.
                    break;
                case "/":
                    //Divide first number by second number.
                    answer = first / second;
                    //Display answer.
                    Console.Write(answer);
                    //End.
                    break;
                case "x":
                    //Multiply first number by second number.
                    answer = first * second;
                    //Display answer.
                    Console.Write(answer);
                    //End.
                    break;
                case "%o":
                    //Divid first number by 100 then multiply by second number. 
                    answer = first / 100 * second;
                    //Display answer.
                    Console.Write(answer);
                    //End.
                    break;
                default:
                    //Get all arguments.
                    string log = string.Join(" ", args);
                    //If first argument = math operation, write out error, try to correct user.
                    if (args[0] == "+" || args[0] == "-" || args[0] == "x" || args[0] == "/")
                    {
                        Console.WriteLine("Error: Math Operation in Wrong Place.");
                        Console.Write("Did you mean: "+ args[1]+" " +args[0]+" " + args[2] +"? \n[Y/N]\n");
                        ConsoleKeyInfo cki = Console.ReadKey(true);
                        if(cki.Key == ConsoleKey.Y)
                        {
                            if (args[0] == "+")
                            {
                                answer = Convert.ToDouble(args[1]) + Convert.ToDouble(args[2]);
                            }
                            if (args[0] == "-")
                            {
                                answer = Convert.ToDouble(args[1]) - Convert.ToDouble(args[2]);
                            }
                            if (args[0] == "x")
                            {
                                answer = Convert.ToDouble(args[1]) * Convert.ToDouble(args[2]);
                            }
                            if (args[0] == "/")
                            {
                                answer = Convert.ToDouble(args[1]) / Convert.ToDouble(args[2]);
                            }
                            Console.Write(answer);
                            return;
                        }
                        if(cki.Key == ConsoleKey.N)
                        {
                            Console.Write("Canceled");
                            return;
                        }
                        else
                        {
                            Console.Write("Canceled");
                            return;
                        }
                    }
                    //Display error + argument log.
                    Console.Write("Error: " + log);
                    //End.
                    break;
            }
        }
    }
}
