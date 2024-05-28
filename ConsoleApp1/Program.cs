using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SwitchStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-7) to get the corresponding day of the week:");
            int dayNumber;
            if (int.TryParse(Console.ReadLine(), out dayNumber))
            {
                string dayName = GetDayName(dayNumber);
                if (!string.IsNullOrEmpty(dayName))
                {
                    Console.WriteLine($"The day number {dayNumber} corresponds to {dayName}.");
                }
                else
                {
                    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 1 and 7.");
            }
        }

        static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return null;
            }
        }
    }
}
