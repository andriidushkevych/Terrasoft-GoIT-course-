using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 12;
            int z = 2;

//Рассчитать по формуле:
            //1)x++ = 6;
            //2)z++ = 3;
            //3)--y = 11;
            //4)--x = 5;
            //5)x++ - --y + --x = -1; далее мы -1 сдвигаем влево на z++ = 3 позиции; 
            //6)x++ - --y + --x << z++ = -4;
            //7)x + y + z = 19;
            //8)(x++ - --y + --x << z++)*(x + y + z) = -4 * 19 = -76;
           
            int result = (x++ - --y + --x << z++)*(x + y + z);


            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
