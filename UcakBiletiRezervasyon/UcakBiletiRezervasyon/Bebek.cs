using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiRezervasyon
{
    class Bebek : Yolcu
    {
        //public void uyarı() {

        //    MessageBox.Show("her bir bebek yolcu için bir ebeveyn eşlik etmelidir.");
        //}

        public override string YolcuDetay() //Hocam buraya data aktarmasını nasıl yaparız?

        {
            Yolcu yolcu = new Yolcu();

            string detay = " bebeğin Adı soyad: " + yolcu.AdSoyad + "Bebeğin Kimlik bilgileri : " + yolcu.TC + "Bebeğin doğum tarihi : " + yolcu.Dtarih;
            return detay;
        }



    }
}
