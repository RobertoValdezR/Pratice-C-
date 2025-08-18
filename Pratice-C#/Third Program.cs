

/* Topic 3: Perform Basic Operations on Numbers in C#

Basic arithmetic
Ask the user for two numbers and display their sum, subtraction, multiplication, and division.

Temperature conversion
Ask the user for a temperature in Celsius and convert it to Fahrenheit using: F = (C * 9 / 5) + 32.

Circle area
Ask the user for the radius of a circle and calculate its area with the formula: π* r². */



class Third_Program
{
    static void Main()
    {
        // First Exercise: Basic arithmetic 

        // Declare Variable

        int num1 = 1;
        int num2 = 2;

        // Arimetic Operations
        Console.WriteLine(num1 + num2);
        Console.WriteLine(num1 - num2);
        Console.WriteLine(num1 * num2);
        Console.WriteLine(num1 / num2);

        // Second Exercise: Temperature Conversion

        // Declare Variable and do operation

        double user = 16;
        double Fahrenheit = (user * 9 / 5) + 32;

        // just Show

        Console.WriteLine(Fahrenheit);

        // Third Exercise: Circle Area

        // Declare Variable and do operation

        double radius = 3;
        double area = Math.PI * Math.Pow(radius, 2);

        // just Show

        Console.WriteLine($"The area of circle with radius {radius} is {area}");


        //Topic 3: Perform Basic Operations on Numbers in C# Success Completed...
    }

}

