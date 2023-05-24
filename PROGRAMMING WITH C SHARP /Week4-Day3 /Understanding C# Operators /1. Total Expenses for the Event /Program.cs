using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter branding expenses");
        double brandingExpenses = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter travel expenses");
        double travelExpenses = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter food expenses");
        double foodExpenses = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter logistics expenses");
        double logisticsExpenses = double.Parse(Console.ReadLine());

        double totalExpenses = brandingExpenses + travelExpenses + foodExpenses + logisticsExpenses;
        Console.WriteLine($"Total expenses: Rs.{totalExpenses:F2}");

        Console.WriteLine($"Branding expenses percentage: {(brandingExpenses / totalExpenses) * 100:F2}%");
        Console.WriteLine($"Travel expenses percentage: {(travelExpenses / totalExpenses) * 100:F2}%");
        Console.WriteLine($"Food expenses percentage: {(foodExpenses / totalExpenses) * 100:F2}%");
        Console.WriteLine($"Logistics expenses percentage: {(logisticsExpenses / totalExpenses) * 100:F2}%");
    }
}
