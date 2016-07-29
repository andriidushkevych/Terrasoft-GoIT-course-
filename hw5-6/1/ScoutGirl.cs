using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ScoutGirl:Scout
    {
        private string name { get; set; }

        public static void addScoutGirl(string nameArg)
        {
            ScoutGirl sg = new ScoutGirl();
            sg.Name = nameArg;
            Camp.AddScout(sg);
        }

        public void addSport(Sport sport)
        {
            if (sport is SportGirl)
            {
                Sport[] newSports = new Sport[sports.Length + 1];
                for (int i = 0; i < sports.Length; i++)
                {
                    newSports[i] = sports[i];
                }
                newSports[sports.Length] = sport;
                sports = newSports;
            }
        }
    }
}
