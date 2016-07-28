using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ScoutBoy andrey = new ScoutBoy("Andrey");
            Console.WriteLine(andrey.Name);
            Console.WriteLine(andrey.Gender);
            Realization.ShowMenu();
            ScoutGirl dasha = new ScoutGirl("Dasha");
            Console.WriteLine(dasha.Name);
            Console.WriteLine(dasha.Gender);

            Console.ReadKey();
        }
    }
}
