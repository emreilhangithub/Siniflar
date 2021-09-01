using System;
using System.Drawing;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class FrmAraba : Form
    {
        public FrmAraba()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            Araba rb = new Araba(); //nesne türettik
            rb.renk = "mavi"; //nesnenin özelliklerine eriştik
            rb.hiz = 160;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.YIL = -2016;
            rb.MARKASI = "golf";


            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
