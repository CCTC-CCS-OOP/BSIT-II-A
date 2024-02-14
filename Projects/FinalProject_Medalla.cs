using System;
namespace ProjectAlvinMedalla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 1.
            Console.WriteLine("Module 1.");
            Console.WriteLine("Main pogi Alvin");
            int x = 5, y = 10;
            string creator = "Alvin Medalla";
            double z = 2.2;
            char e = 'e';
            bool isTrue = true;
            Console.WriteLine(x + y);
            Console.WriteLine(e + "\n" + z + "\n" + isTrue + "\n" + x + "\n" + y + "\n");
            // Arithmetic operators
            int a = 10;
            int b = 5;

            int sum = a + b;
            Console.WriteLine($"Sum: {sum}");

            int difference = a - b;
            Console.WriteLine($"Difference: {difference}");

            int product = a * b;
            Console.WriteLine($"Product: {product}");

            int quotient = a / b;
            Console.WriteLine($"Quotient: {quotient}");

            int remainder = a % b;
            Console.WriteLine($"Remainder: {remainder}");

            // Increment and Decrement
            int v = 5;
            x++;
            Console.WriteLine($"Incremented x: {x}");

            int m = 8;
            y--;
            Console.WriteLine($"Decremented y: {y}");

            // String operations
            string firstName = "Alvin";
            string lastName = "Medalla";

            // Concatenation
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Full Name: {fullName}");

            // String interpolation
            Console.WriteLine($"Hello, {firstName}!");

            // String Length
            int nameLength = fullName.Length;
            Console.WriteLine($"Length of Full Name: {nameLength}");

            //Module 3
            Console.WriteLine("Module 3.");
            Console.WriteLine("Enter your age:");

            // Read user input as a string
            string userInput = Console.ReadLine();

            // Parse the input to an integer
            if (int.TryParse(userInput, out int age))
            {
                // Decision-making based on age
                if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior citizen.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");

            }
        }
    }
}
