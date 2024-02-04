﻿using System;
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
    public partial class frmMain : Form
    {
        frmEmployee frmemployee = new frmEmployee();
        frmMenu frmmenu = new frmMenu();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu.Show();


        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmemployee.Show();
        }
    }
}
