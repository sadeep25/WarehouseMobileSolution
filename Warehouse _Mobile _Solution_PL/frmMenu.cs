using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse__Mobile__Solution_PL
{
    public partial class frmMenu : Form
    {
        public Form RefToUserLogin { get; set; }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_Closing(object sender, CancelEventArgs e)
        {
            RefToUserLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInHouseAcknowledgement AcknowlegmentForm = new frmInHouseAcknowledgement();
            AcknowlegmentForm.RefToMenu = this;
            this.Hide();
            AcknowlegmentForm.Show();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            frmUserLogin login = new frmUserLogin();
            login.Show();
            this.Close();
        }

        private void BinToBinbtn_Click(object sender, EventArgs e)
        {
            frmBinToBin form = new frmBinToBin();
            form.RefToMenu = this;
            this.Hide();
            form.Show();
        }
    }
}