using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_2
{
    public class Avtomobil
    {
        private Otoldirgich otoldirgich;
        private Gildirak gildirak;

        public Avtomobil(Otoldirgich otoldirgich, Gildirak gildirak)
        {
            this.otoldirgich = otoldirgich;
            this.gildirak = gildirak;
        }
        public void Start()
        {
            otoldirgich.Start();
            gildirak.Aylantirish();
            Console.WriteLine("Avtomobilim yurmoqda");
        }
        public void Stop() 
        {
            otoldirgich.Stop();
            Console.WriteLine("Avtomobil tuxtadi");
        }
    }
}
