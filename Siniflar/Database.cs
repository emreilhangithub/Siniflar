using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    class Database
    {
        public void Add() { MessageBox.Show("Add by default"); }
        public virtual void Delete() { MessageBox.Show("Delete by default"); }
    }
}
