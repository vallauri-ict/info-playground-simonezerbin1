using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_orario
{
    class Data
    {
        protected int Giorno;
        protected int Mese;
        protected int Anno;
        int[] GiorniMese = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] Giorni = new string[] { "Lunedì","Martedì","Mercoledì","Giovedì","Venerdì","Sabato","Domenica" };
        public Data(int giorno, int mese, int anno)
        {
            this.Anno = anno;
            this.Giorno = giorno;
            this.Mese = mese;
        }
        public Data()
        {
            this.Anno = 1900;
            this.Mese = 1;
            this.Giorno = 1;
        }

        public override string ToString()
        {
            return Giorno+"/"+Mese+"/"+Anno;
        }
        public virtual bool bisestile()
        {
            if (Anno % 4 == 0)
                return true;
            else
                return false;
        }
        public virtual void leggi(int giorno, int mese, int anno)
        {
            Giorno = giorno;
            Mese = mese;
            Anno = anno;
        }
        public virtual void scrivi(ref int giorno, ref int mese, ref int anno)
        {
            Giorno = giorno;
            Mese = mese;
            Anno = anno;
        }
        public virtual void Domani()
        {
            if (bisestile())
                GiorniMese[1] = 29;
            else
                GiorniMese[1] = 28;
            if (Giorno < GiorniMese[Mese - 1])
            {
                Giorno++;
            }
            else
            {
                Giorno = 0;
                if (Mese < 12)
                    Mese++; 
                else
                {
                    Mese = 0;
                    Anno++;
                }
            }
        }


        public virtual void Ieri()
        {
            if (bisestile())
                GiorniMese[1] = 29;
            else
                GiorniMese[1] = 28;
            if (Giorno > 0)
            {
                Giorno--;
            }
            else
            {
                Giorno = GiorniMese[Mese-1];
                if (Mese >0)
                    Mese--;
                else
                {
                    Mese = 12;
                    Anno--;
                }
            }
        }



        public virtual string giorno()
        {
            return Giorni[(Giorno-1) % 7 ];
        }
    }

}
