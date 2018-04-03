using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_lab_9_ques_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long id;
            string name;
        start: try
            {
                Console.WriteLine("Library System...");
                Console.WriteLine("Enter your Id Card No.: ");
                id = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter Book Name: ");
                name = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("\nInvalid!!! \nId Card No. should be in number! \n Press Enter to Continue");
                Console.ReadKey();
                goto start;
            }
            if (name == "Turbo C")
            {
                Console.WriteLine("Sorry this book has already been issued to someone! \n... Press enter to repeat");
                Console.ReadKey();
                goto start;
            }
            else
            {
                Console.WriteLine(name + " is now issued to ID No.:" + id);
            }
            Console.ReadKey();
        }
    }
}
