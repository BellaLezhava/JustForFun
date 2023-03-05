﻿class TimesTableJustForMe
{
    static void Main(string[] args)
    {
        RunTimesTable();

    }
    static void TimesTable(byte number) //byte range = 0 to 255
    {
        Console.WriteLine("This is the " + number +" times table"); 
        for (int row = 1; row <= 12; row++)  // მიწოდებულ ციცხვს გაამრავლებს 1-დან 12-მდე
        {
            Console.WriteLine(row + " * " + number + " = " + (row * number));
        }
        Console.WriteLine();
    }
    static void RunTimesTable() 
    {
        bool isNumber; //ამოწმებს მომხმარებლის მიერ შეყვანილი რიცხვითი მნიშვნნელობა სწორია თუ არა
        do 
        {
            Console.Write("Enter a number between 0 and 255: ");
            isNumber = byte.TryParse(Console.ReadLine(), out byte number); // მომხმარებლის მიერ მიწოდებულ რიცხვს გადაიყვანს რიცხვით მნიშვნელობაში (0->255-მდე)
            if (isNumber) /*თუ მომხმარებლის მიწოდებული რიცხვი ჯდება მოცემულ რეინჯში (0-255-მდე) გამოთვლის TimesTable-ს კოდს სხვა შემთხვევაში გამოიტანს შეტყობინებას
                           * რომ მნიშვნებოდა ცდება მოცემულობას
                           * */
            {
                TimesTable(number);
            }
            else
            {
                Console.WriteLine("You didn't enter a valid number!");
            }
        }
        while (isNumber); //დათვლის იმდენჯერ რამდენჯერაც რიცხვით მნიშვნელობასაც შეიყვან
    }
   

}