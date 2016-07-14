using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] str = {'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd'};

            foreach (char letter in str)
            {
                int dec = Convert.ToInt32(letter);
                string hex = String.Format("{0:X}", dec);
                Console.WriteLine("Char {0}: dec {1} hex {2}", letter, dec, hex);
            }

            Console.ReadKey();
        }
    }
}
