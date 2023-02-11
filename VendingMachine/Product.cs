using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Helper;

namespace VendingMachine
{
    internal class Product : IProduct
    {
        public double ProductPrice { get; set; }


        public void SelectProduct()
        {
            int input;
            do
            {
                Console.WriteLine("SELECT PRODUCT FROM LIST:");
                foreach (ProductType productType in Enum.GetValues(typeof(ProductType)))
                {
                    Console.WriteLine($"PRESS {(int)productType} FOR {productType} (${EnumMapper.MapProductTypeEnumToDouble(productType)})");
                }
                input = ConvertToValidInput(Console.ReadLine());
            }
            while (!IsProductValid(input));
            ProductPrice = EnumMapper.MapProductTypeEnumToDouble((ProductType)input);
        }

        public int ConvertToValidInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"'{nameof(input)}' cannot be null or whitespace.", nameof(input));
            }

            if (int.TryParse(input, out int result) && IsProductValid(result))
            {
                return result;
            }
            Console.WriteLine("Invalid Input..");
            return 0;
        }

        public void DisplayProductPrice()
        {
            Console.WriteLine("THE FOLLOWING PRICE IS NEED FOR PURCHASING PRODUCT : ${0}",ProductPrice);
        }

        public bool IsProductValid(int productValue)
        {
            switch (productValue)
            {
                case (int)ProductType.COLA:
                case (int)ProductType.CHIPS:
                case (int)ProductType.CANDY:
                    return true;
                default:
                    return false;
            }

        }

    }
}
