//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Cake
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var widthCake = int.Parse(Console.ReadLine());
//            var lengthCake = int.Parse(Console.ReadLine());
//            var totalPieces = widthCake * lengthCake;
//            var input = "";
//            var taken = 0;

//            for (int i = 0; i < totalPieces; i++)
//            {
//                input = Console.ReadLine();

//                if(input == "STOP")
//                {
//                    Console.WriteLine("{0} pieces are left.", totalPieces - taken);
//                    break;
//                }
//                else
//                {
//                    taken += int.Parse(input);

//                    if (taken > totalPieces)
//                    {
//                        Console.WriteLine("No more cake left! You need {0} pieces more.", taken - totalPieces);
//                        break;
//                    }
//                }
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var cakeWidth = double.Parse(Console.ReadLine());
            var cakeHeight = double.Parse(Console.ReadLine());
            var totalPieces = cakeHeight * cakeWidth;
            var pieces = 0;

            var command = Console.ReadLine();

            while (command != "STOP")
            {
                pieces += int.Parse(command);
 
                if(pieces > totalPieces)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", pieces - totalPieces);
                    break;
                }

                command = Console.ReadLine();

                if (command == "STOP")
                {
                    Console.WriteLine("{0} pieces are left.", totalPieces - pieces);
                    break;
                }
            }
        }
    }
}
