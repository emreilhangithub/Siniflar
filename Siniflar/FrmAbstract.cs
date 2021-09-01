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
    public partial class FrmAbstract : Form
    {
        public FrmAbstract()
        {
            InitializeComponent();

            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Database database2 = new MySql();
            database2.Add();
            database2.Delete();

            MySql mySql = new MySql();
            mySql.test = "aaa";
        }

        abstract class Database
        {
            public void Add() { MessageBox.Show("Add by default"); }
            public abstract void Delete();
        }

        class SqlServer : Database
        {
            public override void Delete()
            {
                MessageBox.Show("sql delete");
            }
        }

        class MySql : Database
        {
            public override void Delete()
            {
                MessageBox.Show("mysqldelete");
            }
            public string test { get; set; }

        }
    }
}
