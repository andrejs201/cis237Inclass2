using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine("The answer to 5! is: ");
            Console.WriteLine(factorial.Calculate(5));

            Console.WriteLine("\n*******************************\n");
            Hanoi hanoi = new Hanoi();

            hanoi.moveDisc(20, 'A', 'B', 'C');
        }
    }
}
