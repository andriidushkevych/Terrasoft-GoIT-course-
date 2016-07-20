using System;
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

                        double rad = Convert.ToDouble(answ);

                        double result = Math.PI * Math.Pow(rad, 2);
                        Console.WriteLine(" the square of circle: {0}", result);
                    }
                    break;

                case "2":
                   {
                        Console.WriteLine("you have chosen to count the volume of sphere. input the radius: ");

                        string answ = Console.ReadLine();

                        double rad = Convert.ToDouble(answ);

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

                        double s1 = Convert.ToDouble(answ1);
                        double s2 = Convert.ToDouble(answ2);

                        double result = s1 * s2;
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

                        double s1 = Convert.ToDouble(answ1);
                        double s2 = Convert.ToDouble(answ2);
                        double s3 = Convert.ToDouble(answ3);
                        

                        double result = s1 * s2 * s3;
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
