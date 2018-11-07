namespace Warehouse__Mobile__Solution_PL
{
    partial class frmPutIntoBin
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
            this.lblPutIntoBinHeader = new System.Windows.Forms.Label();
            this.btnPutIntoBinSave = new System.Windows.Forms.Button();
            this.lblPutIntoBinStatus = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScanBin = new System.Windows.Forms.Label();
            this.lblScanWeb = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPutIntoBinHeader
            // 
            this.lblPutIntoBinHeader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPutIntoBinHeader.Location = new System.Drawing.Point(3, 20);
            this.lblPutIntoBinHeader.Name = "lblPutIntoBinHeader";
            this.lblPutIntoBinHeader.Size = new System.Drawing.Size(100, 20);
            this.lblPutIntoBinHeader.Text = "Put Into Bin";
            // 
            // btnPutIntoBinSave
            // 
            this.btnPutIntoBinSave.Enabled = false;
            this.btnPutIntoBinSave.Location = new System.Drawing.Point(56, 182);
            this.btnPutIntoBinSave.Name = "btnPutIntoBinSave";
            this.btnPutIntoBinSave.Size = new System.Drawing.Size(112, 29);
            this.btnPutIntoBinSave.TabIndex = 2;
            this.btnPutIntoBinSave.Text = "Save";
            this.btnPutIntoBinSave.Click += new System.EventHandler(this.btnPutIntoBinSave_Click);
            // 
            // lblPutIntoBinStatus
            // 
            this.lblPutIntoBinStatus.Location = new System.Drawing.Point(19, 236);
            this.lblPutIntoBinStatus.Name = "lblPutIntoBinStatus";
            this.lblPutIntoBinStatus.Size = new System.Drawing.Size(185, 20);
            this.lblPutIntoBinStatus.Text = "[Scan the web to store ]";
            this.lblPutIntoBinStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeb
            // 
            this.lblWeb.Location = new System.Drawing.Point(3, 21);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(47, 20);
            this.lblWeb.Text = "Web";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblScanBin);
            this.panel1.Controls.Add(this.lblScanWeb);
            this.panel1.Controls.Add(this.lblBin);
            this.panel1.Controls.Add(this.lblWeb);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 100);
            // 
            // lblScanBin
            // 
            this.lblScanBin.Location = new System.Drawing.Point(36, 58);
            this.lblScanBin.Name = "lblScanBin";
            this.lblScanBin.Size = new System.Drawing.Size(195, 20);
            // 
            // lblScanWeb
            // 
            this.lblScanWeb.Location = new System.Drawing.Point(36, 21);
            this.lblScanWeb.Name = "lblScanWeb";
            this.lblScanWeb.Size = new System.Drawing.Size(195, 20);
            // 
            // lblBin
            // 
            this.lblBin.Location = new System.Drawing.Point(3, 58);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(47, 20);
            this.lblBin.Text = "Bin";
            // 
            // frmPutIntoBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPutIntoBinStatus);
            this.Controls.Add(this.btnPutIntoBinSave);
            this.Controls.Add(this.lblPutIntoBinHeader);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "frmPutIntoBin";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmPutIntoBin_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmPutIntoBin_Closing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPutIntoBinHeader;
        private System.Windows.Forms.Button btnPutIntoBinSave;
        private System.Windows.Forms.Label lblPutIntoBinStatus;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScanBin;
        private System.Windows.Forms.Label lblScanWeb;
        private System.Windows.Forms.Label lblBin;
    }
}