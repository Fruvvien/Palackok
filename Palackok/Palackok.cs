using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Palackok 
    {
        protected string ital;
        protected int maxUrtartalom;
        protected int jelenlegiUrtartalom;

        public Palackok(string ital, int maxUrtartalom, int jelenlegiUrtartalom)
        {
            this.Ital = ital;
            this.MaxUrtartalom = maxUrtartalom;
            if (jelenlegiUrtartalom == 0)
            {
                this.JelenlegiUrtartalom = 1;
            }
            else
            {
                this.JelenlegiUrtartalom = jelenlegiUrtartalom;
            }
        }

        public string Ital { get => ital; set => ital = value; }
        public int MaxUrtartalom { get => maxUrtartalom; set => maxUrtartalom = value; }
        public int JelenlegiUrtartalom
        {
            get => jelenlegiUrtartalom;
            set { 
            
                if (value > maxUrtartalom)
                {
                    jelenlegiUrtartalom = maxUrtartalom;
                }
                else
                {
                    jelenlegiUrtartalom = value;
                }
            }


        }


        public int sulyFuggveny()
        {
            return this.maxUrtartalom / 35 + this.jelenlegiUrtartalom;
        }

        public bool egyenloFuggveny() {

            
        }
        public void hozzaOnt()
        {



        }



        public override string ToString()
        {
            return $"Neve: {this.ital}, max űrtartalom: {this.maxUrtartalom}ml, jelenlegi: {this.jelenlegiUrtartalom}ml";
        }
    }
}
