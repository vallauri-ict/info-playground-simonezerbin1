using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryQuadrato
{
    class Singleton
    {
        private static Singleton istanza = null;
        private static int id=0;
        public readonly int n;
        private Singleton()
        {
            id++;
            n = id;
        }

        public static Singleton GetIstance()
        {
            if (istanza == null)
                istanza = new Singleton();
            return istanza;
        }
    }
}
