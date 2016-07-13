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
            
            char letter1 = 'h';
            int dec1 = Convert.ToInt32(letter1);
            string hex1 = String.Format("{0:X}", dec1);
            Console.WriteLine("Char {0}: dec {1} hex {2}", letter1, dec1, hex1);

            char letter2 = 'e';
            int dec2 = Convert.ToInt32(letter2);
            string hex2 = String.Format("{0:X}", dec2);
            Console.WriteLine("Char {0}: dec {1} hex {2}", letter2, dec2, hex2);

            char letter3 = 'l';
            int dec3 = Convert.ToInt32(letter3);
            string hex3 = String.Format("{0:X}", dec3);
            Console.WriteLine("Char {0}: dec {1} hex {2}", letter3, dec3, hex3);

            char l = 'l';
            int d = Convert.ToInt32(l);
            string h = String.Format("{0:X}", d);
            Console.WriteLine("Char {0}: dec {1} hex {2}", l, d, h);

            char letter4 = 'o';
            int dec4 = Convert.ToInt32(letter4);
            string hex4 = String.Format("{0:X}", dec4);
            Console.WriteLine("Char {0}: dec {1} hex {2}", letter4, dec4, hex4);

            char letter5 = 'w';
            int dec5 = Convert.ToInt32(letter5);
            string hex5 = String.Format("{0:X}", dec5);
            Console.WriteLine("Char {0}: dec {1} hex {2}", letter5, dec5, hex5);

            char a = 'o';
            int b = Convert.ToInt32(a);
            string c = String.Format("{0:X}", b);
            Console.WriteLine("Char {0}: dec {1} hex {2}", a, b, c);

            char letter6 = 'r';
            int dec6 = Convert.ToInt32(letter6);
            string hex6 = String.Format("{0:X}", dec6);
            Console.WriteLine("Char {0}: dec {1} hex {2}", letter6, dec6, hex6);

            char l1 = 'l';
            int d1 = Convert.ToInt32(l1);
            string h1 = String.Format("{0:X}", d1);
            Console.WriteLine("Char {0}: dec {1} hex {2}", l1, d1, h1);

            char letter7 = 'd';
            int dec7 = Convert.ToInt32(letter7);
            string hex7 = String.Format("{0:X}", dec7);
            Console.WriteLine("Char {0}: dec {1} hex {2}", letter7, dec7, hex7);

            Console.ReadKey();
        }
    }
}
