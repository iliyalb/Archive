import java.time.LocalDate;
import java.util.Scanner;

public class ScannerSystem {
    public static void main(String[] args) {
        // Name
        Scanner scanner = new Scanner(System.in);
        System.out.println("Your name?");
        String name = scanner.nextLine();
        System.out.println("Hello " + name);

        // Age
        System.out.println("Your age?");
        int age = scanner.nextInt();
        int year = LocalDate.now().minusYears(age).getYear();
        System.out.println("Born in " + year + "? Nice!");
    }
}