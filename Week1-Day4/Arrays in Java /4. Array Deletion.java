import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);

    // Read input
    System.out.println("Enter the number of elements in the array");
    int n = sc.nextInt();
    int[] arr = new int[n];
    System.out.println("Enter the elements in the array");
    for (int i = 0; i < n; i++) {
      arr[i] = sc.nextInt();
    }
    System.out.println("Enter the location where you wish to delete an element");
    int loc = sc.nextInt();

    // Delete element if location is valid
    if (loc >= 1 && loc <= n) {
      int[] newArr = new int[n - 1];
      int j = 0;
      for (int i = 0; i < n; i++) {
        if (i != loc - 1) {
          newArr[j] = arr[i];
          j++;
        }
      }

      // Print new array
      System.out.println("Array after deletion is");
      for (int i = 0; i < n - 1; i++) {
        System.out.println(newArr[i]);
      }
    } else {
      System.out.println("Invalid Input");
    }
  }
}
