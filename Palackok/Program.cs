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

            Rekesz rekesz = new Rekesz(50000);

            Palackok palackok1 = new Palackok("alma", 2000, 2300);
            Palackok palackok2 = new Palackok("körte", 4000, 1000);
            Palackok palackok3 = new Palackok("dinnye", 5000, 2300);
            Palackok palackok4 = new Palackok("alma", 2000, 2300);
            VisszavalthatoPalack visszavalthatoPalack1 = new VisszavalthatoPalack("alma", 2000, 2300, 0);
            VisszavalthatoPalack visszavalthatoPalack2 = new VisszavalthatoPalack("körte", 4000, 1000, 50);
            VisszavalthatoPalack visszavalthatoPalack3 = new VisszavalthatoPalack("dinnye", 5000, 2300, 50);
            VisszavalthatoPalack visszavalthatoPalack4 = new VisszavalthatoPalack("alma", 2000, 2300, 50);

            Console.WriteLine(palackok1);
            Console.WriteLine(visszavalthatoPalack1);

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            rekesz.ujPalack(palackok1);
            rekesz.ujPalack(palackok2);
            rekesz.ujPalack(palackok3);
            rekesz.ujPalack(palackok4);
            rekesz.ujPalack(visszavalthatoPalack1);
            rekesz.ujPalack(visszavalthatoPalack2);
            rekesz.ujPalack(visszavalthatoPalack3);
            rekesz.ujPalack(visszavalthatoPalack4);

            Console.WriteLine("suly függyvény: " + palackok1.sulyFuggveny());
            Console.WriteLine("egyenlőek e?"  );
            palackok1.egyenloFuggveny(palackok1, palackok4);
            Console.WriteLine("hozzá önt függvény: ");
            palackok2.hozzaOnt(palackok2, palackok3);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("súly: " + rekesz.suly());
            Console.WriteLine("össz pénz: " + rekesz.osszesPenz());
            Console.WriteLine();
        }
    }
}
