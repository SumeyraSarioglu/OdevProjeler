using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Muzik
{
    class GeriDonusum : IMuzik
    {
        public void Cal()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Windows\Media\Windows Unlock.wav");
            sound.Play();
        }

        public void Uyar()
        {
            MessageBox.Show("Dosya Silindi..");
        }
    }
}
