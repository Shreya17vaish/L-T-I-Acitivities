using System;

class Program {
  public static void Main (string[] args) {
    //Console.Write("Enter registration code: ");
    int n = int.Parse(Console.ReadLine());

    if (n < 10) {
      Console.WriteLine("Invalid Input");
    } else {
      int firstDigit = n % 10;
      int lastDigit = n;
      while (lastDigit >= 10) {
        lastDigit /= 10;
      }
      Console.WriteLine(Math.Abs(firstDigit - lastDigit));
    }
  }
}
   
