using System;

class digits
{
    static void Main()
    {
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreDigits = 0;

        Console.Write("Insert a number: ");
        string userData = Console.ReadLine();

        while (userData != "end")
        {
            int number = Convert.ToInt32(userData);

            if (number != 0)
            {
                if (number / 10 == 0)
                    oneDigit++;
                else
                if (number / 100 == 0)
                    twoDigits++;
                else
                 if (number / 1000 == 0)
                    threeDigits++;
                else
                    moreDigits++;
            }
            userData = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits, threeDigits, moreDigits);
    
    }
}

