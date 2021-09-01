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
    public partial class FrmConstructors : Form
    {
        public FrmConstructors()
        {
            CustomerMenager customerMenager = new CustomerMenager(23,"ahmet"); //countu dışarıdan girdik
            //CustomerMenager customerMenager = new CustomerMenager { Id = 1,Name="Mustafa"};
            customerMenager.Add();

            InitializeComponent();
        }

        public class CustomerMenager //bu bir class(sınıf)
        {
            public CustomerMenager() // bu bir Constructor
            {

            }

            private int _id;
            private string _name;
            public CustomerMenager(int id,string name) //Constructor overload ettik bos gönderdik
            {
                _id = id;
                _name = name;
            }
           
            public void List() //bu bir method(fonksiyon)
            {
                MessageBox.Show("Listed");
            }
            public void Add()
            {
                MessageBox.Show("Added");
            }

            public int Id { get; set; }
            public string Name { get; set; }
        }






    }
}
