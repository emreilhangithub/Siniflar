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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ev evsnf = new Ev();
            evsnf.renk = "Mavi";
            evsnf.kat = 5;
            evsnf.yakit = 'd';
            evsnf.fiyat = 78000;

            label5.Text = evsnf.renk;
            label6.Text = evsnf.kat.ToString();
            label7.Text = evsnf.yakit.ToString();
            label8.Text = evsnf.fiyat.ToString();



        }
    }
}
