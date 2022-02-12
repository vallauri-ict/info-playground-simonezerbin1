using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    class Mannaro : Mostro
    {
        protected bool mutato;
        protected new string verso;
        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }
        public new double Valore()
        {
            if (mutato)
                return 2 * base.Valore();
            else
                return base.Valore();
        }
        public string Verso()
        {
            if (mutato)
                return verso;
            else
                return base.verso;//è la stessa variabile
        }
        public void Muta()
        {
            mutato = !mutato;
        }
    }


}
