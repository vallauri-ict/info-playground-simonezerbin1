using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_orario
{
    class DataOra:Data
    {
        private int Ore;
        private int Minuti;
        private int Secondi;


        public DataOra(int giorno, int mese, int anno)
        {
            this.Anno = anno;
            this.Giorno = giorno;
            this.Mese = mese;
        }
        public DataOra()
        {
            this.Anno = 1900;
            this.Mese = 1;
            this.Giorno = 1;
        }
        public DataOra(int giorno, int mese, int anno,int ore, int minuti, int secondi)
        {
            this.Anno = anno;
            this.Giorno = giorno;
            this.Mese = mese;
            this.Ore = ore;
            this.Minuti = minuti;
            this.Secondi = secondi;
        }

        public override string ToString()
        {
            return Giorno + "/" + Mese + "/" + Anno+" - "+Ore+":"+Minuti+":"+Secondi;
        }
        new public virtual void leggi(int ore, int minuti, int secondi)
        {
            Ore=ore;
            Minuti = minuti;
            Secondi = secondi;
        }
        new public virtual void scrivi(ref int ore, ref int minuti, ref int secondi)
        {
            Ore = ore;
            Minuti = minuti;
            Secondi = secondi;
        }
    }
}
