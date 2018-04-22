import java.util.Arrays;
import java.util.Scanner;

public class p07MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] array = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int len = 0;
        int max = 0;
        int longestSequenceStart = 0;

        for (int i = 0; i < array.length - 1; i++)
        {
            if(array[i] == array[i + 1])
            {
                len++;
                if(len > max)
                {
                    max = len;
                    longestSequenceStart = i - len;
                }
            }
            else
            {
                len = 0;
            }
        }
        for (int i = longestSequenceStart + 1; i <= longestSequenceStart + max + 1; i++)
        {
            System.out.print((array[i] + " "));
        }
    }
}
