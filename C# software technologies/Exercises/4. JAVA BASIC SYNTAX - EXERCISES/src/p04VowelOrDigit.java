import java.util.Scanner;

public class p04VowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char ch = scan.nextLine().charAt(0);

        if((ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'Y')
                || (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y')){
            System.out.println("vowel");
        }
        else if(ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9'){
            System.out.println("digit");
        }else{
            System.out.println("other");
        }
    }
}
