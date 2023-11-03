using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Assignment Question 3: Simple Calculator

        Console.WriteLine("Welcome to Calculator!");
        Console.WriteLine("symbol of operations: '+' -> add, '-' -> subtract, '*' -> multiply, '/' -> divide, '%' -> modulo");

        Console.Write("Enter 1st number: ");
        int? numOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter 2nd number: ");
        int? numTwo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Select operation: ");
        string? choice = Console.ReadLine();

        switch(choice)
        {
            case "+":
                Console.WriteLine($"Addition of {numOne} and {numTwo} is: {numOne + numTwo}");
                break;
            case "-":
                Console.WriteLine($"Subtraction of {numOne} and {numTwo} is: {numOne - numTwo}");
                break;
            case "*":
                Console.WriteLine($"Multiplication of {numOne} and {numTwo} is: {numOne * numTwo}");
                break;
            case "/":
                double decimalNumOne = Convert.ToDouble(numOne);
                double decimalNumTwo = Convert.ToDouble(numTwo);
                Console.WriteLine($"Division of {numOne} and {numTwo} is: {decimalNumOne / decimalNumTwo}");
                break;
            case "%":
                Console.WriteLine($"Modulo of {numOne} and {numTwo} is: {numOne % numTwo}"); //modulo cannot be in decimal point.
                break;
            default:
                Console.WriteLine("Invalid choice, please try again!");
                break;
        }
    }
}