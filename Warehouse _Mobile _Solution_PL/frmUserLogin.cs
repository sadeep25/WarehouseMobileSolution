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
    public partial class frmUserLogin : Form
    {
        private BarcodeScanner barcodeScanner = null;
        private EventHandler myReadNotifyHandler = null;
        private EventHandler myStatusNotifyHandler = null;

        // The flag to track whether the reader has been initialized or not.
        private bool isReaderInitiated = false;

        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void frmUserLogin_Load(object sender, EventArgs e)
        {
            LoadScanner();
        }

        private void frmUserLogin_Closing(object sender, CancelEventArgs e)
        {
            UnloadScanner();
            Application.Exit();
        }

        /// <summary>
        /// Read notification handler.
        /// </summary>
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
            if ("4792132408859" == TheReaderData.Text)
            {
                //MessageBox.Show("Invalid User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                frmMessageBox form = new frmMessageBox(MessageTypes.Error, "Invalid barcode, Please try again","Login error");
                form.ShowDialog();
                this.barcodeScanner.StartRead(false);
            }
            else
            {
                UnloadScanner();
                frmMenu menu = new frmMenu();
                menu.RefToUserLogin = this;
                menu.userBarcode = TheReaderData.Text;
                menu.Show();
                this.Hide();
            }
        }

        private void LoadScanner()
        {
            // Initialize the ScanSampleAPI reference.
            this.barcodeScanner = new BarcodeScanner();

            this.isReaderInitiated = this.barcodeScanner.InitReader();

            if (!(this.isReaderInitiated))// If the reader has not been initialized
            {
                // Display a message & exit the application.
                //MessageBox.Show("Fail to initialize barcode reader");
                frmMessageBox form = new frmMessageBox(MessageTypes.Error, "Fail to initialize barcode reader", "Error");
                form.ShowDialog();
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

        private void UnloadScanner()
        {
            barcodeScanner.DetachReadNotify();
            barcodeScanner.DetachStatusNotify();
            barcodeScanner.TermReader();
        }
    }
}