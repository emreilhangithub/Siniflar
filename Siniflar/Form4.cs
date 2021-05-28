using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int ortalama(int s1, int s2, int s3)
        {
            int sonuc = (s1 + s2 + s3) / 3;
            return sonuc;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.ad = textBox1.Text;
            ogr.soyad = textBox2.Text;
            ogr.kulup = textBox3.Text;

            Notlar nt1 = new Notlar();
            nt1.Sinav1 = Convert.ToInt16(textBox4.Text);
            nt1.Sinav2 = Convert.ToInt16(textBox5.Text);
            nt1.Sinav3 = Convert.ToInt16(textBox6.Text);
            nt1.Ortalama = ortalama(nt1.Sinav1, nt1.Sinav2, nt1.Sinav3);

            textBox7.Text = nt1.Ortalama.ToString();

            listBox1.Items.Add(
                ogr.ad + " " + ogr.soyad + " " + ogr.kulup + " " + nt1.Sinav1
                + " " + nt1.Sinav2 + " " + nt1.Sinav3 + " Ortalama = " + nt1.Ortalama
                );

            

        }
    }
}
