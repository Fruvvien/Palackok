using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Rekesz 
    {
        private int max_teherbiras;
        private List<Palackok> palackok;
        public int rekeszTeherbiras = 0;
        public Rekesz(int max_teherbiras)
        {
            this.max_teherbiras = max_teherbiras;
            this.palackok = new List<Palackok>();
        }

        public int suly()
        {
            int osszSuly = 0;
            if (palackok.Count != 0)
            {
                foreach (var item in palackok)
                {
                    osszSuly += item.JelenlegiUrtartalom;
                }
                return osszSuly;
            }
            else
            {
                return 0;
            }

        }

        public void ujPalack(Palackok palack)
        {
          
            rekeszTeherbiras += palack.JelenlegiUrtartalom;
            if (rekeszTeherbiras <= max_teherbiras)
            {
                this.palackok.Add(palack);
            }else
            {

                this.palackok.Remove(palack);
            }
            
        }
        public double osszesPenz()
        {
            double osszesPenz = 0;
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
