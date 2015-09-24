using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Hanoi
    {
        public void moveDisc(int n, char source, char auxilary, char destination)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
            }
            else
            {
                moveDisc(n - 1, source, destination, auxilary);
                moveDisc(1, source, auxilary, destination);
                moveDisc(n - 1, auxilary, source, destination);
            }
        }
    }
}
