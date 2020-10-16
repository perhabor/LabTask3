using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)

  {

      
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();


            Console.Write("please enter your age: ");
           int Age = Convert.ToInt32(Console.ReadLine());


           Console.WriteLine($"Your name is- {Name} \n Your age is {Age} ");
        }
    }
}
