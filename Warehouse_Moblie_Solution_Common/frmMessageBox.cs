using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Warehouse_Moblie_Solution_Common
{
    public partial class frmMessageBox : Form
    {
        string successImg = "Warehouse_Moblie_Solution_Common.Images.profit.png";
        string errorImg = "Warehouse_Moblie_Solution_Common.Images.profit.png";
        string warnningImg = "Warehouse_Moblie_Solution_Common.Images.profit.png";
        string infoImg = "Warehouse_Moblie_Solution_Common.Images.profit.png";
        public frmMessageBox()
        {
            InitializeComponent();
        }

        public frmMessageBox(MessageTypes type, string message, string caption)
        {
            InitializeComponent();
            this.Text = caption;
            switch (type)
            {
                case MessageTypes.Success:
                    btnOk.Visible = true;
                    btnOk.BackColor = Color.LightGreen;
                    lblMessage.Text = message;
                    this.BackColor = Color.LightGreen;
                    icnMessage.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(successImg));
                    break;
                case MessageTypes.Error:
                    btnOk.Visible = true;
                    btnOk.BackColor = Color.LightSalmon;
                    lblMessage.Text = message;
                    this.BackColor = Color.LightSalmon;
                    icnMessage.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(errorImg));
                    break;
                case MessageTypes.Info:
                    btnOk.Visible = true;
                    btnOk.BackColor = Color.LightBlue;
                    lblMessage.Text = message;
                    this.BackColor = Color.LightBlue;
                    icnMessage.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(infoImg));
                    break;
                case MessageTypes.Warning:
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnYes.BackColor = Color.LightBlue;
                    btnNo.BackColor = Color.LightBlue;
                    lblMessage.Text = message;
                    this.BackColor = Color.LightBlue;
                    icnMessage.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(warnningImg));
                    break;
            }
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }


}