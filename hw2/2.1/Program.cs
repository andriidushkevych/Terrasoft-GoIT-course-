using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 1234567890;
            string strNum = Convert.ToString(num);

            Console.WriteLine(strNum);//to check wtf is in this string. its ok

           

            Console.WriteLine(" ");

                for (int i = 0; i < strNum.Length; i++)
                {
                    if (strNum[i] % 2 != 0)
                    {
                        int a = (int)Char.GetNumericValue(strNum[i]);
                        a = (a + 1) % 10;
                        Console.Write("{0} ", a);
                    }
                    else Console.Write("{0} ", strNum[i]);
                }

            Console.ReadKey();
        }
    }
}
