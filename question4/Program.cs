internal class Program
{
    private static void Main(string[] args)
    {
        // Assignment Question 4: Declare string to store favourite color and print it.

        Console.Write("What's your favourite Color?: ");
        string? color = Console.ReadLine();

        Console.WriteLine($"Wow! {color} is a really pretty color!");
    }
}