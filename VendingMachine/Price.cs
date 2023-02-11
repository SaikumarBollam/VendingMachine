using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using VendingMachine.Helper;

namespace VendingMachine
{
    internal class Price : IPrice
    {
        /// <summary>
        /// It is the current total amount collected by machine.
        /// </summary>
        public double CurrentAmt { get; set; }

        /// <summary>
        /// Helps in collecting money from vending machine.
        /// </summary>
        public void TakeCoins()
        {
            DisplayAmount();
            double Input;
            do
            {
                Console.Write("PLEASE INSERT VALID COIN");
                Console.Write("(VALID COINS ARE (NICKELS(1/20$ or 0.05$), DIMES (1/10$ or 0.1$), AND\r\nQUARTERS(1/4$ or 0.25$))):");
                Input = ConvertToValidInput(Console.ReadLine());

            } while (!IsCoinValid(Input));
            CurrentAmt += Input;
        }

        /// <summary>
        /// This method helps validating coins and update the current amount 
        /// if valid coin is inserted.
        /// </summary>
        /// <param name="input">This parameter can fractions and decimals </param>
        /// <returns></returns>
        public double ConvertToValidInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"'{nameof(input)}' cannot be null or whitespace.", nameof(input));
            }

            if (Double.TryParse(input, out double result) && IsCoinValid(result))
            {
                return result;
            }
            Console.WriteLine("Invalid Input..");
            return 0;
        }

        /// <summary>
        /// It display's current amount in machine.
        /// </summary>
        public void DisplayAmount()
        {
            Console.WriteLine("TOTAL CURRENT AMOUNT IS : {0}", CurrentAmt);
        }

        public bool IsCoinValid(double coin)
        {
            switch (EnumMapper.MapCoinTypeDoubleToEnum(coin))
            {
                case CoinType.NICKELS:
                case CoinType.DIMES:
                case CoinType.QUARTERS:
                    return true;
                default:
                    return false;
            }

        }


    }
}
