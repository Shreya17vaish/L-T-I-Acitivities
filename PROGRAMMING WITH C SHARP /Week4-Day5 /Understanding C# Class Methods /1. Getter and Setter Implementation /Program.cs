using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the customer details");
        Console.WriteLine("Enter the id :");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name :");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the email :");
        string email = Console.ReadLine();
        Console.WriteLine("Enter the address :");
        string address = Console.ReadLine();
        Console.WriteLine("Enter the purpose :");
        string purpose = Console.ReadLine();
        Console.WriteLine("Enter the other customer details :");
        string otherDetails = Console.ReadLine();

        Customer customer = new Customer();
        customer.Id = id;
        customer.Name = name;
        customer.Email = email;
        customer.Address = address;
        customer.Purpose = purpose;
        customer.OtherDetails = otherDetails;

        customer.Display();
    }
}

