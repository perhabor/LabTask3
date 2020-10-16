using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int counter = 1;
                int i = 0;
                int smallest = 0;
                int value = 0;

                Console.WriteLine("kindly enter five numbers: ");
                index = Convert.ToInt32(Console.ReadLine());

                for (counter = 1;counter <= i; counter++)
                {

                    if (counter == 1)
                        smallest = value;

                        else if (value < smallest)
                            smallest = value;
                }

                Console.WriteLine("The smallest number  entered is {0}", smallest);
                Console.ReadLine();
            
        }
    }
}