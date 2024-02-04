using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class frmCustomerOrder : Form
    {
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private void frmCustomerOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
