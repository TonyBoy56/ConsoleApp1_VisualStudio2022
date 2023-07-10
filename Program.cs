namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            int asciicode = Console.Read();
            Console.WriteLine(asciicode);
            Console.ReadKey();

            //string name = Console.ReadLine();
            //Console.WriteLine($"Dear {name}! Welcome to our lesson");
            //Console.ReadKey();
        }
    }
}