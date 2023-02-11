namespace VendingMachine
{
    internal interface IPrice
    {
        double CurrentAmt { get; set; }

        double ConvertToValidInput(string input);
        void DisplayAmount();
        bool IsCoinValid(double coin);
        void TakeCoins();
    }
}