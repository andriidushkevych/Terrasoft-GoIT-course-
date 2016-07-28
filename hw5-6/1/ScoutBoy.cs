using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ScoutBoy:Scout
    {
        private string str;
        public bool footbal;
        public bool voleyball;
        public bool basketball;
        public bool tennis;
        public bool cycling;

        public ScoutBoy(string nameArg, string str="boy")
            :base(nameArg, str)
        {
            footbal = false;
            voleyball = false;
            basketball = false;
            tennis = false;
            cycling = false;
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
