using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonutTipi
{
    class Yali:Ev
    {
        public double Havuz(bool havuz)
        {
            if (havuz)
                return Kira += Fiyat * 0.8;
            else
                return Kira;

        }
    }
}
