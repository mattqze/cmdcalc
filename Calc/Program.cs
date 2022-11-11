using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define variables for 0 argument operations.
            double answer = 0;
            string first1 = null;
            string second1 = null;
            try
            {
                first1 = args[0];
                second1 = args[1];
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.Write("Error: Missed spaces inbetween numbers and operation.");
                return;
            }

            if (args[0] == "sqrt")
            {
                answer = Math.Sqrt(int.Parse(second1));
                Console.Write(answer);
                return;
            }
            //Define Numbers for normal operations.
            double first = 0;
            double second = 0;
            try
            {
                first = int.Parse(args[0]);
                second = int.Parse(args[2]);
            }
            catch(System.FormatException)
            {
                //Use this incase of misinputed arguments, allows default in switch to work.
            }
            switch (args[1])
            {
                //Check arguments for math operation sign, do work based on what sign.
                case "+":
                    answer = first + second;
                    Console.Write(answer);
                    break;
                case "-":
                    answer = first - second;
                    Console.Write(answer);
                    break;
                case "/":
                    answer = first / second;
                    Console.Write(answer);
                    break;
                case "x":
                    answer = first * second;
                    Console.Write(answer);
                    break;
                case "%o":
                    answer = first / 100 * second;
                    Console.Write(answer);
                    break;
                default:
                    string log = string.Join(" ", args);
                    //If first argument = math operation, write out error, try to correct user.
                    if (args[0] == "+" || args[0] == "-" || args[0] == "x" || args[0] == "/")
                    {
                        Console.WriteLine("Error: Math Operation in Wrong Place.");
                        Console.Write("Did you mean: "+ args[1]+" " +args[0]+" " + args[2] +"?");
                        return;
                    }
                    Console.Write("Error: " + log);
                    break;
            }
        }
    }
}
