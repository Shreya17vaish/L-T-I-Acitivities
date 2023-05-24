using System;

class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int  n =int.Parse (Console.ReadLine());
        if(n%2==0)
        {
            Console.WriteLine(n  +" is an even number");
        }
        else
        {
            Console.WriteLine(n +" is an odd number");
        }
    }
}
