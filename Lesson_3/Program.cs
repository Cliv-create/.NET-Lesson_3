namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Please, input steps amount: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"User input: {user_input}");
            Console.Write("Please, input desired charachter to draw stairs: ");
            char charachter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"User input: {charachter}");

            for (int i = 0; i < user_input; i++) // Number of steps
            {
                for (int x = 0; x < i; x++) // Draw spacing before drawing next step
                {
                    Console.Write("   ");
                }

                Console.WriteLine($"{charachter}"); // *

                for (int x = 0; x < i; x++) // Draw spacing before drawing next step
                {
                    Console.Write("   ");
                }

                Console.WriteLine($"{charachter}{charachter}{charachter}"); // ***
            }
        }
    }
}
