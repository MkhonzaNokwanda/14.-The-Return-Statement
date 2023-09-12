using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.The_Return_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x =Convert.ToInt32(Console.ReadLine());
            
           Console.WriteLine(Cube(x));

            //freeze console
            Console.ReadLine();
        }
     //making of the cube method
        static int Cube(int x)
        {
            Console.WriteLine("The cube of the number you entered is ");
            return x * x * x;
        }
    }
}
