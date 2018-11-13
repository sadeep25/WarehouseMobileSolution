using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Warehouse_Moblie_Solution_Common;

namespace Warehouse__Mobile__Solution_PL
{
    public partial class frmWebsDialog : Form
    {
        public string BinNumber { get; set; }
        public List<string> SelectedWebs { get; set; }

        public frmWebsDialog()
        {
            InitializeComponent();
        }

        private void frmWebsDialog_Load(object sender, EventArgs e)
        {
            lblScanBin.Text = BinNumber;
            LoadWebs();
        }

        private void btnWebsDialogDone_Click(object sender, EventArgs e)
        {

            List<string> selectedWebs = new List<string>();
            for (int i = lvWebs.Items.Count - 1; i >= 0; i--)
            {
                if (lvWebs.Items[i].Checked)
                {
                    selectedWebs.Add(lvWebs.Items[i].Text.ToString());
                }
            }
            if (selectedWebs.Count > 0)
            {
                SelectedWebs = selectedWebs;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }


        }

        private void LoadWebs()
        {
            ListViewItem l1 = new ListViewItem("22222222");
            lvWebs.Items.Add(l1);
            ListViewItem l2 = new ListViewItem("33333333");
            lvWebs.Items.Add(l2);
            ListViewItem l3 = new ListViewItem("44444444");
            lvWebs.Items.Add(l3);
            ListViewItem l4 = new ListViewItem("55555555");
            lvWebs.Items.Add(l4);
            ListViewItem l5 = new ListViewItem("66666666");
            lvWebs.Items.Add(l5);

        }
    }
}