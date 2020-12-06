using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletiRezervasyon
{
    class Ucak
    {
        string _UcakModeli;
        public string UcakModeli {
            get { return _UcakModeli; }
            set { _UcakModeli = value; }        
        }
        string _KanatBoyu;
        public string KanatBoyu
        {
            get { return _KanatBoyu; }
            set { _KanatBoyu = value; }
        }

        string _YerdenYuksekligi;
        public string YerdenYuksekligi
        {
            get { return _YerdenYuksekligi; }
            set { _YerdenYuksekligi = value; }
        }

        public string OzetYaz()
        {
            string ozet ="uçak modeli:"+ _UcakModeli+" kanat boyutu "+_KanatBoyu+"  yerden yüksekliği:"+_YerdenYuksekligi;
            return ozet;
        }
    }
}
