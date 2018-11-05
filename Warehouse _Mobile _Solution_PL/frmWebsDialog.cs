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
    public partial class frmWebsDialog : Form
    {
        public string binNumber { get; set; }
        public List<string> ReturnValue1 { get; set; }
        public frmWebsDialog()
        {
            InitializeComponent();
        }

        private void frmWebsDialog_Load(object sender, EventArgs e)
        {
            scanBinLbl.Text = binNumber;
            loadWebs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> selectedWebs = new List<string>();
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked)
                {
                    selectedWebs.Add(listView1.Items[i].Text.ToString());
                }
            }
            ReturnValue1 = selectedWebs;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void loadWebs()
        {
            ListViewItem l1 = new ListViewItem("22222222");
            listView1.Items.Add(l1);
            ListViewItem l2 = new ListViewItem("33333333");
            listView1.Items.Add(l2);
            ListViewItem l3 = new ListViewItem("44444444");
            listView1.Items.Add(l3);
            ListViewItem l4 = new ListViewItem("55555555");
            listView1.Items.Add(l4);
            ListViewItem l5 = new ListViewItem("66666666");
            listView1.Items.Add(l5);

        }
    }
}