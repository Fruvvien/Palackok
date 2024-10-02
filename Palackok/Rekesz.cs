using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Rekesz : Palackok
    {
        private int max_teherbiras;
        private List<Palackok> palackok;

        public Rekesz( int max_teherbiras)
        {
            this.max_teherbiras = max_teherbiras;
            this.palackok = new List<Palackok>();
        }

        public int suly()
        {
            int osszSuly = 0;
            if (palackok.Count == 0)
            {
                return osszSuly;
            }
            else
            {
                foreach (var item in palackok)
                {
                    osszSuly += item.JelenlegiUrtartalom;
                }
                return osszSuly;
            }

        }

        public void ujPalack(Palackok palack)
        {
            this.palackok.Add(palack);
            if (suly() < max_teherbiras)
            {

            }
            else
            {
                this.palackok.Remove(palack);
            }
            
        }
        public int osszesPenz()
        {
            int osszesPenz = 0;
            foreach (var item in palackok)
            {
               if(item is VisszavalthatoPalack palack)
                {
                    osszesPenz += palack.Palackdij;
                }
            }
          
            return osszesPenz;
        }
    }
}
