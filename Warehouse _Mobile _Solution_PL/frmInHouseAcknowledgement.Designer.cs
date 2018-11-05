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
            this.InHouselbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InHouselbl
            // 
            this.InHouselbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.InHouselbl.Location = new System.Drawing.Point(13, 25);
            this.InHouselbl.Name = "InHouselbl";
            this.InHouselbl.Size = new System.Drawing.Size(180, 20);
            this.InHouselbl.Text = "In-House-acknowledgment";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(13, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(214, 166);
            this.listView1.TabIndex = 1;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Receive to Warehouse";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInHouseAcknowledgement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.InHouselbl);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "frmInHouseAcknowledgement";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmInHouseAcknowledgement_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmInHouseAcknowledgement_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InHouselbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
    }
}