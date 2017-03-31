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

        static float ReadFloat(string query)
        {
            return float.Parse(ReadInput(query));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            var rectangle = new Rectangle();
            while (true)
            {
                try
                {
                    rectangle.Width = ReadFloat("Width");
                    rectangle.Height = ReadFloat("Height");
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
