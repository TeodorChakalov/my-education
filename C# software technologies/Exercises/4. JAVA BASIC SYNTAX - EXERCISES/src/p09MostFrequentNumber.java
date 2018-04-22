import java.util.Arrays;
import java.util.Scanner;

public class p09MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int max = 0;
        int number = 0;

        for (int i = 0; i < numbers.length; i++)
        {
            int counter = 1;
            for (int j = i + 1; j < numbers.length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    counter++;
                }
            }
            if (counter > max)
            {
                max = counter;
                number = numbers[i];
            }
        }
        System.out.println(number);
    }
}
