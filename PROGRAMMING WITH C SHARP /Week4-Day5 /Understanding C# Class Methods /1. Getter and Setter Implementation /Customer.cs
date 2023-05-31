using System;

public class Customer
{
    private int _id;
    private string _name;
    private string _email;
    private string _address;
    private string _purpose;
    private string _otherDetails;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string Purpose
    {
        get { return _purpose; }
        set { _purpose = value; }
    }

    public string OtherDetails
    {
        get { return _otherDetails; }
        set { _otherDetails = value; }
    }

    public void Display()
    {
        Console.WriteLine("Customer details are :");
        Console.WriteLine("ID :{0}", Id);
        Console.WriteLine("Name :{0}", Name);
        Console.WriteLine("Email :{0}", Email);
        Console.WriteLine("Address :{0}", Address);
        Console.WriteLine("Purpose :{0}", Purpose);
        Console.WriteLine("Other details :{0}", OtherDetails);
    }
}

