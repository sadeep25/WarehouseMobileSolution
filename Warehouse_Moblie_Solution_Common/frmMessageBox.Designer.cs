namespace Warehouse_Moblie_Solution_Common
{
    partial class frmMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.icnMessage = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // icnMessage
            // 
            this.icnMessage.Location = new System.Drawing.Point(97, 61);
            this.icnMessage.Name = "icnMessage";
            this.icnMessage.Size = new System.Drawing.Size(45, 50);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(25, 17);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(192, 41);
            this.lblMessage.Text = "label1";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(25, 117);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(72, 20);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(145, 117);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(72, 20);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(85, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 20);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(242, 157);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.icnMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(0, 60);
            this.Name = "frmMessageBox";
            this.Text = "Message Box";
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icnMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnOk;

    }
}