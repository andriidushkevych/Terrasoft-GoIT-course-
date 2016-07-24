using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityOrdered { get; set; }

        

        public static Goods CreateGoods(int idArg, string nameArg, decimal priceArg)
        {
            Goods newGoods = new Goods();
            newGoods.Id = idArg;
            newGoods.Name = nameArg;
            newGoods.Price = priceArg;
            newGoods.QuantityOrdered = 0;

            return newGoods;
        }
    }
}
