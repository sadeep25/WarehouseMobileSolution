namespace Warehouse__Mobile__Solution_PL
{
    partial class frmIssueWebs
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
            this.issueWebsProductionOrderLbl = new System.Windows.Forms.Label();
            this.issueWebProductionOrderScanLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.issueWebsIssueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Issue Webs";
            // 
            // issueWebsProductionOrderLbl
            // 
            this.issueWebsProductionOrderLbl.Location = new System.Drawing.Point(3, 45);
            this.issueWebsProductionOrderLbl.Name = "issueWebsProductionOrderLbl";
            this.issueWebsProductionOrderLbl.Size = new System.Drawing.Size(115, 20);
            this.issueWebsProductionOrderLbl.Text = "Production Order:";
            // 
            // issueWebProductionOrderScanLbl
            // 
            this.issueWebProductionOrderScanLbl.Location = new System.Drawing.Point(107, 45);
            this.issueWebProductionOrderScanLbl.Name = "issueWebProductionOrderScanLbl";
            this.issueWebProductionOrderScanLbl.Size = new System.Drawing.Size(130, 20);
            this.issueWebProductionOrderScanLbl.Text = "[Scan PO sticker]";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 124);
            this.listView1.TabIndex = 3;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Web number";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bin Number";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Weight";
            this.columnHeader3.Width = 61;
            // 
            // issueWebsIssueBtn
            // 
            this.issueWebsIssueBtn.Location = new System.Drawing.Point(155, 228);
            this.issueWebsIssueBtn.Name = "issueWebsIssueBtn";
            this.issueWebsIssueBtn.Size = new System.Drawing.Size(72, 20);
            this.issueWebsIssueBtn.TabIndex = 4;
            this.issueWebsIssueBtn.Text = "Issue";
            this.issueWebsIssueBtn.Click += new System.EventHandler(this.issueWebsIssueBtn_Click);
            // 
            // frmIssueWebs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.issueWebsIssueBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.issueWebProductionOrderScanLbl);
            this.Controls.Add(this.issueWebsProductionOrderLbl);
            this.Controls.Add(this.label1);
            this.Name = "frmIssueWebs";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmIssueWebs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label issueWebsProductionOrderLbl;
        private System.Windows.Forms.Label issueWebProductionOrderScanLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button issueWebsIssueBtn;
    }
}