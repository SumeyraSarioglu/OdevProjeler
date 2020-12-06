using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int fiyat;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label10.Visible = false;
                dateTimePicker2.Visible = false;
                checkBox1.Checked = false;
            }
            else
            {
                label10.Visible = true;
                dateTimePicker2.Visible = true;
                checkBox1.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label10.Visible = true;
                dateTimePicker2.Visible = true;
            }  
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

           
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
                fiyat = 350;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
                fiyat = 500;
            }
            else
            {
                checkBox4.Checked = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            modelsec();
            Yolcudetay();
            textBox6.AppendText(comboBox1.Text + " " + comboBox2.Text + "gidiş Tarihi:" + dateTimePicker1.Value + "dönüş Tarihi:" + dateTimePicker2.Value + " Fiyat " + fiyat.ToString());
        }    
        
      
      

        void Yolcudetay()
        {
            
            if (checkBox7.Checked)
            { 
                Yolcu yolcu = new Yolcu();
                yolcu.AdSoyad = textBox1.Text;
                yolcu.TC = textBox2.Text;
                yolcu.Telefon = textBox3.Text;
                yolcu.Mail = textBox4.Text;
                yolcu.Dtarih = textBox5.Text;
                textBox6.AppendText(yolcu.YolcuDetay()+" "+'\n');
            }
            else if(checkBox6.Checked)
            {
                
                Bebek bebek = new Bebek();
                bebek.AdSoyad = textBox1.Text;
                bebek.TC = textBox2.Text;
                bebek.Dtarih = textBox5.Text;
                textBox6.AppendText(bebek.YolcuDetay()+" "+'\n');
            } 
 
        }
      


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void modelsec()
        {
            
            Airbus airbus = new Airbus();
            Boeing boeing = new Boeing();

            if (comboBox3.SelectedIndex == 0)
            {
                airbus.UcakModeli = "Airbus A320";
                airbus.KanatBoyu = "64,80";
                airbus.YerdenYuksekligi = "18.6";
                textBox6.AppendText(airbus.OzetYaz()+'\n');
                

            }
            else if (comboBox3.SelectedIndex == 1)
            {
                boeing.UcakModeli = "Boeing B737-8FH";
                boeing.KanatBoyu = "65,00";
                boeing.YerdenYuksekligi = "17,5";
                textBox6.AppendText(boeing.OzetYaz()+'\n');

            }
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
