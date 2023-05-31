using System;

class Program{
  public static void Main (string[] args) {
    //Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    for (int i = num; i >= 1; i--) {
      for (int j = i; j >= 1; j--) {
        Console.Write(j + " ");
      }
      Console.WriteLine();
    }
  }
}
