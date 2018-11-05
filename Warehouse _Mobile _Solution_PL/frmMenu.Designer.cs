namespace Warehouse__Mobile__Solution_PL
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu2;

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
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PutIntoBinbtn = new System.Windows.Forms.Button();
            this.BinToBinbtn = new System.Windows.Forms.Button();
            this.IssueTheWebsbtn = new System.Windows.Forms.Button();
            this.HandoverToFinishingbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuLabel
            // 
            this.MenuLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.MenuLabel.Location = new System.Drawing.Point(17, 34);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(61, 20);
            this.MenuLabel.Text = "Menu";
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(148, 34);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(72, 20);
            this.LogOutbtn.TabIndex = 1;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "In-House Acknowledgement";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PutIntoBinbtn
            // 
            this.PutIntoBinbtn.Location = new System.Drawing.Point(17, 109);
            this.PutIntoBinbtn.Name = "PutIntoBinbtn";
            this.PutIntoBinbtn.Size = new System.Drawing.Size(203, 29);
            this.PutIntoBinbtn.TabIndex = 3;
            this.PutIntoBinbtn.Text = "Put into Bin";
            // 
            // BinToBinbtn
            // 
            this.BinToBinbtn.Location = new System.Drawing.Point(17, 145);
            this.BinToBinbtn.Name = "BinToBinbtn";
            this.BinToBinbtn.Size = new System.Drawing.Size(203, 29);
            this.BinToBinbtn.TabIndex = 4;
            this.BinToBinbtn.Text = "Bin to Bin";
            this.BinToBinbtn.Click += new System.EventHandler(this.BinToBinbtn_Click);
            // 
            // IssueTheWebsbtn
            // 
            this.IssueTheWebsbtn.Location = new System.Drawing.Point(17, 181);
            this.IssueTheWebsbtn.Name = "IssueTheWebsbtn";
            this.IssueTheWebsbtn.Size = new System.Drawing.Size(203, 29);
            this.IssueTheWebsbtn.TabIndex = 5;
            this.IssueTheWebsbtn.Text = "Issue the Webs";
            // 
            // HandoverToFinishingbtn
            // 
            this.HandoverToFinishingbtn.Location = new System.Drawing.Point(17, 217);
            this.HandoverToFinishingbtn.Name = "HandoverToFinishingbtn";
            this.HandoverToFinishingbtn.Size = new System.Drawing.Size(203, 29);
            this.HandoverToFinishingbtn.TabIndex = 6;
            this.HandoverToFinishingbtn.Text = "Handover to Finishing";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.HandoverToFinishingbtn);
            this.Controls.Add(this.IssueTheWebsbtn);
            this.Controls.Add(this.BinToBinbtn);
            this.Controls.Add(this.PutIntoBinbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.MenuLabel);
            this.Menu = this.mainMenu2;
            this.Name = "frmMenu";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMenu_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PutIntoBinbtn;
        private System.Windows.Forms.Button BinToBinbtn;
        private System.Windows.Forms.Button IssueTheWebsbtn;
        private System.Windows.Forms.Button HandoverToFinishingbtn;

    }
}