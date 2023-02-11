namespace VendingMachine
{
    internal interface IProduct
    {
        double ProductPrice { get; set; }

        int ConvertToValidInput(string input);
        bool IsProductValid(int productValue);
        void SelectProduct();
    }
}