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
        public string userBarcode { get; set; }
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

        private void btnInHouseAcknowledgement_Click(object sender, EventArgs e)
        {
            frmInHouseAcknowledgement AcknowlegmentForm = new frmInHouseAcknowledgement();
            AcknowlegmentForm.RefToMenu = this;
            this.Hide();
            AcknowlegmentForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmUserLogin login = new frmUserLogin();
            login.Show();
            this.Close();
        }

        private void btnBinToBin_Click(object sender, EventArgs e)
        {
            frmBinToBin form = new frmBinToBin();
            form.RefToMenu = this;
            this.Hide();
            form.Show();
        }

        private void btnPutIntoBin_Click(object sender, EventArgs e)
        {
            frmPutIntoBin form = new frmPutIntoBin();
            form.RefToMenu = this;
            this.Hide();
            form.Show();
        }

        private void btnIssueTheWebs_Click(object sender, EventArgs e)
        {
            frmIssueWebs form = new frmIssueWebs();
            form.RefToMenu = this;
            this.Hide();
            form.Show();
        }

        private void btnHandoverToFinishing_Click(object sender, EventArgs e)
        {
            frmHandOver form = new frmHandOver();
            form.RefToMenu = this;
            form.userBarcode = this.userBarcode;
            this.Hide();
            form.Show();
        }
    }
}