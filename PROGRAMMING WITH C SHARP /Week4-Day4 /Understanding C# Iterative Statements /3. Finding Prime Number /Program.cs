using System;

class MainClass {
  public static void Main (string[] args) {
    //Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    bool isPrime = true;

    if (num == 1 || num == 0) {
      isPrime = false;
    } else {
      for (int i = 2; i <= Math.Sqrt(num); i++) {
        if (num % i == 0) {
          isPrime = false;
          break;
        }
      }
    }

    if (isPrime) {
      Console.WriteLine( "Prime");
    } else {
      Console.WriteLine("Not prime ");
    }
  }
}
   
