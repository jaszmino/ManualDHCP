﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualDHCP
{
    public partial class Form_Anzeige : Form
    {
        public Form_Anzeige()
        {
            InitializeComponent();
        }
        private void bt_save_Click(object sender, EventArgs e)
        {

        }
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Anzeige fa = new Form_Anzeige();
            fa.ShowDialog();
        }
        private void bt_new_Click(object sender, EventArgs e)
        {
            Form_NeuesNetz fn = new Form_NeuesNetz();
            fn.ShowDialog();
        }
        private void bt_abort_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
