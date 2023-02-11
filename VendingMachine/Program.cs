using Microsoft.Extensions.Hosting;
using System;
using VendingMachine.Helper;

namespace VendingMachine
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product= new Product();
            Price price= new Price();
            Console.WriteLine("............VENDING MACHINE...............");
            Console.WriteLine("............................................................");
            product.SelectProduct();
            do
            {
                price.TakeCoins();

            } while (product.ProductPrice > price.CurrentAmt && ((Func<double, bool>)(y =>
            {
                Console.WriteLine("NEED TO MORE MONEY TO PURCHASE ITEM");
                product.DisplayProductPrice();
                return true;
            }))(0));
            Console.WriteLine("ITEM DISPATCHED");
            Console.WriteLine("THANK YOU FOR SHOPPING");
        }
    }
}
