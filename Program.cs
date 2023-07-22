using System;

namespace StudentRegistration
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Student Registration Form -----");

    
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student's age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter student's course: ");
            string course = Console.ReadLine();

            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);

            Console.WriteLine("\nStudent registration successful!");
        }
    }
}
