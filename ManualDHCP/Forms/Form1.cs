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
    public partial class Form1 : Form
    {
        private string _dbIP;
        private string _dbPort;
        public Form1()
        {
            InitializeComponent();
        }
        public string dbIP
        {
            get { return _dbIP; }
            set { _dbIP = value; }
        }
        public string dbPort
        {
            get { return _dbPort; }
            set { _dbPort = value; }
        }
        private void bt_connect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_IP.Text))
            {
                if (!string.IsNullOrWhiteSpace(tb_port.Text))
                {
                    _dbIP = tb_IP.Text;
                    _dbPort = tb_port.Text;
                    Form_Anzeige _fa = new Form_Anzeige();
                    _fa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bitte Port eingeben");
                }
            }
            else
            {
                MessageBox.Show("Bitte IP-Adresse eingeben");
            }
        }
        private void bt_abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
