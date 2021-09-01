using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class ArabaDetay:Araba
    {
        public string LASTIK
        {
            get { return lastik; } // get method
            set { lastik = value; }// set method
        }

    }
}
