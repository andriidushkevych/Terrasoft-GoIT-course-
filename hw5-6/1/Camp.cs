using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Camp
    {
        private static Scout[] scouts = new Scout[0];

        public static Scout[] getScouts()
        {
            return scouts;
        }

         static public void AddScout(Scout newScout)
        {
            Scout[] newScouts = new Scout[scouts.Length + 1];
            for (int i = 0; i < scouts.Length; i++ )
            {
                newScouts[i] = scouts[i];
            }
            newScouts[scouts.Length] = newScout;
            scouts = newScouts;
        }

        public void addSportToScout(string scoutName, Sport sport)
        {
            foreach (Scout scout in scouts)
            {
                if (scout.Name.Equals(scoutName))
                {
                    scout.addSport(sport);
                }
            }
        }

        public static void ShowScoutList()
        {
            for (int i = 0; i < scouts.Length; i++ )
            {
                Console.WriteLine((i+1) + " " + scouts[i].Name);
            }
        }

        public static void ShowScoutBoyList()
        {
            for (int i = 0; i < scouts.Length; i++)
            {                
                if(scouts[i] is ScoutBoy)
                {
                    Console.WriteLine(scouts[i].Name);                    
                }
            }
        }

        public static void ShowScoutGirlList()
        {
            for (int i = 0; i < scouts.Length; i++)
            {                
                if (scouts[i] is ScoutGirl)
                {
                    Console.WriteLine(scouts[i].Name);
                    
                }
            }
        }

        public static void ChooseScoutToAddSport()
        {
            ShowScoutList();
            Console.Write("Choose number of scout you would like to add sport to: ");
            int answ = int.Parse(Console.ReadLine());

            if (scouts[answ] is ScoutBoy)
            {
                Console.WriteLine("Choose sport: ");
                ShowBoySports();
            }
            else if (scouts[answ] is ScoutGirl)
            {
                Console.WriteLine("Choose sport: ");
                ShowGirlSports();
            }
            else Console.WriteLine("error");
        }

        
    }
}
