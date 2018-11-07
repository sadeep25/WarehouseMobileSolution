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
    public partial class frmBinToBin : Form
    {
        private BarcodeScanner barcodeScanner = null;
        private EventHandler myReadNotifyHandler = null;
        private EventHandler myStatusNotifyHandler = null;

        // The flag to track whether the reader has been initialized or not.
        private bool isReaderInitiated = false;
        private bool isBinFromScaned = false;
        private List<string> selectedWebsToMove = null;
        public Form RefToMenu { get; set; }
        private string binTo = "";

        public frmBinToBin()
        {
            InitializeComponent();
        }

        private void frmBinToBin_Load(object sender, EventArgs e)
        {
            LocadScanner();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Successfully Saved", "Caption", 1000);
            this.UnloadScanner();
            this.RefToMenu.Show();
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
        /// <summary>
        /// Status notification handler.
        /// </summary>
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

        /// <summary>
        /// Handle data from the reader. Used in the scan mode.
        /// </summary>
        private void HandleData(Symbol.Barcode.ReaderData TheReaderData)
        {
            //write handling logic//
            if (!isBinFromScaned)
            {
                using (var form = new frmWebsDialog())
                {
                    form.BinNumber = TheReaderData.Text;
                    lblBinScanFrom.Text = TheReaderData.Text;
                    lblBinFrom.Visible = true;
                    lblBinScanFrom.Visible = true;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        selectedWebsToMove = form.SelectedWebs;
                        LoadWebList(selectedWebsToMove);
                        isBinFromScaned = true;
                        lblBinToBinStatus.Text = "[Scan the bin to move selected webs]";
                        AutoClosingMessageBox.Show("Successfully Saved", "Caption", 1000);
                        this.barcodeScanner.StartRead(false);
                    }

                }
            }
            else
            {
                binTo = TheReaderData.Text;
                lblBinTo.Visible = true;
                lblBinScanTo.Text = TheReaderData.Text;
                lblBinScanTo.Visible = true;
                lblBinToBinStatus.Text = "[Confirm action]";
                btnMove.Enabled = true;
            }

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
     
        private void LoadWebList(List<string> selectedWebs)
        {
            foreach (var item in selectedWebs)
            {
                ListViewItem lv = new ListViewItem(item);
                lvWebs.Items.Add(lv);
            }
        }

        private void UnloadScanner()
        {
            barcodeScanner.DetachReadNotify();
            barcodeScanner.DetachStatusNotify();
            barcodeScanner.TermReader();
        }

        private void frmBinToBin_Closing(object sender, CancelEventArgs e)
        {
            this.UnloadScanner();
            this.RefToMenu.Show();
        }
    }
}