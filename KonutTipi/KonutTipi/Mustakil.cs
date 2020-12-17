using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonutTipi
{
    class Mustakil:Ev
    {
        public double bahce(bool bahce)
        {
            if (bahce)
                return Kira += Fiyat * 0.8;
            else
                return Kira;

        }
    }
}
