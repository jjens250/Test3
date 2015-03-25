using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How much does the item cost?");
            string strPrice;
            strPrice = Console.ReadLine();

            Console.WriteLine("What percentage off do you have?");
            String strPercentoff;
            strPercentoff = Console.ReadLine();

            double dblPrice;
            dblPrice = Convert.ToDouble(strPrice);  //This is the entered Price converted to decimals

            double dblPercent;
            dblPercent = Convert.ToDouble(strPercentoff);  //This is the percent off converted to decimals

            double dblPricePercent;
            double dblPriceTax;
            double dblMinusPercent;
            double dblFinalPrice;
            Double dblRealPricePercent;

            dblRealPricePercent = (dblPercent / 100);  //Turning the Percent to decimal.  Example 10 to .10


            dblPricePercent = (dblPrice * dblRealPricePercent);  //Price times percent off to get total amount off
            dblMinusPercent = (dblPrice - dblPricePercent);  //Price minus the percent off
            dblPriceTax = (dblMinusPercent * .06);  //Price multiplied by PA Tax to get total tax
            dblFinalPrice = (dblMinusPercent + dblPriceTax);    // Price minus the percent off plus Tax 

            Console.WriteLine("The total cost for your item with tax is {0}.", dblFinalPrice);


        }
    }
}
