using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletiRezervasyon
{
    class Yolcu// base class
    {
        string _AdSoyad;
        public string AdSoyad
        {
            get { return _AdSoyad; }
            set { _AdSoyad = value; }
        }
        string _TC;
        public string TC
        {
            get { return _TC; }
            set { _TC = value; }
        }

        string _Telefon;
        public string Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }
        string _Mail;
        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
        string _DTarih;
        public string Dtarih
        {
            get { return _DTarih; }
            set { _DTarih = value; }
        }

        public virtual string YolcuDetay()
        {
            string detay = " ad soyad :" + _AdSoyad + "Kimlik numarası " + _TC + " Telefon numarası :" +_Telefon+ " Mail : " + _Mail + "Telefon : " + _Telefon;
            return detay;
        }
    }
}
