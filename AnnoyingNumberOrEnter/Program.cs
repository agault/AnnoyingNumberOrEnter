using System;

namespace AnnoyingNumberOrEnter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and continuously ask the user to enter a number
            // or "ok" to exit. Calculate the sum of all the previously entered
            // numbers and display it on the console.
            //Ask for number or ok to exit

            int total = 0;
            while (true)
            {
                Console.Write("Please provide us with a number or 'ok' to exit:");
                
                var input = Console.ReadLine();
                int number;
                var numInput = Int32.TryParse(input, out number);
                
                if (numInput)
                {
                    total += number;
                   
                }
                else if(input == "ok")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please provide the required information");
                }
                Console.WriteLine("The total is {0}", total);
            }
            

            //Console.WriteLine(Convert.ToInt32(total));
        }
    }
}
