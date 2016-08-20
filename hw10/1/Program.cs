using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public delegate void OperationEvent();

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hi, input first number please");
            int a;
            bool checkA = int.TryParse(Console.ReadLine(), out a);
            if (checkA) Calculator.A = a;

            Console.WriteLine("Now input second number please");
            int b;
            bool checkB = int.TryParse(Console.ReadLine(), out b);
            if (checkB) Calculator.B = b;

            Console.WriteLine("Choose sequence of operations to execute with your numbers(like 1142132): \n1. Add \n2. Substract \n3. Multiply \n4. Divide ");
            string answ = Console.ReadLine();

            DoOperations(answ);            
            
            Console.ReadKey();

        }

        static void DoOperations(string answArg)
        {
            Button button = new Button();

            switch(answArg) 
            {
                case ("1"):
                    {
                        button.calcutate += Calculator.Addition();
                        break;
                    }
                case ("2"):
                    {
                        button.calcutate += Calculator.Substraction();
                        break;
                    }
                case ("3"):
                    {
                        button.calcutate += Calculator.Multiplication();
                        break;
                    }
                case ("4"):
                    {
                        button.calcutate += Calculator.Division();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong operation");
                        break;
                    }
                
               
            }
        }

        
    }

    


    
}
