import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int firstNumber = scan.nextInt();
        int secondNumber = scan.nextInt();
        int thirdNumber = scan.nextInt();

        if(firstNumber + secondNumber == thirdNumber){
            if(secondNumber < firstNumber){
                System.out.printf("%d + %d = %d%n", secondNumber, firstNumber, thirdNumber);
            }
            else {
                System.out.printf("%d + %d = %d%n", firstNumber, secondNumber, thirdNumber);
            }
        }
        else if(secondNumber + thirdNumber == firstNumber){
            if(thirdNumber < secondNumber){
                System.out.printf("%d + %d = %d%n", thirdNumber, secondNumber, firstNumber);
            }
            else {
                System.out.printf("%d + %d = %d%n", secondNumber, thirdNumber, firstNumber);
            }
        }
        else if(firstNumber + thirdNumber == secondNumber){
            if(thirdNumber < firstNumber){
                System.out.printf("%d + %d = %d%n", thirdNumber, firstNumber, secondNumber);
            }
            else {
                System.out.printf("%d + %d = %d%n", firstNumber, thirdNumber, secondNumber);
            }
        }
        else{
            System.out.printf("No");
        }
    }
}
