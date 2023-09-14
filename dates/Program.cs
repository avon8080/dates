using System.IO;

namespace Ticket_master
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"{today,40 :MMMM, dd, yyyy}");
            Console.WriteLine($"{today:yyyy.MM.dd}");
            Console.WriteLine($"Day{today: dd} of {today:MMMM, yyyy}");
            Console.WriteLine($"Year:{today: yyyy}, Month:{today: MM}, Day:{today: dd}");
            Console.WriteLine($"{today,10: dddd}");
            Console.WriteLine($"{today, 10: hh:mm}{today, 10: dddd}");
            Console.WriteLine($"H:{today:hh}, M:{today:mm}, S:{today:ff}");
            Console.WriteLine($"{today:yyyy.MM.dd.hh.mm.ff}");
            var pi = Math.PI;
            Console.WriteLine($"{pi:c2}");
            Console.WriteLine($"{pi,10:n3}");
        }
    }
}