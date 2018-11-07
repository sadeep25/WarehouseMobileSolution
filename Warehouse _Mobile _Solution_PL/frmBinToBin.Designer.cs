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
            this.lblBinToBinHeader = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblBinToBinStatus = new System.Windows.Forms.Label();
            this.lvWebs = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lblBinFrom = new System.Windows.Forms.Label();
            this.lblBinTo = new System.Windows.Forms.Label();
            this.lblBinScanFrom = new System.Windows.Forms.Label();
            this.lblBinScanTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBinToBinHeader
            // 
            this.lblBinToBinHeader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblBinToBinHeader.Location = new System.Drawing.Point(3, 22);
            this.lblBinToBinHeader.Name = "lblBinToBinHeader";
            this.lblBinToBinHeader.Size = new System.Drawing.Size(100, 20);
            this.lblBinToBinHeader.Text = "Bin to Bin";
            // 
            // btnMove
            // 
            this.btnMove.Enabled = false;
            this.btnMove.Location = new System.Drawing.Point(55, 206);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(125, 27);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Move";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblBinToBinStatus
            // 
            this.lblBinToBinStatus.Location = new System.Drawing.Point(0, 236);
            this.lblBinToBinStatus.Name = "lblBinToBinStatus";
            this.lblBinToBinStatus.Size = new System.Drawing.Size(234, 20);
            this.lblBinToBinStatus.Text = "[Scan the bin where webs stored  in]";
            this.lblBinToBinStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvWebs
            // 
            this.lvWebs.Columns.Add(this.columnHeader1);
            this.lvWebs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvWebs.Location = new System.Drawing.Point(41, 99);
            this.lvWebs.Name = "lvWebs";
            this.lvWebs.Size = new System.Drawing.Size(155, 101);
            this.lvWebs.TabIndex = 3;
            this.lvWebs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Webs";
            this.columnHeader1.Width = 154;
            // 
            // lblBinFrom
            // 
            this.lblBinFrom.Location = new System.Drawing.Point(17, 42);
            this.lblBinFrom.Name = "lblBinFrom";
            this.lblBinFrom.Size = new System.Drawing.Size(70, 20);
            this.lblBinFrom.Text = "Bin (from)";
            this.lblBinFrom.Visible = false;
            // 
            // lblBinTo
            // 
            this.lblBinTo.Location = new System.Drawing.Point(17, 67);
            this.lblBinTo.Name = "lblBinTo";
            this.lblBinTo.Size = new System.Drawing.Size(70, 20);
            this.lblBinTo.Text = "Bin (to)";
            this.lblBinTo.Visible = false;
            // 
            // lblBinScanFrom
            // 
            this.lblBinScanFrom.Location = new System.Drawing.Point(81, 42);
            this.lblBinScanFrom.Name = "lblBinScanFrom";
            this.lblBinScanFrom.Size = new System.Drawing.Size(156, 20);
            this.lblBinScanFrom.Text = "label5";
            this.lblBinScanFrom.Visible = false;
            // 
            // lblBinScanTo
            // 
            this.lblBinScanTo.Location = new System.Drawing.Point(81, 67);
            this.lblBinScanTo.Name = "lblBinScanTo";
            this.lblBinScanTo.Size = new System.Drawing.Size(156, 20);
            this.lblBinScanTo.Text = "label6";
            this.lblBinScanTo.Visible = false;
            // 
            // frmBinToBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.lblBinScanTo);
            this.Controls.Add(this.lblBinScanFrom);
            this.Controls.Add(this.lblBinTo);
            this.Controls.Add(this.lblBinFrom);
            this.Controls.Add(this.lvWebs);
            this.Controls.Add(this.lblBinToBinStatus);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lblBinToBinHeader);
            this.Name = "frmBinToBin";
            this.Text = "Warehouse Mobile Solution";
            this.Load += new System.EventHandler(this.frmBinToBin_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmBinToBin_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBinToBinHeader;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label lblBinToBinStatus;
        private System.Windows.Forms.ListView lvWebs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblBinFrom;
        private System.Windows.Forms.Label lblBinTo;
        private System.Windows.Forms.Label lblBinScanFrom;
        private System.Windows.Forms.Label lblBinScanTo;
    }
}