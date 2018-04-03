using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_9_ques_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            float ans;
        start: try
            {
                Console.WriteLine("Enter a number: ");
                number = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a number to be divided: " + number);
                int numb = int.Parse(Console.ReadLine());
                ans = numb / number;
            }

            catch
            {
                Console.WriteLine("Invalid!! \n .....Enter number other than zero \n ... Press Enter To Repeat");

                Console.ReadKey();
                goto start;
            }

            Console.WriteLine("ans is: " + ans);
            Console.ReadKey();
        }
    }
}
