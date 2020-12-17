using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonutTipi
{
    class Daire :Ev 
    {
        public double Esya(bool esya)
        {
            if (esya)
                return Kira += Fiyat * 0.8;
            else
                return Kira;

        }
    }
}
