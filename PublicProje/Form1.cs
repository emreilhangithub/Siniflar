using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siniflar;

namespace PublicProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ulasim ulasim = new Ulasim();
            ulasim.a = 1;
            ulasim.b = 1;
        }
    }
}
