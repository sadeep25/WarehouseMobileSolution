namespace Warehouse__Mobile__Solution_PL
{
    partial class frmUserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblLoginHeader.Location = new System.Drawing.Point(3, 26);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(100, 20);
            this.lblLoginHeader.Text = "Log In";
            // 
            // lblScan
            // 
            this.lblScan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblScan.Location = new System.Drawing.Point(62, 117);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(119, 20);
            this.lblScan.Text = "Scan Your Barcode";
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.lblScan);
            this.Controls.Add(this.lblLoginHeader);
            this.Menu = this.mainMenu1;
            this.Name = "frmUserLogin";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmUserLogin_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmUserLogin_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.Label lblScan;
    }
}