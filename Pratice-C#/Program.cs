
/* Topic 1: Store and Retrieve Data Using Literal and Variable Values in C#

Product information
Create variables for a product: name, price, and quantity. Print all the information in one line.

Rectangle area
Store the width and height of a rectangle in variables. Calculate the area and print it.

Personal info
Create variables with your name, age, and country. Print them in a single sentence. */

// First Exercise: Product information

// Declare Variable

 string name;
name = "Roberto";
double precio; 
precio = 24.99;
int cantidad;
   cantidad = 12;

// Show messages with interpolation in String

Console.WriteLine($"El producto de {name} cuesta {precio}$ y solo quedan disponibles {cantidad}"); 

// Second Exercise: Rectangle area
 
// Declare Variable

 double width;
width = 7;
double height;
height = 5;

// Calculations Area

double area = width *  height;

Console.WriteLine(area); 

// Third Exercise: Personal Information 

// Declare Variable

string name = "Roberto";
int years = 18;
string country = "DR";

// Show Messages with interpolation

Console.WriteLine($"Hi i'm {name}, i'm {years} years old and i live in {country}"); 

// Store and Retrieve Data Using Literal and Variable Values in C# Success Completed...

