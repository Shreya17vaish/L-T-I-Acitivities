using System;

public class Program
{
    static void Main(string[] args)
    {
        ItemType item = new ItemType();

        Console.WriteLine("Enter the item type name");
        item.Name = Console.ReadLine();

        Console.WriteLine("Enter the cost per day");
        item.CostPerDay = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the deposit");
        item.Deposit = double.Parse(Console.ReadLine());

        item.Display();
    }
}
