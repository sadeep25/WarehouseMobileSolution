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
            this.lblIssueWebsHeader = new System.Windows.Forms.Label();
            this.lblIssueWebsProductionOrder = new System.Windows.Forms.Label();
            this.lblIssueWebProductionOrderScan = new System.Windows.Forms.Label();
            this.lvWebs = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnIssueWebsIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIssueWebsHeader
            // 
            this.lblIssueWebsHeader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueWebsHeader.Location = new System.Drawing.Point(3, 13);
            this.lblIssueWebsHeader.Name = "lblIssueWebsHeader";
            this.lblIssueWebsHeader.Size = new System.Drawing.Size(100, 20);
            this.lblIssueWebsHeader.Text = "Issue Webs";
            // 
            // lblIssueWebsProductionOrder
            // 
            this.lblIssueWebsProductionOrder.Location = new System.Drawing.Point(3, 45);
            this.lblIssueWebsProductionOrder.Name = "lblIssueWebsProductionOrder";
            this.lblIssueWebsProductionOrder.Size = new System.Drawing.Size(115, 20);
            this.lblIssueWebsProductionOrder.Text = "Production Order:";
            // 
            // lblIssueWebProductionOrderScan
            // 
            this.lblIssueWebProductionOrderScan.Location = new System.Drawing.Point(107, 45);
            this.lblIssueWebProductionOrderScan.Name = "lblIssueWebProductionOrderScan";
            this.lblIssueWebProductionOrderScan.Size = new System.Drawing.Size(130, 20);
            this.lblIssueWebProductionOrderScan.Text = "[Scan PO sticker]";
            // 
            // lvWebs
            // 
            this.lvWebs.CheckBoxes = true;
            this.lvWebs.Columns.Add(this.columnHeader1);
            this.lvWebs.Columns.Add(this.columnHeader2);
            this.lvWebs.Columns.Add(this.columnHeader3);
            this.lvWebs.FullRowSelect = true;
            this.lvWebs.Location = new System.Drawing.Point(3, 83);
            this.lvWebs.Name = "lvWebs";
            this.lvWebs.Size = new System.Drawing.Size(234, 124);
            this.lvWebs.TabIndex = 3;
            this.lvWebs.View = System.Windows.Forms.View.Details;
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
            // btnIssueWebsIssue
            // 
            this.btnIssueWebsIssue.Location = new System.Drawing.Point(155, 228);
            this.btnIssueWebsIssue.Name = "btnIssueWebsIssue";
            this.btnIssueWebsIssue.Size = new System.Drawing.Size(72, 20);
            this.btnIssueWebsIssue.TabIndex = 4;
            this.btnIssueWebsIssue.Text = "Issue";
            this.btnIssueWebsIssue.Click += new System.EventHandler(this.btnIssueWebsIssue_Click);
            // 
            // frmIssueWebs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.btnIssueWebsIssue);
            this.Controls.Add(this.lvWebs);
            this.Controls.Add(this.lblIssueWebProductionOrderScan);
            this.Controls.Add(this.lblIssueWebsProductionOrder);
            this.Controls.Add(this.lblIssueWebsHeader);
            this.Name = "frmIssueWebs";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmIssueWebs_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmIssueWebs_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIssueWebsHeader;
        private System.Windows.Forms.Label lblIssueWebsProductionOrder;
        private System.Windows.Forms.Label lblIssueWebProductionOrderScan;
        private System.Windows.Forms.ListView lvWebs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnIssueWebsIssue;
    }
}