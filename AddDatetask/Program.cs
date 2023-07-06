using System;
using System.Threading.Channels;

namespace AddDatetask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input date (dd/MM/yyyy): " );
            string dateTime = Console.ReadLine();

            if (DateTime.TryParseExact(dateTime, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                DateTime newDate = date.AddDays(30).AddHours(6).AddMinutes(17);
                Console.WriteLine("New Date: " + newDate.ToString("dd/MM/yyyy HH:mm"));
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
