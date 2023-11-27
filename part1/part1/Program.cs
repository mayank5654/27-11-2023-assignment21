using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1

// Step 1: Create a delegate named ArithmeticOperation
{ delegate int ArithmeticOperation(int a, int b);

class Program
{
    // Step 2: Implement four static methods for arithmetic operations
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        // Check for division by zero
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }

    static void Main()
    {
        // Step 3: Create instances of the ArithmeticOperation delegate
        ArithmeticOperation addDelegate = new ArithmeticOperation(Add);
        ArithmeticOperation subtractDelegate = new ArithmeticOperation(Subtract);
        ArithmeticOperation multiplyDelegate = new ArithmeticOperation(Multiply);
        ArithmeticOperation divideDelegate = new ArithmeticOperation(Divide);

        // Step 4: Ask the user to input two integers
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Step 5: Prompt the user to choose an arithmetic operation
        Console.WriteLine("Choose an arithmetic operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Step 6: Call the corresponding method through the delegate and display the result
        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result of Addition: {addDelegate(num1, num2)}");
                break;
            case 2:
                Console.WriteLine($"Result of Subtraction: {subtractDelegate(num1, num2)}");
                break;
            case 3:
                Console.WriteLine($"Result of Multiplication: {multiplyDelegate(num1, num2)}");
                break;
            case 4:
                Console.WriteLine($"Result of Division: {divideDelegate(num1, num2)}");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
}