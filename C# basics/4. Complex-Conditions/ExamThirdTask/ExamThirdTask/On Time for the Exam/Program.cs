using System;
class Program
{
    static void Main()
    {
        var ExamHour = int.Parse(Console.ReadLine());
        var ExamMinutes = int.Parse(Console.ReadLine());
        var comeHour = int.Parse(Console.ReadLine());
        var comeMinutes = int.Parse(Console.ReadLine());

        var examTime = ExamHour * 60 + ExamMinutes;
        var comeTime = comeHour * 60 + comeMinutes;

        var minutesDifference = examTime - comeTime;

        var hours = Math.Abs(minutesDifference / 60);
        var minutes = Math.Abs(minutesDifference % 60);

        if (minutesDifference > 30) { Console.WriteLine("Early"); }
        else if (minutesDifference > 0 && minutesDifference <= 30) { Console.WriteLine("On time"); }
        else if (minutesDifference == 0) { Console.WriteLine("On time"); }
        else  { Console.WriteLine("Late"); }

        if (hours > 0)
        {
            if (minutes < 10)
            {
                Console.Write("{0}:0{1} before start", hours, minutes);
            }
            else
            {
                Console.Write("{0}:{1}", hours, minutes);
            }
        }
        else
        {
            Console.Write("{0} minutes", minutes);
        }

        if (minutesDifference < 0)
        {
            Console.WriteLine(" after the start");
        }
        else
        {
            Console.WriteLine(" before the start");
        }
    }
}