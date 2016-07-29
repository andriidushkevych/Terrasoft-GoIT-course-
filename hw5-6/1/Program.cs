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


            ShowMenu();


            ScoutBoy boy1 = new ScoutBoy();

            

            boy1.Name = "LG";
            Football sport1 = new Football();
            sport1.setTitle("foot");
            boy1.addSport(sport1);
            Fitness sport2 = new Fitness();
            sport2.setTitle("fit");
            boy1.addSport(sport2);

            ScoutGirl pizda = new ScoutGirl();

            

            pizda.Name = "LG";
            Football sport3 = new Football();
            sport3.setTitle("foot");
            pizda.addSport(sport2);
            Fitness sport4 = new Fitness();
            sport4.setTitle("fit");
            pizda.addSport(sport1);

            foreach (Scout scout in Camp.getScouts())
            {
                foreach (Sport sport in scout.getSports())
                {
                    Console.WriteLine(sport.getTitle());
                }
            }

            Console.ReadKey();
           
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Add new scout.\n2. Add sport for scout.\n3. Delete scout's sport.\n4. Show scoutlist.\n5. Show boys.\n6. Show girls.\n7. Calculations.\n0. Exit");
            int answ = int.Parse(Console.ReadLine());
            Switcher(answ);
        }

        static void Switcher(int answ)
        {
            
            switch (answ)
            {
                case (1):
                    {
                        ScoutAdder();
                        ConsoleOper();
                        break;
                    }
                case (2):
                    {
                        Camp.ChooseScoutToAddSport();
                        ConsoleOper();
                        break;
                    }
                case (4):
                    {
                        Camp.ShowScoutList();
                        ConsoleOper();
                        break;
                    }
                case (5):
                    {
                        Camp.ShowScoutBoyList();
                        ConsoleOper();
                        break;
                    }
                case (6):
                    {
                        Camp.ShowScoutGirlList();
                        ConsoleOper();
                        break;
                    }
            }
        }

        static void ConsoleOper()
        {
            Console.WriteLine("press any key to return to main menu");
            Console.ReadKey();
            Console.Clear();
            ShowMenu();
        }

        static void ScoutAdder()
        {
            Console.Write("Choose scout's gender: 1 - boy. 2 - girl.");
            int gender = int.Parse(Console.ReadLine());
            Console.Write("Input the name of new scout: ");
            string name = Console.ReadLine();
            if (gender == 1)
            {
                ScoutBoy.addScoutBoy(name); 
            }
            else if (gender == 2)
            {
                ScoutGirl.addScoutGirl(name);                 
            }
            else Console.WriteLine("wrong choise");
        }

        

    }
}
