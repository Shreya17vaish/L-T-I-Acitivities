import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int[] arr = new int[n];
        int distinctCount = 0;
        boolean isDistinct;

        for (int i = 0; i < n; i++) {
            arr[i] = scanner.nextInt();
            isDistinct = true;
            for (int j = 0; j < i; j++) {
                if (arr[i] == arr[j]) {
                    isDistinct = false;
                    break;
                }
            }
            if (isDistinct) {
                distinctCount++;
            }
        }

        System.out.println(distinctCount);
    }
}
