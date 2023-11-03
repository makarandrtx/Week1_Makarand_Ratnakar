internal class Program
{
    private static void Main(string[] args)
    {
        //Assignment Question 1: Take user's name as input & display a greeting message with their name.

        Console.Write("Please enter your name: ");

        string? userName = Console.ReadLine(); // warning about CS8600 

        Console.WriteLine($"Welcome {userName}! Glad to have you onboard!");
    }
}