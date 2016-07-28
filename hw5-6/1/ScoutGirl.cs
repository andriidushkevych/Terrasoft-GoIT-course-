using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ScoutGirl:Scout
    {
        private string str;
        public bool aerobics;
        public bool fitness;
        public bool yoga;
        public bool tableTennis;
        public bool dance;

        public ScoutGirl(string nameArg, string str="girl")
            :base(nameArg, str)
        {
            aerobics = false;
            fitness = false;
            yoga = false;
            tableTennis = false;
            dance = false;
        }
    }
}
