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
            this.lblHandOverToFinishingDept = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDeliveredToScanned = new System.Windows.Forms.Label();
            this.lblBroughtByScanned = new System.Windows.Forms.Label();
            this.lblProductionOrderScanned = new System.Windows.Forms.Label();
            this.lblDeliveredTo = new System.Windows.Forms.Label();
            this.lblBroughtBy = new System.Windows.Forms.Label();
            this.lblProductionOrder = new System.Windows.Forms.Label();
            this.lvWebs = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHandOverToFinishingDept
            // 
            this.lblHandOverToFinishingDept.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblHandOverToFinishingDept.Location = new System.Drawing.Point(3, 12);
            this.lblHandOverToFinishingDept.Name = "lblHandOverToFinishingDept";
            this.lblHandOverToFinishingDept.Size = new System.Drawing.Size(190, 20);
            this.lblHandOverToFinishingDept.Text = "Hand Over to Finishing Dept";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDeliveredToScanned);
            this.panel1.Controls.Add(this.lblBroughtByScanned);
            this.panel1.Controls.Add(this.lblProductionOrderScanned);
            this.panel1.Controls.Add(this.lblDeliveredTo);
            this.panel1.Controls.Add(this.lblBroughtBy);
            this.panel1.Controls.Add(this.lblProductionOrder);
            this.panel1.Location = new System.Drawing.Point(15, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 71);
            // 
            // lblDeliveredToScanned
            // 
            this.lblDeliveredToScanned.Location = new System.Drawing.Point(90, 49);
            this.lblDeliveredToScanned.Name = "lblDeliveredToScanned";
            this.lblDeliveredToScanned.Size = new System.Drawing.Size(100, 20);
            // 
            // lblBroughtByScanned
            // 
            this.lblBroughtByScanned.Location = new System.Drawing.Point(90, 29);
            this.lblBroughtByScanned.Name = "lblBroughtByScanned";
            this.lblBroughtByScanned.Size = new System.Drawing.Size(100, 20);
            // 
            // lblProductionOrderScanned
            // 
            this.lblProductionOrderScanned.Location = new System.Drawing.Point(90, 9);
            this.lblProductionOrderScanned.Name = "lblProductionOrderScanned";
            this.lblProductionOrderScanned.Size = new System.Drawing.Size(100, 20);
            // 
            // lblDeliveredTo
            // 
            this.lblDeliveredTo.Location = new System.Drawing.Point(3, 49);
            this.lblDeliveredTo.Name = "lblDeliveredTo";
            this.lblDeliveredTo.Size = new System.Drawing.Size(81, 20);
            this.lblDeliveredTo.Text = "Delivered To";
            // 
            // lblBroughtBy
            // 
            this.lblBroughtBy.Location = new System.Drawing.Point(3, 29);
            this.lblBroughtBy.Name = "lblBroughtBy";
            this.lblBroughtBy.Size = new System.Drawing.Size(81, 20);
            this.lblBroughtBy.Text = "Brought By";
            // 
            // lblProductionOrder
            // 
            this.lblProductionOrder.Location = new System.Drawing.Point(3, 9);
            this.lblProductionOrder.Name = "lblProductionOrder";
            this.lblProductionOrder.Size = new System.Drawing.Size(81, 20);
            this.lblProductionOrder.Text = "PO";
            // 
            // lvWebs
            // 
            this.lvWebs.Columns.Add(this.columnHeader1);
            this.lvWebs.Columns.Add(this.columnHeader2);
            this.lvWebs.Columns.Add(this.columnHeader3);
            this.lvWebs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvWebs.Location = new System.Drawing.Point(15, 112);
            this.lvWebs.Name = "lvWebs";
            this.lvWebs.Size = new System.Drawing.Size(207, 109);
            this.lvWebs.TabIndex = 3;
            this.lvWebs.View = System.Windows.Forms.View.Details;
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
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(76, 227);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(72, 20);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // frmHandOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lvWebs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHandOverToFinishingDept);
            this.Name = "frmHandOver";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmHandOver_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmHandOver_Closing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHandOverToFinishingDept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductionOrderScanned;
        private System.Windows.Forms.Label lblDeliveredTo;
        private System.Windows.Forms.Label lblBroughtBy;
        private System.Windows.Forms.Label lblProductionOrder;
        private System.Windows.Forms.Label lblDeliveredToScanned;
        private System.Windows.Forms.Label lblBroughtByScanned;
        private System.Windows.Forms.ListView lvWebs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnTransfer;
    }
}