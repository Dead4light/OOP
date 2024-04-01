using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the x coordinate:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the y coordinate:");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height:");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("Creating a label with the following parameters:");
        Console.WriteLine($"Location: ({x}, {y})");
        Console.WriteLine($"Size: ({width}, {height})");

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        Console.WriteLine("Adding the label to the form...");

        // Ваш код для додавання елементу Label до консолі буде тут
        // Оскільки у консолі немає спеціальних елементів управління, 
        // то замість цього ми можемо просто вивести параметри елементу Label.

        Console.WriteLine("Label added successfully!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
