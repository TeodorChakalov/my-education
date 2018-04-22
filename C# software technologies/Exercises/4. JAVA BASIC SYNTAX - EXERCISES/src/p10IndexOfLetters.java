import java.util.Scanner;

public class p10IndexOfLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[] array = scan.nextLine().toCharArray();

        for (int i = 0; i < array.length; i++)
        {
            System.out.printf("%s -> %d\n", array[i], array[i] - 97);
        }
    }
}
