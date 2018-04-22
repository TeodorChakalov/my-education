import java.util.Scanner;

public class p03ReverseCharacters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char[] array = new char[3];

        for (int i = 0; i < array.length; i++) {
            array[i] = scan.nextLine().charAt(0);
        }

        for (int i = array.length - 1; i >= 0; i--) {
            System.out.print(array[i]);
        }
    }
}
