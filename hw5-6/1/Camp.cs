using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Camp
    {
        private Scout[] scouts = new Scout[0];

        public Scout[] getScouts()
        {
            return scouts;
        }

        public void AddScout(Scout newScout)
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
    }
}
