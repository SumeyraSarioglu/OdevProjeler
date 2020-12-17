using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonutTipi
{
    interface IEv
    {
       
        double OdaSayisi(int Oda);

        double BinaYasi(int Yas);

        double KatSayisi(int Kat);

       string SonucSoyle(int min, int max, double kira);
    }
}
