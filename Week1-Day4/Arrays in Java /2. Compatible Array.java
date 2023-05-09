import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        boolean isCompatible = true;
        
        for (int i = 0; i < n; i++) {
            arr1[i] = scanner.nextInt();
        }
        
        for (int i = 0; i < n; i++) {
            arr2[i] = scanner.nextInt();
        }
        
        for (int i = 0; i < n; i++) {
            if (arr1[i] < arr2[i]) {
                isCompatible = false;
                break;
            }
        }
        
        if (isCompatible) {
            System.out.println("Compatible");
        } else {
            System.out.println("Incompatible");
        }
        
        scanner.close();
    }
}
