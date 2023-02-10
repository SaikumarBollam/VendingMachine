using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    internal class CollectCoins
    {
       private double CurrentAmt { get; set; } 
       
       public void TakeCoins()
       {
            Console.WriteLine("Please insert valid coin : ");
            double Input = Console.Read();
            if (IsCoinValid(Input))
            {

            }
       }

        public void DisplayAmount()
        {
            Console.WriteLine("Current Amount is : {0}",CurrentAmt);
        }

        public bool IsCoinValid(double coin)
        {
            return true;
        }
    }
}
