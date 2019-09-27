using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mata in två tal
            //Gör en additionsberäkning och visa svaret
            Console.WriteLine("Enter number 1:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation '+' or '-'");
            string op = Console.ReadLine();

            //Nu vill vi göra beräkningen och visa resultatet

        }
    }
}
