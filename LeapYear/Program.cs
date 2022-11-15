namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int count = 0;
            int currentLeapYear = 2020;
            Console.WriteLine($"The current leap year is {currentLeapYear}");

            while (count < 20)
            {
                Console.WriteLine($"The next leap year is {currentLeapYear += 4}");
                count++;    
            }
        }
    }
}