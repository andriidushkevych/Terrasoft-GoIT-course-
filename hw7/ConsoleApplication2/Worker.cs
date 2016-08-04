using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Worker
    {
        public string Name { get; set; }
        public float Experience { get; set; }
        public float HoursWorked { get; set; }
        public float HourlyWage { get; set; }
        public float BonusMultiplier { get; set; }

        
    }
}
