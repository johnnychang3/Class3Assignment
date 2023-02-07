using System.Globalization;
using System.Reflection.Metadata;

namespace Class3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateNow = DateTime.Now;

            Console.WriteLine($"{dateNow, 40:MMMM d, yyyy}");

            Console.WriteLine($"{dateNow:yyyy.MM.dd}");

            Console.WriteLine($"Day {dateNow:dd} of {dateNow:MMMM, yyyy}");

            Console.WriteLine($"Year: {dateNow:yyyy}, Month: {dateNow:MM}, Day: {dateNow:dd}");

            Console.WriteLine($"{dateNow.DayOfWeek, 10}");

            Console.WriteLine($"{dateNow, 10:t}{dateNow, 10:dddd}");

            Console.WriteLine($"h:{dateNow:hh}, m:{dateNow:mm}, s:{dateNow:ss}");

            Console.WriteLine($"{dateNow:yyyy}.{dateNow:MM}.{dateNow:dd}.{dateNow:hh}.{dateNow:mm}.{dateNow:ss}");

            var pi = Math.PI;

            Console.WriteLine($"{pi:C2}");

            Console.WriteLine($"{pi, 10:F3}");
        }
    }
}