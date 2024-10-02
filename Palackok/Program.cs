using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palackok palackok = new Palackok("asd", 2000, 2300);
            VisszavalthatoPalack visszavalthatoPalack = new VisszavalthatoPalack("asd", 2000, 2300, 0);
            Console.WriteLine(palackok);
            Console.WriteLine(visszavalthatoPalack);
        }
    }
}
