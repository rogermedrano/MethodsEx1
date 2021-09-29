using System;

namespace MethodsEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            var fName = Console.ReadLine();

            Console.WriteLine($"Hello {fName}, how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{fName}, what state are you from?");
            var state = Console.ReadLine();

            Console.WriteLine($"Last question, {fName}: What do you do in your spare time?");
            var hobby = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            Console.WriteLine($"First Name:  {fName}");
            Console.WriteLine($"Age:  {age} years old");
            Console.WriteLine($"From:  {state}");
            Console.WriteLine($"Leisure Activity:  {hobby}");

            Console.WriteLine();
            Console.WriteLine("___________________________________________");
            Console.WriteLine("___________________________________________");
            Console.WriteLine();

            Console.WriteLine($"Everyone, meet {fName}.  {fName} is {age} and comes from {state}.  {fName} likes to {hobby} when not occupied.");
        }
    }
}
