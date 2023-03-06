class FromOrdinalToCardinal
{
    //რიცხვების დაწერა რიგითობითი მნიშვნელობით
    static void Main(string[] args)
    {
        RunCardinalToOrdinal();

    }
    //ლოგიკური ოპერაცია, რომელიც რიცხვებისთვის დაბოლობებს არჩევს 
    static string CardinalToOrdinal (int number)
        {
        switch (number)
        {
            case 11:
            case 12:
            case 13:
                return number + "th";
            default:
                string numberAsText = number.ToString();
                char lastDigit = numberAsText[numberAsText.Length - 1];
                string suffix = string.Empty;
                /*ყველა დანარჩენი რიცხვის დასასრული თუ მათი ბოლო რიცხვია 1 ბოლოს მიუწეროს "st",2 ბოლოს მიუწეროს "nd",3 ბოლოს მიუწეროს "rd", 
                 * ხოლო ყველა დანარჩენს ბოლოს მიუწეროს "th", დააბრუნოს რიცხვითი მნიშვნელობა + დასასრული.
                 */
                switch (lastDigit)
                {
                    case '1':
                        suffix = "st";
                        break;
                    case '2':
                        suffix = "nd";
                        break;
                    case '3':
                        suffix = "rd";
                        break;
                    default:
                        suffix = "th";
                        break;
                }
                return number + suffix;
            }
        }
    //გამოიგანს იმდენ რიცხვით მნიშვნელობას რამდენსაც მიუთითებ
    static void RunCardinalToOrdinal()
    {
        for (int number = 1; number <= 30; number++)
        {
            Console.Write(CardinalToOrdinal(number));
            Console.WriteLine();
        }
    }
}
