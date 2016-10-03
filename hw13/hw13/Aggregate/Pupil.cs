using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw13.Iterator;

namespace hw13.Aggregate
{
    public class Pupil
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dictionary<string, int> SubjectsAndMarksList;

        public Pupil(string nameArg, int ageArg)
        {
            Name = nameArg;
            Age = ageArg;
            SubjectsAndMarksList = new Dictionary<string, int>();
        }

    }
}
