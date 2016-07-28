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
            Camp camp = new Camp();

            ScoutBoy boy1 = new ScoutBoy();

            camp.AddScout(boy1);

            boy1.Name = "LG";
            Football sport1 = new Football();
            sport1.setTitle("foot");
            boy1.addSport(sport1);
            Fitness sport2 = new Fitness();
            sport2.setTitle("fit");
            boy1.addSport(sport2);

            ScoutGirl pizda = new ScoutGirl();

            camp.AddScout(pizda);

            pizda.Name = "LG";
            Football sport3 = new Football();
            sport3.setTitle("foot");
            pizda.addSport(sport2);
            Fitness sport4 = new Fitness();
            sport4.setTitle("fit");
            pizda.addSport(sport1);

            foreach (Scout scout in camp.getScouts())
            {
                foreach (Sport sport in scout.getSports())
                {
                    Console.WriteLine(sport.getTitle());
                }
            }

            Console.ReadKey();
            //ScoutBoy andrey = new ScoutBoy("Andrey");
            //Console.WriteLine(andrey.Name);
            //Console.WriteLine(andrey.Gender);
            //Realization.ShowMenu();
            //ScoutGirl dasha = new ScoutGirl("Dasha");
            //Console.WriteLine(dasha.Name);
            //Console.WriteLine(dasha.Gender);

            //Console.ReadKey();
        }
    }
}
