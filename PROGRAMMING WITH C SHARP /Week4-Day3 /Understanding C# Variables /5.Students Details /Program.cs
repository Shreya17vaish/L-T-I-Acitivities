using System;

class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Enter Flight name :");
        string name =Console.ReadLine();
        Console.WriteLine("Enter Ticket No :");
        string  num=Console.ReadLine();
        Console.WriteLine("Enter Flight Fare :");
        string fare=Console.ReadLine();
        Console.WriteLine("Enter Travelling Class :");
        string c=Console.ReadLine();
        Console.WriteLine("Enter Source :");
        string source=Console.ReadLine();
        Console.WriteLine("Enter Destination :");
        string desty=Console.ReadLine();

        Console.WriteLine("Flight Details :");
        Console.WriteLine("Flight Name : "+ name);
        Console.WriteLine("Ticket No : "+ num);
        Console.WriteLine("Flight Fare : "+ fare);
        Console.WriteLine("Class : "+ c);
        Console.WriteLine("Source : "+ source);
        Console.WriteLine("Destination : "+desty);
        }
}
