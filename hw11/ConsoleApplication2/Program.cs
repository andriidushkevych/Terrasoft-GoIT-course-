using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        delegate void myDelegate(int answArg);
        static void Main(string[] args)
        {
            Console.WriteLine("Input something (number or string):");
            string str = Console.ReadLine();

            double num = 0;
            bool checkNum = double.TryParse(str, out num);

            if (checkNum)
                num = Math.Pow(num, 2);

            Console.WriteLine("");
            Console.WriteLine("Where to output your info? \nInput 1 to see result in console(default) or 2 to see it in text file.");

            int answ = 1;
            bool checkAnsw = int.TryParse(Console.ReadLine(), out answ);

            if (checkAnsw)
            {
                Output(() =>
                {
                    if (answ == 1)
                    {
                        Console.WriteLine("str");
                    }
                    else if (answ == 2)
                    { Console.WriteLine("added to file"); }
                    else { Console.WriteLine("error"); }
                });
            }

            Console.ReadKey();


        }

        private void Output(myDelegate lambdaParam) { }

        //if (checkAnsw) 
        //{ 
        //    if (answ == 1 && checkNum)
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("Result: {0}", num);
        //    }
        //    else if (answ == 1)
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("Result: {0}", str);
        //    }else if (answ == 2 && checkNum)
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("Result: {0}", num);
        //    }
        //    else if (answ == 2)
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("Result: {0}", str);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Error");
        //}







       

            }
        }
    
}
