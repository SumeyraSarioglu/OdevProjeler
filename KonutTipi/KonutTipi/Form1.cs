using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonutTipi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KonutSec();
        }
        void KonutSec()
        {
            if (comboBox1.SelectedIndex==0)
            {
                Daire daire = new Daire();
                daire.BinaYasi( comboBox2.SelectedIndex);
                daire.KatSayisi(comboBox2.SelectedIndex);
                daire.OdaSayisi(comboBox3.SelectedIndex);               
                label8.Text = daire.SonucSoyle(int.Parse(textBox1.Text), int.Parse(textBox2.Text), daire.Kira);
            }
            else if (comboBox2.SelectedIndex==1)
            {
                Mustakil mustakil = new Mustakil();
                mustakil.BinaYasi(comboBox2.SelectedIndex);
                mustakil.KatSayisi(comboBox2.SelectedIndex);
                mustakil.OdaSayisi(comboBox3.SelectedIndex);
                label8.Text = mustakil.SonucSoyle(int.Parse(textBox1.Text), int.Parse(textBox2.Text), mustakil.Kira);
            }
            else
            {
                Yali yali = new Yali();
                yali.BinaYasi(comboBox2.SelectedIndex);
                yali.KatSayisi(comboBox2.SelectedIndex);
                yali.OdaSayisi(comboBox3.SelectedIndex);
                label8.Text = yali.SonucSoyle(int.Parse(textBox1.Text), int.Parse(textBox2.Text), yali.Kira);
            }
        }
    }
}
