internal class Program
{
    private static void Main(string[] args)
    {
        //Assignment Question 2: Take two numbers as input and print the sum of squares of those two numbers.

        Console.Write("Enter 1st Number: ");
        int? firstNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter 2nd Number: ");
        int? secondNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The square of sum of {firstNum} and {secondNum} is {(firstNum * firstNum) + (secondNum * secondNum)}");
    }
}