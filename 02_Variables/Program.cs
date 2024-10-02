using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine("***** Price List *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Apple Unit Price:" + " " + applePrice + " " + "TL");
            Console.WriteLine("---- Orange Unit Price:" + " " + orangePrice + " " + "TL");
            Console.WriteLine("---- Strawberry Unit Price:" + " " + strawberryPrice + " " + "TL");
            Console.WriteLine("---- Potato Unit Price:" + " " + potatoPrice + " " + "TL");
            Console.WriteLine("---- Tomato Unit Price:" + " " + tomatoPrice + " " + "TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Item: Apple      - " + "Unit Price:" + " " + applePrice + " - Gr:" + " " + appleGram + " - TotalPrice:" + " " + appleTotalPrice);
            Console.WriteLine("Item: Orange     - " + "Unit Price:" + " " + orangePrice + " - Gr:" + " " + orangeGram + " - TotalPrice:" + " " + orangeTotalPrice);
            Console.WriteLine("Item: Strawberry - " + "Unit Price:" + " " + strawberryPrice + " - Gr:" + " " + strawberryGram + " - TotalPrice:" + " " + strawberryTotalPrice);
            Console.WriteLine("Item: Potato     - " + "Unit Price:" + " " + potatoPrice + " - Gr:" + " " + potatoGram + " - TotalPrice:" + " " + potatoTotalPrice);
            Console.WriteLine("Item: Tomato     - " + "Unit Price:" + " " + tomatoPrice + " - Gr:" + " " + tomatoGram + " - TotalPrice:" + " " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Total Shopping:" + " " + shoppingTotalPrice + " "+ "TL");
            #endregion

            Console.Read();

        }

    }
}
