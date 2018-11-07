namespace Warehouse__Mobile__Solution_PL
{
    partial class frmInHouseAcknowledgement
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
            this.lblInHouseAcknowledgment = new System.Windows.Forms.Label();
            this.lvInHouseAcknowledgement = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnReceiveToWarehouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInHouseAcknowledgment
            // 
            this.lblInHouseAcknowledgment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblInHouseAcknowledgment.Location = new System.Drawing.Point(13, 25);
            this.lblInHouseAcknowledgment.Name = "lblInHouseAcknowledgment";
            this.lblInHouseAcknowledgment.Size = new System.Drawing.Size(180, 20);
            this.lblInHouseAcknowledgment.Text = "In-House-acknowledgment";
            // 
            // lvInHouseAcknowledgement
            // 
            this.lvInHouseAcknowledgement.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvInHouseAcknowledgement.Columns.Add(this.columnHeader1);
            this.lvInHouseAcknowledgement.Columns.Add(this.columnHeader2);
            this.lvInHouseAcknowledgement.Columns.Add(this.columnHeader3);
            this.lvInHouseAcknowledgement.FullRowSelect = true;
            this.lvInHouseAcknowledgement.Location = new System.Drawing.Point(13, 48);
            this.lvInHouseAcknowledgement.Name = "lvInHouseAcknowledgement";
            this.lvInHouseAcknowledgement.Size = new System.Drawing.Size(214, 166);
            this.lvInHouseAcknowledgement.TabIndex = 1;
            this.lvInHouseAcknowledgement.View = System.Windows.Forms.View.Details;
            this.lvInHouseAcknowledgement.ItemActivate += new System.EventHandler(this.lvInHouseAcknowledgement_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Batch No";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Material";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Weight";
            this.columnHeader3.Width = 56;
            // 
            // btnReceiveToWarehouse
            // 
            this.btnReceiveToWarehouse.Location = new System.Drawing.Point(77, 233);
            this.btnReceiveToWarehouse.Name = "btnReceiveToWarehouse";
            this.btnReceiveToWarehouse.Size = new System.Drawing.Size(150, 20);
            this.btnReceiveToWarehouse.TabIndex = 3;
            this.btnReceiveToWarehouse.Text = "Receive to Warehouse";
            this.btnReceiveToWarehouse.Click += new System.EventHandler(this.btnReceiveToWarehouse_Click);
            // 
            // frmInHouseAcknowledgement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.btnReceiveToWarehouse);
            this.Controls.Add(this.lvInHouseAcknowledgement);
            this.Controls.Add(this.lblInHouseAcknowledgment);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "frmInHouseAcknowledgement";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmInHouseAcknowledgement_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmInHouseAcknowledgement_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInHouseAcknowledgment;
        private System.Windows.Forms.ListView lvInHouseAcknowledgement;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnReceiveToWarehouse;
    }
}