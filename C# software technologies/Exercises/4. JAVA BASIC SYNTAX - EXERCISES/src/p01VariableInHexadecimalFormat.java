import java.util.Scanner;

public class p01VariableInHexadecimalFormat {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String hexNumber = scan.nextLine();
        System.out.println(Integer.parseInt(hexNumber,16));
    }
}
