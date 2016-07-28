using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ScoutBoy:Scout
    {
        private string str { get; set; }

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
    /*class BaseClass
    {
        public int value;

        public BaseClass()
        {
            Console.WriteLine("base");
        }

        public BaseClass(int valueArg)
        {
            value = valueArg;
            Console.WriteLine("aljfaksjdf");
        }
    }

    sealed class DerivedClass:BaseClass//sealed - не имеет наследников
    {
        public string str;

        public DerivedClass(int valueArg, string strArg)
            :base(valueArg)// вызовет конструктор не по умолчанию, а п
        {
            str = strArg;
        }

        public void Method()
        {
            Console.WriteLine("{0}{1}", base.value, this.str);
        }
    }*/
}
