using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Realization
    {
        private static Goods[] gArr = new Goods[5];

        //Creating list of products
        public static void InputList()
        {        
            Console.WriteLine("You are going to create a list of availiable products.");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Input name of product: ");
                string nameInp = Console.ReadLine();

                Console.Write("Input price/piece of {0}: ", nameInp);
                decimal priceInp = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine(" \n");

                gArr[i] = Goods.CreateGoods((i+1), nameInp, priceInp);
            }

            
        }

        //Showing list of goods
        public static void ShowGoods()
        {
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < gArr.Length; i++)
            {
                Console.WriteLine("id: {0}, name: {1}, price: {2}", gArr[i].Id, gArr[i].Name, gArr[i].Price);
            }
            Console.WriteLine("Press '0' when you are done and you want to count total price.");
        }

        //Loop of choosing the goods
        public static void ChooseGoods()
        {
            Console.WriteLine("--------------------------------------");
            bool checker = true;
            while (checker == true)
            {
                Console.Write("Choose product: ");
                int goodsNum = Convert.ToInt32(Console.ReadLine());

                if (goodsNum == 0)
                {
                    checker = false;
                    break;
                }

                Console.Write("Input quantity of {0}: ", goodsNum);
                int goodsQuan = Convert.ToInt32(Console.ReadLine());

                if (goodsQuan == 0)
                {
                    checker = false;
                    break;
                }

                Console.WriteLine(" \n");

                gArr[goodsNum-1].QuantityOrdered += goodsQuan;
            }
        }

        //count total price for chosen products
        public static void CountTotal()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("---------------TOTAL!!!---------------\n");
            for (int i = 0; i < gArr.Length; i++)
            {
                if (gArr[i].QuantityOrdered != 0)
                {
                    decimal total = 0;
                    total = gArr[i].QuantityOrdered * gArr[i].Price;
                    Console.WriteLine("Total price of {0}x{1} = $ {2}", gArr[i].Name, gArr[i].QuantityOrdered , total);
                }
            }
            AskForDiscount();
           
        }

        //ask for discount
        private static void AskForDiscount()
        {
            Console.WriteLine("Do you have our 10% discount card? (y/n)");
            string answer = Console.ReadLine();
            bool answ = false;
            if (answer == "y") { answ = true; }

            if (answ)
            {
                TotalWithDiscount();
            }
            else
            {
                Console.WriteLine("----------------------Thanks for shopping!----------------------");
            }
        }

        //count total with discount
        private static void TotalWithDiscount()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------------TOTAL WIH DISCOUNT!!!------------\n");
            for (int i = 0; i < gArr.Length; i++)
            {
                if (gArr[i].QuantityOrdered != 0)
                {
                    decimal total = 0;
                    total = (gArr[i].QuantityOrdered * gArr[i].Price) - (gArr[i].QuantityOrdered * gArr[i].Price * 0.1m );
                    Console.WriteLine("Total price of {0}x{1} = $ {2}", gArr[i].Name, gArr[i].QuantityOrdered, total);
                }
            }
        }
    
    }
}
