public class Program
{
    public static void Main()
    {
        ShowMenu();
    }

    public static void ShowMenu()
    {
        try
        {
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. Say Hello World");
            Console.WriteLine("2. Add Two Numbers");
            Console.WriteLine("3. Exit");
            Console.Write("Pick an option (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SayHello();
                    break;

                case "2":
                    AddNumbers();
                    break;

                case "3":
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void SayHello()
    {
        Console.WriteLine("\nHello, World!");
    }

    public static void AddNumbers()
    {
        try
        {
            Console.Write("\nPlease enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int result = firstNum + secondNum;
            Console.WriteLine($"{firstNum} + {secondNum} = {result}");
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
    }
}