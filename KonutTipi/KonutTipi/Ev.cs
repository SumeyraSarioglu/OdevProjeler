using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonutTipi
{
    class Ev : IEv //Base Class
    {
       public  const double Fiyat = 1000;
       public double Kira = 1000;

        public double BinaYasi(int Yas)
        {
            
         
            if (Yas == 0)
            {
                Kira += Fiyat * 0.5;               
            }
            else if (Yas==1)
            {
                Kira += Fiyat * 0.4;
            }
            else if (Yas == 2)
            {
                Kira += Fiyat * 0.3;
            }
            else if( Yas==3)
            {
                Kira += Fiyat * 0.2;
            }
            else
            {
                MessageBox.Show("Seçim Yapınız !");
            }
            return Kira;
        }

        public double KatSayisi(int Kat)
        {
            if (Kat == 0)
            {
                Kira += Fiyat * 0.5;
            }
            else if (Kat == 1)
            {
                Kira += Fiyat * 0.4;
            }
            else if (Kat == 2)
            {
                Kira += Fiyat * 0.3;
            }
            else if (Kat == 3)
            {
                Kira += Fiyat * 0.2;
            }
            else
            {
                MessageBox.Show("Seçim Yapınız !");
            }
            return Kira;
        }

        public double OdaSayisi(int Oda)
        {
            if (Oda == 0)
            {
                Kira += Fiyat * 0.2;
            }
            else if (Oda == 1)
            {
                Kira += Fiyat * 0.3;
            }
            else if (Oda == 2)
            {
                Kira += Fiyat * 0.4;
            }
            else if (Oda == 3)
            {
                Kira += Fiyat * 0.5;
            }
            else
            {
                MessageBox.Show("Seçim Yapınız !");
            }
            return Kira;
        }

        public string SonucSoyle(int min,int max,double kira)
        {
            if (kira<min || kira>max)
            {
                return "hessaplanan kira bedeli: " + kira + " belirttiğiniz aralığın dışındadır.";
            }

            else
            {
                return "hessaplanan kira bedeli: " + kira+ " bu  fiyat aralığında ev sahibi olabilirsin !";
            }
        }

       
    }
}
