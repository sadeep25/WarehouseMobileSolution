namespace Warehouse__Mobile__Solution_PL
{
    partial class frmWebsDialog
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
            this.lvWebs = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWebsDialogDone = new System.Windows.Forms.Button();
            this.lblScanBin = new System.Windows.Forms.Label();
            this.lblBinFrom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvWebs
            // 
            this.lvWebs.CheckBoxes = true;
            this.lvWebs.Columns.Add(this.columnHeader1);
            this.lvWebs.FullRowSelect = true;
            listViewItem1.Text = "test";
            this.lvWebs.Items.Add(listViewItem1);
            this.lvWebs.Location = new System.Drawing.Point(18, 41);
            this.lvWebs.Name = "lvWebs";
            this.lvWebs.Size = new System.Drawing.Size(174, 136);
            this.lvWebs.TabIndex = 0;
            this.lvWebs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Web number";
            this.columnHeader1.Width = 171;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWebsDialogDone);
            this.panel1.Controls.Add(this.lblScanBin);
            this.panel1.Controls.Add(this.lblBinFrom);
            this.panel1.Controls.Add(this.lvWebs);
            this.panel1.Location = new System.Drawing.Point(11, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 229);
            // 
            // btnWebsDialogDone
            // 
            this.btnWebsDialogDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnWebsDialogDone.Location = new System.Drawing.Point(67, 194);
            this.btnWebsDialogDone.Name = "btnWebsDialogDone";
            this.btnWebsDialogDone.Size = new System.Drawing.Size(72, 20);
            this.btnWebsDialogDone.TabIndex = 3;
            this.btnWebsDialogDone.Text = "Done";
            this.btnWebsDialogDone.Click += new System.EventHandler(this.btnWebsDialogDone_Click);
            // 
            // lblScanBin
            // 
            this.lblScanBin.Location = new System.Drawing.Point(91, 8);
            this.lblScanBin.Name = "lblScanBin";
            this.lblScanBin.Size = new System.Drawing.Size(96, 20);
            this.lblScanBin.Text = "#222222";
            // 
            // lblBinFrom
            // 
            this.lblBinFrom.Location = new System.Drawing.Point(18, 8);
            this.lblBinFrom.Name = "lblBinFrom";
            this.lblBinFrom.Size = new System.Drawing.Size(67, 20);
            this.lblBinFrom.Text = "Bin (from)";
            // 
            // frmWebsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWebsDialog";
            this.Text = "frmWebsDialog";
            this.Load += new System.EventHandler(this.frmWebsDialog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvWebs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBinFrom;
        private System.Windows.Forms.Button btnWebsDialogDone;
        private System.Windows.Forms.Label lblScanBin;
    }
}