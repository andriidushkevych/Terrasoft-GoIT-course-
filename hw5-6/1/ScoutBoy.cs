﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ScoutBoy:Scout
    {
        private string str { get; set; }

        public static void addScoutBoy(string nameArg){
                ScoutBoy sb = new ScoutBoy();
                sb.Name = nameArg;
                Camp.AddScout(sb);
        }

        public void addSport(Sport sport)
        {
            if (sport is SportBoys)
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
