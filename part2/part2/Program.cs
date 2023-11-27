using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{

    class Program
    {
        // Generic delegate
        public delegate T Operation<T>(T x, T y);

        // Generic static methods
        public static T Add<T>(T x, T y) => (dynamic)x + y;
        public static T Subtract<T>(T x, T y) => (dynamic)x - y;
        public static T Multiply<T>(T x, T y) => (dynamic)x * y;
        public static T Divide<T>(T x, T y) => (dynamic)x / y;

        static void Main()
        {
            // Create instances of Operation<T> delegate for each operation
            Operation<int> addDelegate = Add;
            Operation<int> subtractDelegate = Subtract;
            Operation<int> multiplyDelegate = Multiply;
            Operation<int> divideDelegate = Divide;

            // Ask the user to input two values of the same data type
            Console.Write("Enter the first value: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to choose an operation
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Get user's choice
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Perform the selected operation and display the result
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition result: {addDelegate(value1, value2)}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction result: {subtractDelegate(value1, value2)}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication result: {multiplyDelegate(value1, value2)}");
                    break;
                case 4:
                    // Handle division by zero separately
                    if (value2 != 0)
                    {
                        Console.WriteLine($"Division result: {divideDelegate(value1, value2)}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}