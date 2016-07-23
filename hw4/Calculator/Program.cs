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
            Console.WriteLine(" ");
            string first = Console.ReadLine();
            double a = Convert.ToDouble(first);

            while (true)
            {

                string oper = GetOperation();
                double b = GetAnotherDigit();

                double res = Calculate(a, b, oper);

                Console.WriteLine("result = {0}", res);
                Console.WriteLine(" ");

                a = res;

            }
        }

        static string GetOperation()
        {
            Console.WriteLine("Choose operation:\n 1: '+' \n 2: '-' \n 3: '/' \n 4: '*' \n 5: '%' \n 6: 'pow' \n");
            Console.WriteLine(" ");
            string res = Console.ReadLine();
            
            return res;
        }

        static double GetAnotherDigit()
        {
            Console.Write("Input another digit: ");
            Console.WriteLine(" ");
            string y = Console.ReadLine();
            double b = Convert.ToDouble(y);
            return b;
        }

        static double Calculate(double aArg, double bArg, string operArg)
        {
            int oper = Convert.ToInt32(operArg);
            double result = 0;
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
