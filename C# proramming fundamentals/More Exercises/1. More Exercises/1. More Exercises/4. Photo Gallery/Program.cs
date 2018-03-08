using System;

namespace _4.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberPhoto = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var sizeOfPhoto = double.Parse(Console.ReadLine());
            var widthPhoto = int.Parse(Console.ReadLine());
            var heightPhoto = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:D4}.jpg", numberPhoto);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2:D4} {3:D2}:{4:D2}", day, month, year, hours, minutes);
            if (sizeOfPhoto < 1000)
            {
                Console.WriteLine("Size: {0}B", sizeOfPhoto);
                
            }
            else if(sizeOfPhoto < 1000000)
            {
                Console.WriteLine("Size: {0}KB", sizeOfPhoto / 1000);
            }
            else
            {
                Console.WriteLine("Size: {0}MB", sizeOfPhoto /  1000000);
            }
            if (widthPhoto > heightPhoto)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", widthPhoto, heightPhoto);
            }
            else if(widthPhoto < heightPhoto)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", widthPhoto, heightPhoto);
            }
            else
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", widthPhoto, heightPhoto);
            }
        }
    }
}