using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Calculator
    {
        public static int A { get; set; }
        public static int B { get; set; }

        //public Calculator(int aArg, int bArg)
        //{
        //    A = aArg;
        //    B = bArg;
        //}

        public static void Addition()
        {
            int result = A + B;
            Console.Write("A + B = {0}\n", result);
        }

        public static void Substraction()
        {
            int result = A - B;
            Console.Write("A - B = {0}\n", result);
        }

        public static void Multiplication()
        {
            int result = A * B;
            Console.Write("A * B = {0}\n", result);
        }

        public static void Division()
        {
            if (B != 0)
            { 
                float result = A / B;
                Console.Write("A / B = {0}\n", result);
            }
            else 
            { 
                Console.WriteLine("wrong second argument");
                return;
            }

        }
    }
}
