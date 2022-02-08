using System;

namespace C#Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Please enter your name:");
            person.Name = Console.ReadLine();

            Console.Write("Please enter your age:");
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("You entered: Name: {0}, Age {1}", person.Name, person.Age);
        }
    }
}
