using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    class Alemler
    {
        public void Add(ICanlilar canlilar)
        {
            MessageBox.Show(canlilar.Id.ToString());
        }
    }
}
