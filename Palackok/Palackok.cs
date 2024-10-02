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

        public void egyenloFuggveny(Palackok palack1, Palackok palack2) {
            if(palack1 == palack2)
            {
                Console.WriteLine("egyenlőek");
            }
            Console.WriteLine("nem egyenlőek");
            
        }
        public void hozzaOnt(Palackok palack1, Palackok palack2)
        {

            if(palack1 != palack2 && palack1.jelenlegiUrtartalom != 0 && palack2.jelenlegiUrtartalom != 0)
            {
                Console.WriteLine("Azonos a két ital, vagy üres valamelyik");
            }
            else
            {
                if(palack1.jelenlegiUrtartalom + palack2.jelenlegiUrtartalom <= palack1.maxUrtartalom)
                {
                    palack1.ital = "Keverék";
                    palack1.jelenlegiUrtartalom += palack2.jelenlegiUrtartalom;
                    Console.WriteLine("neve: " + palack1.Ital , "ürtartalma: " +  palack1.jelenlegiUrtartalom );
                }
               

            }

        }



        public override string ToString()
        {
            return $"Neve: {this.ital}, max űrtartalom: {this.maxUrtartalom}ml, jelenlegi: {this.jelenlegiUrtartalom}ml";
        }
    }
}
