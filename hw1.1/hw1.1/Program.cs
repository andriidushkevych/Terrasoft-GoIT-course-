using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type byte: default value 0, min 0, max 255

            string forByte = String.Format("Type byte: default value {0}, min {1}, max {2}", default(byte), Byte.MinValue, Byte.MaxValue);
            string forSbyte = String.Format("Type sbyte: default value {0}, min {1}, max {2}", default(sbyte), SByte.MinValue, SByte.MaxValue);
            string forShort = String.Format("Type short: default value {0}, min {1}, max {2}", default(short), short.MinValue, short.MaxValue);
            string forUshort = String.Format("Type ushort: default value {0}, min {1}, max {2}", default(ushort), ushort.MinValue, ushort.MaxValue);
            string forInt = String.Format("Type int: default value {0}, min {1}, max {2}", default(int), int.MinValue, int.MaxValue);
            string forUint = String.Format("Type uint: default value {0}, min {1}, max {2}", default(uint), uint.MinValue, uint.MaxValue);
            string forLong = String.Format("Type long: default value {0}, min {1}, max {2}", default(long), long.MinValue, long.MaxValue);
            string forUlong = String.Format("Type ulong: default value {0}, min {1}, max {2}", default(ulong), ulong.MinValue, ulong.MaxValue);
            string forFloat = String.Format("Type float: default value {0}, min {1}, max {2}", default(float), float.MinValue, float.MaxValue);
            string forDouble = String.Format("Type double: default value {0}, min {1}, max {2}", default(double), double.MinValue, double.MaxValue);
            string forDecimal = String.Format("Type decimal: default value {0}, min {1}, max {2}", default(decimal), decimal.MinValue, decimal.MaxValue);

            string forBool = String.Format("Type bool: default value {0}", default(bool));
            string forChar = String.Format("Type char: default value {0}", default(char));


            Console.WriteLine(forByte);
            Console.WriteLine(forSbyte);
            Console.WriteLine(forShort);
            Console.WriteLine(forUshort);
            Console.WriteLine(forInt);
            Console.WriteLine(forUint);
            Console.WriteLine(forLong);
            Console.WriteLine(forUlong);
            Console.WriteLine(forFloat);
            Console.WriteLine(forDouble);
            Console.WriteLine(forDecimal);
            Console.WriteLine(forBool);
            Console.WriteLine(forChar);

            Console.ReadKey();
        }
    }
}
