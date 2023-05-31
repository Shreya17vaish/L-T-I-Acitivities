using System;

namespace UserAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter UserName");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            User user1 = new User(name, username, password, phoneNumber);

            Console.WriteLine("Enter Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter UserName");
            username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            password = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            User user2 = new User(name, username, password, phoneNumber);

            if (user1.ComparePhoneNumber(user2))
            {
                Console.WriteLine("Same Users");
            }
            else
            {
                Console.WriteLine("Different Users");
            }
        }
    }
}
