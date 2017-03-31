using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string ReadInput(string query)
        {
            Console.Write(query + ": ");
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            var rectangle = new Rectangle();
            while (true)
            {
                try
                {
                    rectangle.Width = float.Parse(ReadInput("Width"));
                    rectangle.Height = float.Parse(ReadInput("Height"));
                    Console.WriteLine("The area of the rectangle is " + rectangle.Area);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            Console.ReadLine();

        }
    }
}
