namespace Warehouse__Mobile__Solution_PL
{
    partial class frmHandOver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.POScannedLbl = new System.Windows.Forms.Label();
            this.DeliveredToLbl = new System.Windows.Forms.Label();
            this.BroughtByLbl = new System.Windows.Forms.Label();
            this.POLbl = new System.Windows.Forms.Label();
            this.BroughtByScannedLbl = new System.Windows.Forms.Label();
            this.DeliveredToScannedLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.Text = "Hand Over to Finishing Dept";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeliveredToScannedLbl);
            this.panel1.Controls.Add(this.BroughtByScannedLbl);
            this.panel1.Controls.Add(this.POScannedLbl);
            this.panel1.Controls.Add(this.DeliveredToLbl);
            this.panel1.Controls.Add(this.BroughtByLbl);
            this.panel1.Controls.Add(this.POLbl);
            this.panel1.Location = new System.Drawing.Point(15, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 71);
            // 
            // POScannedLbl
            // 
            this.POScannedLbl.Location = new System.Drawing.Point(90, 9);
            this.POScannedLbl.Name = "POScannedLbl";
            this.POScannedLbl.Size = new System.Drawing.Size(100, 20);
            // 
            // DeliveredToLbl
            // 
            this.DeliveredToLbl.Location = new System.Drawing.Point(3, 49);
            this.DeliveredToLbl.Name = "DeliveredToLbl";
            this.DeliveredToLbl.Size = new System.Drawing.Size(81, 20);
            this.DeliveredToLbl.Text = "Delivered To";
            // 
            // BroughtByLbl
            // 
            this.BroughtByLbl.Location = new System.Drawing.Point(3, 29);
            this.BroughtByLbl.Name = "BroughtByLbl";
            this.BroughtByLbl.Size = new System.Drawing.Size(81, 20);
            this.BroughtByLbl.Text = "Brought By";
            // 
            // POLbl
            // 
            this.POLbl.Location = new System.Drawing.Point(3, 9);
            this.POLbl.Name = "POLbl";
            this.POLbl.Size = new System.Drawing.Size(81, 20);
            this.POLbl.Text = "PO";
            // 
            // BroughtByScannedLbl
            // 
            this.BroughtByScannedLbl.Location = new System.Drawing.Point(90, 29);
            this.BroughtByScannedLbl.Name = "BroughtByScannedLbl";
            this.BroughtByScannedLbl.Size = new System.Drawing.Size(100, 20);
            // 
            // DeliveredToScannedLbl
            // 
            this.DeliveredToScannedLbl.Location = new System.Drawing.Point(90, 49);
            this.DeliveredToScannedLbl.Name = "DeliveredToScannedLbl";
            this.DeliveredToScannedLbl.Size = new System.Drawing.Size(100, 20);
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(15, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 109);
            this.listView1.TabIndex = 3;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transfer";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Web Number";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bin Number";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Weight";
            this.columnHeader3.Width = 60;
            // 
            // frmHandOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmHandOver";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmHandOver_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label POScannedLbl;
        private System.Windows.Forms.Label DeliveredToLbl;
        private System.Windows.Forms.Label BroughtByLbl;
        private System.Windows.Forms.Label POLbl;
        private System.Windows.Forms.Label DeliveredToScannedLbl;
        private System.Windows.Forms.Label BroughtByScannedLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
    }
}