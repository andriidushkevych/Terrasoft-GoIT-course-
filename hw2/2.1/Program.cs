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
            int[] arr = new int[10];
            string strNum = Convert.ToString(num);

            Console.WriteLine(strNum);//to check wtf is in this string. its ok

            for (int i = 0; i < strNum.Length; i++)
            {
                arr[i] = Convert.ToInt32(strNum[i]);//something is going wrong here, cant understand what exactly.
                Console.Write(arr[i] + " ");// why string "1234567890" being char by char written to int array, appears as "49 50 51 52 53 54 55 56 57 48???????????????????"
            }

            Console.WriteLine(" ");

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        arr[i] = (arr[i] + 1) % 10;
                    }
                    Console.Write("{0} ", arr[i]);
                }

            Console.ReadKey();
        }
    }
}
