using System;
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
    public partial class Form_NeuesNetz : Form
    {
        private string _anzHosts;
        public string anzHosts
        {
            get { return _anzHosts; }
            set { _anzHosts = value; }
        }
        public Form_NeuesNetz()
        {
            InitializeComponent();
        }
        private void bt_accept_Click(object sender, EventArgs e)
        {
            _anzHosts = nmUpDown_anzHosts.Value.ToString();
            this.Close();
        }
        private void bt_abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
