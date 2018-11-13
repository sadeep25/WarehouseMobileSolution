using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Warehouse_Moblie_Solution_Common;

namespace Warehouse__Mobile__Solution_PL
{
    public partial class frmPutIntoBin : Form
    {
        private BarcodeScanner barcodeScanner = null;
        private EventHandler myReadNotifyHandler = null;
        private EventHandler myStatusNotifyHandler = null;

        // The flag to track whether the reader has been initialized or not.
        private bool isReaderInitiated = false;
        private bool isWebScaned = false;
        public Form RefToMenu { get; set; }

        public frmPutIntoBin()
        {
            InitializeComponent();
        }

        private void frmPutIntoBin_Load(object sender, EventArgs e)
        {
            this.LocadScanner();
        }

        private void LocadScanner()
        {
            // Initialize the ScanSampleAPI reference.
            this.barcodeScanner = new BarcodeScanner();

            this.isReaderInitiated = this.barcodeScanner.InitReader();

            if (!(this.isReaderInitiated))// If the reader has not been initialized
            {
                // Display a message & exit the application.
                MessageBox.Show("Fail to initialize barcode reader");
                Application.Exit();
            }
            else // If the reader has been initialized
            {
                // Clear the statusbar where subsequent status information would be displayed.
                //statusBar.Text = "";
                // Attach a status natification handler.
                this.myReadNotifyHandler = new EventHandler(myReader_ReadNotify);
                barcodeScanner.AttachReadNotify(myReadNotifyHandler);
                //this.myStatusNotifyHandler = new EventHandler(myReader_StatusNotify);
                //barcodeScanner.AttachStatusNotify(myStatusNotifyHandler);
                this.barcodeScanner.StartRead(false);
            }
        }
        private void myReader_ReadNotify(object Sender, EventArgs e)
        {
            // Checks if the Invoke method is required because the ReadNotify delegate is called by a different thread
            if (this.InvokeRequired)
            {
                // Executes the ReadNotify delegate on the main thread
                this.Invoke(myReadNotifyHandler, new object[] { Sender, e });
            }
            else
            {
                // Get ReaderData
                Symbol.Barcode.ReaderData TheReaderData = this.barcodeScanner.Reader.GetNextReaderData();
                if (TheReaderData.Result == Symbol.Results.SUCCESS)
                {
                    HandleData(TheReaderData);
                }
            }
        }
        private void myReader_StatusNotify(object Sender, EventArgs e)
        {
            // Checks if the Invoke method is required because the StatusNotify delegate is called by a different thread
            if (this.InvokeRequired)
            {
                // Executes the StatusNotify delegate on the main thread
                this.Invoke(myStatusNotifyHandler, new object[] { Sender, e });
            }
            else
            {
                // Get ReaderData
                Symbol.Barcode.BarcodeStatus TheStatusData = this.barcodeScanner.Reader.GetNextStatus();
            }
        }
        private void HandleData(Symbol.Barcode.ReaderData TheReaderData)
        {
            //write handling logic//
            if (!isWebScaned)
            {
                //check is this a valid web
                if ("4792132408859" == TheReaderData.Text)
                {
                    frmMessageBox form = new frmMessageBox(MessageTypes.Error, "Invalid web, Please try again", "Scan Error");
                    form.ShowDialog();
                    this.barcodeScanner.StartRead(false);
                }
                else
                {
                    lblScanWeb.Text = TheReaderData.Text;
                    lblPutIntoBinStatus.Text = "[Scan a bin to store]";
                    isWebScaned = true;
                    this.barcodeScanner.StartRead(false);
                }
            }
            else
            {
                if ("4792132408859" == TheReaderData.Text)
                {
                    frmMessageBox form = new frmMessageBox(MessageTypes.Error, "Invalid bin, Please try again", "Scan Error");
                    form.ShowDialog();
                    this.barcodeScanner.StartRead(false);
                }
                else
                {
                    lblScanBin.Text = TheReaderData.Text;
                    lblPutIntoBinStatus.Text = "[Click save to confirm]";
                    btnPutIntoBinSave.Enabled = true;
                }


            }

        }

        private void btnPutIntoBinSave_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Successfully Saved", "Caption", 1000, MessageTypes.Success);
            lblPutIntoBinStatus.Text = "[Scan a Web]";
            this.lblScanWeb.Text = "";
            this.lblScanBin.Text = "";
            this.isWebScaned = false;
            btnPutIntoBinSave.Enabled = false;
            this.barcodeScanner.StartRead(false);
            //this.Refresh();
        }

        private void frmPutIntoBin_Closing(object sender, CancelEventArgs e)
        {
            if (this.lblScanBin.Text != "" || this.lblScanWeb.Text != "")
            {
                frmMessageBox form = new frmMessageBox(MessageTypes.Warning, "Are you sure you want to close this transaction", "Warnning");
                var result=form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.UnloadScanner();
                    this.RefToMenu.Show();
                }
                else {
                    e.Cancel=true;
                }
            }
            else
            {
                this.UnloadScanner();
                this.RefToMenu.Show();
            }
        }

        private void UnloadScanner()
        {
            barcodeScanner.DetachReadNotify();
            barcodeScanner.DetachStatusNotify();
            barcodeScanner.TermReader();
        }
    }
}