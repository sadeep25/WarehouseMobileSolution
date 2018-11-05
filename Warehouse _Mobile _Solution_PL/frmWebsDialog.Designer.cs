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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.scanBinLbl = new System.Windows.Forms.Label();
            this.binFromLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.FullRowSelect = true;
            listViewItem3.Text = "test";
            this.listView1.Items.Add(listViewItem3);
            this.listView1.Location = new System.Drawing.Point(18, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(136, 107);
            this.listView1.TabIndex = 0;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Web number";
            this.columnHeader1.Width = 133;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.scanBinLbl);
            this.panel1.Controls.Add(this.binFromLbl);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(17, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 175);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(50, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Done";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scanBinLbl
            // 
            this.scanBinLbl.Location = new System.Drawing.Point(76, 8);
            this.scanBinLbl.Name = "scanBinLbl";
            this.scanBinLbl.Size = new System.Drawing.Size(96, 20);
            this.scanBinLbl.Text = "#222222";
            // 
            // binFromLbl
            // 
            this.binFromLbl.Location = new System.Drawing.Point(3, 8);
            this.binFromLbl.Name = "binFromLbl";
            this.binFromLbl.Size = new System.Drawing.Size(67, 20);
            this.binFromLbl.Text = "Bin (from)";
            // 
            // frmWebsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(210, 238);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWebsDialog";
            this.Text = "frmWebsDialog";
            this.Load += new System.EventHandler(this.frmWebsDialog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label binFromLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label scanBinLbl;
    }
}