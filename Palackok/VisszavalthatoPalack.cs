using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class VisszavalthatoPalack : Palackok
    {

        private int palackdij;

        public VisszavalthatoPalack(string ital, int maxUrtartalom, int jelenlegiUrtartalom, int palackdij): base(ital, maxUrtartalom, jelenlegiUrtartalom)
        {
            if(palackdij == 0)
            {

                this.Palackdij = 25;
            }
            else
            {
                this.Palackdij = palackdij;
            }
        }

        public int Palackdij { get => palackdij; set => palackdij = value; }

        public override string ToString()
        {

            return $"A Visszaváltható palack neve: {ital}, max űrtartalom: {maxUrtartalom}ml, jelenlegi: {jelenlegiUrtartalom}ml";
        }
    }
}
