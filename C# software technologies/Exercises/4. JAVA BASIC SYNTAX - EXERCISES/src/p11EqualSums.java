import java.util.Arrays;
import java.util.Scanner;

public class p11EqualSums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] array = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        if (array.length == 1)
        {
            System.out.println(0);
            return;
        }

        for (int i = 0; i < array.length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;
            for (int j = 0; j < i; j++)
            {
                leftSum += array[j];
            }
            for (int j = i + 1; j < array.length; j++)
            {
                rightSum += array[j];
            }
            if (leftSum == rightSum)
            {
                System.out.println(i);
                return;
            }
        }
        System.out.println("no");
    }
}
