using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first digit: ");
            string first = Console.ReadLine();
            Console.WriteLine(" ");
            double a = Convert.ToDouble(first);

            for (int i = 0; i < 1000; i++ )
            {

                string oper = GetOperation();
                double b = GetAnotherDigit();

                double res = Calculate(a, b, oper);
                
                Console.WriteLine("result = {0}", res);
                Console.WriteLine(" ");

                a = res;

            }
            Console.ReadKey();
        }

        static string GetOperation()
        {
            Console.Write("Choose operation:\n 1: '+' \n 2: '-' \n 3: '/' \n 4: '*' \n 5: '%' \n 6: 'pow' \n");
            Console.WriteLine(" ");
            string res = Console.ReadLine();            
            return res;
        }

        static double GetAnotherDigit()
        {
            Console.Write("Input another digit: ");
            Console.WriteLine(" ");
            string y = Console.ReadLine();
            double b = 0;
            if (!double.TryParse(y, out b))
            {
                Console.WriteLine("You had to input a digit!!!");
            }else  b = Convert.ToDouble(y);
            
            return b;
        }

        static double Calculate(double aArg, double bArg, string operArg)
        {
            int oper;
            double result = 0;
            if (operArg == "+") { oper = 1; } else if (operArg == "-") { oper = 2; } else if (operArg == "/") { oper = 3; } 
            else if (operArg == "*") { oper = 4; } else if (operArg == "%") { oper = 5; } else if (operArg == "pow") { oper = 6; }
            else { oper = 0; Console.WriteLine("You had to input one of those operations (+ - / * % pow)!"); }

            switch(oper)
            {                
                case (1):
                    {
                        result = Addition(aArg, bArg);
                    }break;

                case (2):
                    {
                        result = Subtraction(aArg, bArg);
                    } break;

                case (3):
                    {
                        result = Division(aArg, bArg);
                    } break;

                case (4):
                    {
                        result = Multiplication(aArg, bArg);
                    } break;

                case (5):
                    {
                        result = Mod(aArg, bArg);
                    } break;

                case (6):
                    {
                        result = Pow(aArg, bArg);
                    } break;

            }
            if (result == double.PositiveInfinity)
            {
                Console.WriteLine("Error");
                result = 0;
            }
            return result;
        }

        static double Addition(double xArg, double yArg)
        {
            double result = xArg + yArg;

            return result;
        }

        static double Subtraction(double xArg, double yArg)
        {
            double result = xArg - yArg;

            return result;
        }

        static double Division(double xArg, double yArg)
        {
            if (yArg == 0)
            {
                Console.WriteLine("Forbidden operation");
            }

            double result = xArg / yArg;

            return result;
        }

        static double Multiplication(double xArg, double yArg)
        {
            double result = xArg * yArg;

            return result;
        }

        static double Mod(double xArg, double yArg)
        {
            double result = xArg % yArg;

            return result;
        }

        static double Pow(double xArg, double yArg)
            {
                double result = Math.Pow(xArg, yArg);

                return result;
            }
     }
}
