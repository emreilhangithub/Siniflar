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

            rb.Add(); //normal methoduda bu şekilde çagırabiliriz
            rb.Update();

            Araba araba = new Araba { renk = "yesil", hiz = 180, motor = 111, fiyat = 60000, durum = 's', YIL = 2011, MARKASI = "Passat" }; //bu şekildede propertylere ulaşabiliriz
            MessageBox.Show(araba.renk);

            ArabaDetay arabaDetay = new ArabaDetay();
            arabaDetay.LASTIK = "BRIDGESTONE"; //protectede ulaştık
            MessageBox.Show(arabaDetay.LASTIK);

        }

        private void btnEv_Click(object sender, EventArgs e)
        {
            FrmEv frm = new FrmEv();
            frm.ShowDialog();
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            FrmNotlar frm = new FrmNotlar();
            frm.ShowDialog();
        }

        private void btnKalitim_Click(object sender, EventArgs e)
        {
            FrmKalıtım frm = new FrmKalıtım();
            frm.ShowDialog();
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            FrmInterface frm = new FrmInterface();
            frm.ShowDialog();
        }

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            FrmAbstract frm = new FrmAbstract();
            frm.ShowDialog();
        }
    }
    public class Ulasim
    {
        public int a, b;
    }
}
