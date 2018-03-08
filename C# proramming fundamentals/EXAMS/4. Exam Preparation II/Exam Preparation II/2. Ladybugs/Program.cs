using System;
using System.Linq;

namespace _2.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfTheField = int.Parse(Console.ReadLine());

            var field = new int[sizeOfTheField];

            var ladybugsIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i >= 0 && i < sizeOfTheField) // Only these between 0 and sizeOfTheFiled !
                .ToList();
            // fill the arr(filed) -> (If sizeOfTheFiled = 3 and ladybugsIndexes = 0 1 -> field[0] = 1 and filed[1] = 1; -> ! Debug !
            foreach (var index in ladybugsIndexes)
            {
                field[index] = 1;
            }

            while (true)
            {
                var command = Console.ReadLine().Split(' ');

                if (command[0] == "end")
                {
                    break;
                }

                var currentLadybugIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);
                // Ако е "left" обръщаме знака !
                if (direction == "left")
                {
                    flyLength *= -1;
                }
                // outside of the field !
                if (currentLadybugIndex < 0 || currentLadybugIndex >= sizeOfTheField)
                {
                    continue;
                }
                //there is no ladybug in this cell !
                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }
                // Fly away
                field[currentLadybugIndex] = 0;
                // Set the nextIndex to land !
                var nextIndexToLand = currentLadybugIndex;

                while (true)
                {   // increase to the next indexToLand , if there is ladybug in the cell !
                    nextIndexToLand += flyLength;
                    // outside of the field !
                    if (nextIndexToLand < 0 || nextIndexToLand >= sizeOfTheField)
                    {
                        break;
                    }
                    // there is ladybug in this cell !
                    if (field[nextIndexToLand] == 1)
                    {
                        continue;
                    }
                    // If the current cell is empty(field[nextIndexToLand] == 0 ,set it to 1), land here and break !
                    field[nextIndexToLand] = 1;
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}