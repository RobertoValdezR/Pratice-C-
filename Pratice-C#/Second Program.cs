/* Topic 2: Perform Basic String Formatting in C#

String interpolation
Ask the user for their name and their favorite sport. Display:
Hello [Name], your favorite sport is [Sport].

Numeric formatting
Declare a variable with a decimal number (e.g., 1234.5678). Show the number as currency and with 2 decimals.

Aligned text
Display a small table in console using string formatting:Topic 2: Perform Basic String Formatting in C#

String interpolation
Ask the user for their name and their favorite sport. Display:
Hello [Name], your favorite sport is [Sport].

Numeric formatting
Declare a variable with a decimal number (e.g., 1234.5678). Show the number as currency and with 2 decimals.

Aligned text
Display a small table in console using string formatting */


 using System;

class SecondProgram
{
    static void Main()
    {
        //  First Exercise:  String interpolation

        // Declare Variable

        string name = "Roberto";
        string sport;
        sport = "Soccer";

        // Show messages with interpolation.

        Console.WriteLine($"Hi {name}, your favorite sport is {sport}");

        // Second Exercise: Numeric formatting 

        // declare Variable

        decimal number = 1234.56789m;

        // Show currency and 2 decimals 

        Console.WriteLine("as currency:  " + number.ToString("C"));
        Console.WriteLine("With 2 decimals:  " + number.ToString("F2")); 

        // Third Exercise: Aligned text

        // Declare Variable
    
        double price1 = 1.50;
        double price2 = 0.80;
        double price3 = 2.20;

        // Show the taable of product using the tabulation

        Console.WriteLine("Product\tPrice\n");
        Console.WriteLine("Apple\t" + price1);
        Console.WriteLine("Bread\t" + price2);
        Console.WriteLine("Milk\t" + price3);

        // Perform Basic String Formatting in C# Success Completed...




    }
}





