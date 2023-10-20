using System;
namespace inlamning4._3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int digit=0; digit <= 100; digit++)
            {
                if (digit % 3 == 0 && digit % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (digit % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if(digit % 3==0)
                {
                    Console.WriteLine("Fizz");

                }
                else
                {
                    Console.WriteLine(digit);
                }
 
            }

        }

    }

}