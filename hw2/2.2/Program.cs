﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a figure: \n 1. circle \n 2. sphere \n 3. rectangle \n 4. cuboid");

            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    {
                        Console.WriteLine("you have chosen to count the square of circle. input the radius: ");

                        string answ = Console.ReadLine();

                        int rad = Convert.ToInt32(answ);

                        double result = Math.PI * Math.Pow(rad, 2);
                        Console.WriteLine(" the square of circle: {0}", result);
                    }
                    break;

                case "2":
                   {
                        Console.WriteLine("you have chosen to count the volume of sphere. input the radius: ");

                        string answ = Console.ReadLine();

                        int rad = Convert.ToInt32(answ);

                        double result = (4 * Math.PI * Math.Pow(rad, 3)) / 3;
                        Console.WriteLine(" the volume of sphere: {0}", result);
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("you have chosen to count the square of rectangle. input the length of the first side: ");
                        string answ1 = Console.ReadLine();

                        Console.WriteLine("input the length of the second side: ");
                        string answ2 = Console.ReadLine();

                        int s1 = Convert.ToInt32(answ1);
                        int s2 = Convert.ToInt32(answ2);

                        float result = s1 * s2;
                        Console.WriteLine(" the square of rectangle: {0}", result);
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("you have chosen to count the volume of cuboid. input the length of the first side: ");
                        string answ1 = Console.ReadLine();

                        Console.WriteLine("input the length of the second side: ");
                        string answ2 = Console.ReadLine();

                        Console.WriteLine("input the length of the third side: ");
                        string answ3 = Console.ReadLine();

                        int s1 = Convert.ToInt32(answ1);
                        int s2 = Convert.ToInt32(answ2);
                        int s3 = Convert.ToInt32(answ3);

                        float result = s1 * s2 * s3;
                        Console.WriteLine(" the volume of cuboid: {0}", result);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("error");
                    }
                    break;
            }

            


            Console.ReadKey();
        }
    }
}
