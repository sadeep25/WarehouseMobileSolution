namespace Warehouse__Mobile__Solution_PL
{
    partial class frmMenu
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
            this.lblMenuHeader = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInHouseAcknowledgement = new System.Windows.Forms.Button();
            this.btnPutIntoBin = new System.Windows.Forms.Button();
            this.btnBinToBin = new System.Windows.Forms.Button();
            this.btnIssueTheWebs = new System.Windows.Forms.Button();
            this.btnHandoverToFinishing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuHeader
            // 
            this.lblMenuHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblMenuHeader.Location = new System.Drawing.Point(17, 34);
            this.lblMenuHeader.Name = "lblMenuHeader";
            this.lblMenuHeader.Size = new System.Drawing.Size(61, 20);
            this.lblMenuHeader.Text = "Menu";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(148, 34);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(72, 20);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnInHouseAcknowledgement
            // 
            this.btnInHouseAcknowledgement.Location = new System.Drawing.Point(17, 74);
            this.btnInHouseAcknowledgement.Name = "btnInHouseAcknowledgement";
            this.btnInHouseAcknowledgement.Size = new System.Drawing.Size(203, 29);
            this.btnInHouseAcknowledgement.TabIndex = 2;
            this.btnInHouseAcknowledgement.Text = "In-House Acknowledgement";
            this.btnInHouseAcknowledgement.Click += new System.EventHandler(this.btnInHouseAcknowledgement_Click);
            // 
            // btnPutIntoBin
            // 
            this.btnPutIntoBin.Location = new System.Drawing.Point(17, 109);
            this.btnPutIntoBin.Name = "btnPutIntoBin";
            this.btnPutIntoBin.Size = new System.Drawing.Size(203, 29);
            this.btnPutIntoBin.TabIndex = 3;
            this.btnPutIntoBin.Text = "Put into Bin";
            this.btnPutIntoBin.Click += new System.EventHandler(this.btnPutIntoBin_Click);
            // 
            // btnBinToBin
            // 
            this.btnBinToBin.Location = new System.Drawing.Point(17, 145);
            this.btnBinToBin.Name = "btnBinToBin";
            this.btnBinToBin.Size = new System.Drawing.Size(203, 29);
            this.btnBinToBin.TabIndex = 4;
            this.btnBinToBin.Text = "Bin to Bin";
            this.btnBinToBin.Click += new System.EventHandler(this.btnBinToBin_Click);
            // 
            // btnIssueTheWebs
            // 
            this.btnIssueTheWebs.Location = new System.Drawing.Point(17, 181);
            this.btnIssueTheWebs.Name = "btnIssueTheWebs";
            this.btnIssueTheWebs.Size = new System.Drawing.Size(203, 29);
            this.btnIssueTheWebs.TabIndex = 5;
            this.btnIssueTheWebs.Text = "Issue the Webs";
            this.btnIssueTheWebs.Click += new System.EventHandler(this.btnIssueTheWebs_Click);
            // 
            // btnHandoverToFinishing
            // 
            this.btnHandoverToFinishing.Location = new System.Drawing.Point(17, 217);
            this.btnHandoverToFinishing.Name = "btnHandoverToFinishing";
            this.btnHandoverToFinishing.Size = new System.Drawing.Size(203, 29);
            this.btnHandoverToFinishing.TabIndex = 6;
            this.btnHandoverToFinishing.Text = "Handover to Finishing";
            this.btnHandoverToFinishing.Click += new System.EventHandler(this.btnHandoverToFinishing_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.btnHandoverToFinishing);
            this.Controls.Add(this.btnIssueTheWebs);
            this.Controls.Add(this.btnBinToBin);
            this.Controls.Add(this.btnPutIntoBin);
            this.Controls.Add(this.btnInHouseAcknowledgement);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblMenuHeader);
            this.Name = "frmMenu";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMenu_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuHeader;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnInHouseAcknowledgement;
        private System.Windows.Forms.Button btnPutIntoBin;
        private System.Windows.Forms.Button btnBinToBin;
        private System.Windows.Forms.Button btnIssueTheWebs;
        private System.Windows.Forms.Button btnHandoverToFinishing;

    }
}