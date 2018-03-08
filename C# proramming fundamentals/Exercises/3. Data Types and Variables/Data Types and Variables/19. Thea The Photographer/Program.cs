using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberTakenPictures = double.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling(numberTakenPictures * filterFactor / 100);
            var time1 = numberTakenPictures * filterTime;
            var time2 = filteredPictures * uploadTime;
            var totalTime = time1 + time2;

            //var minutes = 0;
            //var hours = 0;
            //var days = 0;
            //while (totalTime > 59)
            //{
            //    totalTime -= 60;
            //    minutes++;
            //    if (minutes > 60)
            //    {
            //        minutes -= 60;
            //        hours++;
            //    }
            //    if (hours > 23)
            //    {
            //        hours -= 24;
            //        days++;
            //    }
            //}

            //Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{totalTime:00}");
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string result = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);
        }
    }
}