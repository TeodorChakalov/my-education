using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var comeHour = int.Parse(Console.ReadLine());
            var comeMinute = int.Parse(Console.ReadLine());

            var examMinutes = examHour * 60 + examMinute;
            var comeMinutes = comeHour * 60 + comeMinute;

            var difference = examMinutes - comeMinutes;

            if (difference > 30) Console.WriteLine("Early");
            else if (difference >= 0 && difference <= 30) Console.WriteLine("On time");
            else Console.WriteLine("Late");

            var hours = Math.Abs(difference / 60);
            var minutes = Math.Abs(difference % 60);

            if (hours == 0)
            {
                if (difference < 0) Console.WriteLine("{0} minutes after the start", minutes);
                else if (difference > 0) Console.WriteLine("{0} minutes before the start", minutes);             
            }
            else if (hours > 0)
            {
                if (minutes < 10 && difference < 0) Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
                else if (minutes < 10 && difference > 0) Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);

                if(minutes > 10 && difference < 0) Console.WriteLine("{0}:{1} hours after the start", hours, minutes);
                else if (minutes > 10 && difference > 0) Console.WriteLine("{0}:{1} hours before the start", hours, minutes);
            }
        }
    }
}
