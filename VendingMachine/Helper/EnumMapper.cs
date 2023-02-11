using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Helper
{
    public static class EnumMapper
    {
        public static double MapCoinTypeEnumToDouble(CoinType coinType)
        {
            return coinType switch
            {
                CoinType.NICKELS => 0.05,
                CoinType.QUARTERS => 0.1,
                CoinType.DIMES => 0.25,
                _ => 0.00,
            };
        }
        public static CoinType MapCoinTypeDoubleToEnum(double coin)
        {
            return coin switch
            {
                0.05 => CoinType.NICKELS,
                0.10 => CoinType.QUARTERS,
                0.25 => CoinType.DIMES,
                _ => 0.00,
            };
        }

        public static double MapProductTypeEnumToDouble(ProductType productType)
        {
            return productType switch
            {
                ProductType.COLA => 1.00,
                ProductType.CHIPS => 0.50,
                ProductType.CANDY => 0.65,
                _ => 0.00,
            };
        }
        public static ProductType MapProductTypeDoubleToEnum(double productValue)
        {
            return productValue switch
            {
                1.00 => ProductType.COLA,
                0.50 => ProductType.CHIPS,
                0.65 => ProductType.CANDY,
                _ => 0.00,
            };
        }
    }
}
