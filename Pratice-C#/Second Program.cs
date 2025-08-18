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

//  First Exercise:  String interpolation

// Declare Variable
 
 string name;
name = "Roberto";
string sport;
sport = "Soccer";

// Show messages with interpolation.

Console.WriteLine($"Hi {name}, your favorite sport is {sport}"); 

// Second Exercise: Numeric formatting 
 
// declare Variable

 decimal number = 1234.56789m;

// Show currency and 2 decimals 

Console.WriteLine("as currency:  " + number.ToString("C"));
Console.WriteLine("With 2 decimals:  " + number.ToString("F2"); 


