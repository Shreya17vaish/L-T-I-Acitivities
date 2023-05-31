using System;

class MainClass {
  public static void Main (string[] args) {
    //Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    for (int i = num; i >= 1; i--) {
      for (int j = 1; j <= i; j++) {
        Console.Write(j + " ");
      }
      Console.WriteLine();
    }
  }
}
