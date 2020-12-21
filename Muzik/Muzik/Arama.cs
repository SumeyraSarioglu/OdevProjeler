using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Muzik
{
    class Arama : IMuzik
    {
        public void Cal()
        {
            SoundPlayer ses = new SoundPlayer(@"C:\Windows\Media\Ring01.wav");
            ses.Play();
        }
       
        public void Uyar()
        {
            MessageBox.Show("Arama Zil Sesi Çalıyor.");

        }
    }
}
