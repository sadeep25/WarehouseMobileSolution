﻿namespace Warehouse__Mobile__Solution_PL
{
    partial class frmPutIntoBin
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.webLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.binLbl = new System.Windows.Forms.Label();
            this.scanWebLbl = new System.Windows.Forms.Label();
            this.scanBinLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Put Into Bin";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(56, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.Text = "[Scan the web to store ]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // webLbl
            // 
            this.webLbl.Location = new System.Drawing.Point(3, 21);
            this.webLbl.Name = "webLbl";
            this.webLbl.Size = new System.Drawing.Size(47, 20);
            this.webLbl.Text = "Web";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scanBinLbl);
            this.panel1.Controls.Add(this.scanWebLbl);
            this.panel1.Controls.Add(this.binLbl);
            this.panel1.Controls.Add(this.webLbl);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 100);
            // 
            // binLbl
            // 
            this.binLbl.Location = new System.Drawing.Point(3, 58);
            this.binLbl.Name = "binLbl";
            this.binLbl.Size = new System.Drawing.Size(47, 20);
            this.binLbl.Text = "Bin";
            // 
            // scanWebLbl
            // 
            this.scanWebLbl.Location = new System.Drawing.Point(36, 21);
            this.scanWebLbl.Name = "scanWebLbl";
            this.scanWebLbl.Size = new System.Drawing.Size(195, 20);
            // 
            // scanBinLbl
            // 
            this.scanBinLbl.Location = new System.Drawing.Point(36, 58);
            this.scanBinLbl.Name = "scanBinLbl";
            this.scanBinLbl.Size = new System.Drawing.Size(195, 20);
            // 
            // frmPutIntoBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 267);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "frmPutIntoBin";
            this.Text = "Warehouse Mobile Solution";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label webLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label scanBinLbl;
        private System.Windows.Forms.Label scanWebLbl;
        private System.Windows.Forms.Label binLbl;
    }
}