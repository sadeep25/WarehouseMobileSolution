namespace Warehouse__Mobile__Solution_PL
{
    partial class frmBinToBin
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
            this.label1 = new System.Windows.Forms.Label();
            this.movebtn = new System.Windows.Forms.Button();
            this.bintibinstatuslbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.binfromlbl = new System.Windows.Forms.Label();
            this.bintolbl = new System.Windows.Forms.Label();
            this.binscanfromlbl = new System.Windows.Forms.Label();
            this.binscantolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Bin to Bin";
            // 
            // movebtn
            // 
            this.movebtn.Enabled = false;
            this.movebtn.Location = new System.Drawing.Point(55, 206);
            this.movebtn.Name = "movebtn";
            this.movebtn.Size = new System.Drawing.Size(125, 27);
            this.movebtn.TabIndex = 1;
            this.movebtn.Text = "Move";
            this.movebtn.Click += new System.EventHandler(this.movebtn_Click);
            // 
            // bintibinstatuslbl
            // 
            this.bintibinstatuslbl.Location = new System.Drawing.Point(3, 236);
            this.bintibinstatuslbl.Name = "bintibinstatuslbl";
            this.bintibinstatuslbl.Size = new System.Drawing.Size(234, 20);
            this.bintibinstatuslbl.Text = "[Scan the bin where webs stored  in]";
            this.bintibinstatuslbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(41, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(155, 101);
            this.listView1.TabIndex = 3;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Webs";
            this.columnHeader1.Width = 154;
            // 
            // binfromlbl
            // 
            this.binfromlbl.Location = new System.Drawing.Point(17, 42);
            this.binfromlbl.Name = "binfromlbl";
            this.binfromlbl.Size = new System.Drawing.Size(70, 20);
            this.binfromlbl.Text = "Bin (from)";
            this.binfromlbl.Visible = false;
            // 
            // bintolbl
            // 
            this.bintolbl.Location = new System.Drawing.Point(17, 67);
            this.bintolbl.Name = "bintolbl";
            this.bintolbl.Size = new System.Drawing.Size(70, 20);
            this.bintolbl.Text = "Bin (to)";
            this.bintolbl.Visible = false;
            // 
            // binscanfromlbl
            // 
            this.binscanfromlbl.Location = new System.Drawing.Point(81, 42);
            this.binscanfromlbl.Name = "binscanfromlbl";
            this.binscanfromlbl.Size = new System.Drawing.Size(156, 20);
            this.binscanfromlbl.Text = "label5";
            this.binscanfromlbl.Visible = false;
            // 
            // binscantolbl
            // 
            this.binscantolbl.Location = new System.Drawing.Point(81, 67);
            this.binscantolbl.Name = "binscantolbl";
            this.binscantolbl.Size = new System.Drawing.Size(156, 20);
            this.binscantolbl.Text = "label6";
            this.binscantolbl.Visible = false;
            // 
            // frmBinToBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.binscantolbl);
            this.Controls.Add(this.binscanfromlbl);
            this.Controls.Add(this.bintolbl);
            this.Controls.Add(this.binfromlbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bintibinstatuslbl);
            this.Controls.Add(this.movebtn);
            this.Controls.Add(this.label1);
            this.Name = "frmBinToBin";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmBinToBin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button movebtn;
        private System.Windows.Forms.Label bintibinstatuslbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label binfromlbl;
        private System.Windows.Forms.Label bintolbl;
        private System.Windows.Forms.Label binscanfromlbl;
        private System.Windows.Forms.Label binscantolbl;
    }
}