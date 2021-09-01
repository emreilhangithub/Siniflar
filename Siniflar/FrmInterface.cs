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
    public partial class FrmInterface : Form
    {
        public interface IPerson
        {
            int Id { get; set; }
            string City { get; set; }
        }

        public class Customer : IPerson
        {
            public int Id { get; set; }
            public string City { get; set; }
            public int MyProperty { get; set; }
        }

        public FrmInterface()
        {
            InitializeComponent();

            //Örnek 1
            IPerson person = new Customer();
            person.Id = 4; //burada myPropery erişemeyiz cunkü biz direk person sınıfına ulastık

            Customer customer = new Customer();
            customer.Id = 3; //burada hem properylere hemde implante ulaşabiliri kalıtım gibi
        }
    }
}
