using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string arama = "Ara";
            Cagir(arama);
        }
        void Cagir(String deger)
        {
            if (deger=="Ara")
            {
                Arama arama = new Arama();
                arama.Cal();
                arama.Uyar();
            }
            else if (deger =="mail")
            {
                Mail mail = new Mail();
                mail.Cal();
                mail.Uyar();

            }
            else if (deger == "geri")
            {
                GeriDonusum geriDonusum = new GeriDonusum();
                geriDonusum.Cal();
                geriDonusum.Uyar();
            }
            else
            {
                MessageBox.Show("tuşa basınız!!");
            }
          
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            String deger = "mail";
            Cagir(deger);
        }

        private void btnGeriDonusum_Click(object sender, EventArgs e)
        {
            string deger = "geri";
            Cagir(deger);
        }
    }
}
