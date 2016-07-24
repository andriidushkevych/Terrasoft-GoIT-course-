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
            
            Realization.InputList();
            Realization.ShowGoods();
            Realization.ChooseGoods();
            Realization.CountTotal();

            Console.ReadKey();           
        }
    }
}

/*using System;
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
            Marker m1 = Marker.CreateMarker(3, "red");

            //m1.id = 1;
            //m1.name = "bic";
            //m1.color = "green";

           Marker.Name = "parker";

            m1.Show();
            Marker.StaticMethod();
            
            
            Console.ReadKey();

        }
    }

    class Marker
    {
        public readonly int field;
        public int Id { get; private set; }
        static public string Name { get; set; }
        public string Color { get; set; }

        private Marker(int idArg, string colorArg)
        {
            field = 10;
            Id = idArg;
            Color = colorArg;
        }

        public static Marker CreateMarker(int idArg, string colorArg)
        {
            Marker localMarker = new Marker(idArg, colorArg);
            localMarker.Id = idArg;
            localMarker.Color = colorArg;

            if (localMarker.Id < 0)
                return null;
            else
                return localMarker;
         }

        public void Show()
        {
            Console.WriteLine("id: {0,5}, name: {1,10}, color: {2,8}", Id, Name, Color);
            PrivateMethod();

        }

        private void PrivateMethod()
        {
            Console.WriteLine("PRIVATE!!!");
        }

        public static void StaticMethod() 
        {
            Console.WriteLine("static");
        }
    }
}
*/
