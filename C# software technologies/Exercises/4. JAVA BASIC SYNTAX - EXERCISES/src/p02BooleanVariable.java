import com.sun.org.apache.xpath.internal.operations.Bool;

import java.util.Scanner;

public class p02BooleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Boolean input = Boolean.parseBoolean(scan.nextLine());

        Boolean boolean1 = Boolean.valueOf("True");
        Boolean boolean2 = Boolean.valueOf("False");

        if(input == boolean1){
            System.out.println("Yes");
        }
        else if(input == boolean2){
            System.out.println("No");
        }
    }
}
