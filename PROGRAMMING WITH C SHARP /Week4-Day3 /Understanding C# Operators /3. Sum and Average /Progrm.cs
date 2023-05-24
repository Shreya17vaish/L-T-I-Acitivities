using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter the count");
        int count = int.Parse(Console.ReadLine());

        if (count <= 0) {
            Console.WriteLine("Invalid Input");
            return;
        }

        Console.WriteLine("Enter numbers");
        double sum = 0;
        for (int i = 0; i < count; i++) {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }

        double avg = sum / count;
        Console.WriteLine("Sum of numbers is {0:F1} average of numbers is {1:F1}", sum, avg);
    }
}
   
