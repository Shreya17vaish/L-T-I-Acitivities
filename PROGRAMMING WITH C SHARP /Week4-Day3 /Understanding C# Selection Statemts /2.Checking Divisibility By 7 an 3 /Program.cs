using System;

class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int n =int.Parse(Console.ReadLine());

        if((n%3==0)&& (n%7==0))
          
          {
              Console.WriteLine(n +" is divisible by both 7 and 3");
          }
       else
         {
          Console.WriteLine(n+" is not divisible by both 7 and 3 ");
         }
    }
}
