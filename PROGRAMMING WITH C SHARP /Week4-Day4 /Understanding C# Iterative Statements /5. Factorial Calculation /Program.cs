using System;

class Program {
  public static void Main (string[] args) {
    //Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    int factorial = 1;
    for (int i = 2; i <= num; i++) {
      factorial *= i;
    }

    Console.WriteLine(factorial);
  }
}
