class ExchangeRate
{
    static void Main(string[] args)
    {
        RunCalculateCurrency();
    }
    static decimal CalculateNbgRate(decimal amount, string threeLetterRegionCode)
    {
        decimal rate = 0.00M;
        switch (threeLetterRegionCode)
        {
            case "USD": //US Dollar
                rate = 2.6064M;
                break;
            case "EUR": //Europian Union
                rate = 2.7680M;
                break;
        }
        return amount * rate;
    }
    static void RunCalculateCurrency()
    {
        Console.Write("Enter an amount you want to exchange: ");
        string amountForExchange = Console.ReadLine();
        Console.Write("Enter a three-letter region code: ");
        string region = Console.ReadLine();
        if (decimal.TryParse(amountForExchange, out decimal amount))
        {
            decimal amountInGel = CalculateNbgRate(amount, region);
            Console.WriteLine("You have " + amountInGel + " in GEL");
        }
        else
        {
            Console.WriteLine("We don't exchange in this currency!");
        }
    }

}