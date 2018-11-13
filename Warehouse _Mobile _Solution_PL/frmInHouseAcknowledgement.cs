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
    public partial class frmInHouseAcknowledgement : Form
    {
        private BarcodeScanner barcodeScanner = null;
        private EventHandler myReadNotifyHandler = null;
        private EventHandler myStatusNotifyHandler = null;

        // The flag to track whether the reader has been initialized or not.
        private bool isReaderInitiated = false;
        public Form RefToMenu { get; set; }

        public frmInHouseAcknowledgement()
        {
            InitializeComponent();
        }

        private void frmInHouseAcknowledgement_Load(object sender, EventArgs e)
        {
            LoadScanner();
        }

        private void frmInHouseAcknowledgement_Closing(object sender, CancelEventArgs e)
        {

            if (lvInHouseAcknowledgement.Items.Count > 0)
            {
                frmMessageBox form = new frmMessageBox(MessageTypes.Warning, "Are you sure you want to close this transaction", "Warnning");
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.UnloadScanner();
                    this.RefToMenu.Show();
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                this.UnloadScanner();
                RefToMenu.Show();
                this.Close();
            }
        }

        private void lvInHouseAcknowledgement_ItemActivate(object sender, EventArgs e)
        {
            // var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            frmMessageBox form = new frmMessageBox(MessageTypes.Warning, "Are you sure to delete this item ?", "Warnnig!");
            var confirmResult = form.ShowDialog();
            if (confirmResult == DialogResult.Yes)
            {
                for (int i = lvInHouseAcknowledgement.Items.Count - 1; i >= 0; i--)
                {
                    if (lvInHouseAcknowledgement.Items[i].Selected)
                    {
                        lvInHouseAcknowledgement.Items.Remove(lvInHouseAcknowledgement.Items[i]);
                    }
                }
            }
            else
            {
                for (int i = lvInHouseAcknowledgement.Items.Count - 1; i >= 0; i--)
                {
                    if (lvInHouseAcknowledgement.Items[i].Selected)
                    {
                        lvInHouseAcknowledgement.Items[i].Selected = false;
                    }
                }
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
            if (this.IsDuplicate(TheReaderData.Text))
            {
                frmMessageBox form = new frmMessageBox(MessageTypes.Error, "This web is already scanned", "Duplicate");
                form.ShowDialog();
                this.barcodeScanner.StartRead(false);
            }
            else
            {
                if ("4792132408859" == TheReaderData.Text)
                {
                    //error barcode
                    frmMessageBox form = new frmMessageBox(MessageTypes.Error, "This is not a valid web", "Invalid Web");
                    form.ShowDialog();
                    this.barcodeScanner.StartRead(false);
                }
                else
                {
                    var Text = TheReaderData.Text;
                    ListViewItem lv = new ListViewItem(Text);
                    this.barcodeScanner.StartRead(false);
                    lv.SubItems.Add("Material");
                    lv.SubItems.Add("Weight");
                    lvInHouseAcknowledgement.Items.Add(lv);
                }
            }
        }

        private void btnReceiveToWarehouse_Click(object sender, EventArgs e)
        {
            if (lvInHouseAcknowledgement.Items.Count > 0)
            {
                frmMessageBox form = new frmMessageBox(MessageTypes.Success, "Successfully transfered", "Confirmation");
                form.ShowDialog();
                this.UnloadScanner();
                RefToMenu.Show();
                this.Close();
            }
            else
            {
                frmMessageBox form = new frmMessageBox(MessageTypes.Info, "Please Scan webs to receive", "Info");
                form.ShowDialog();
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
                this.barcodeScanner.StartRead(true);
            }
        }

        private bool IsDuplicate(string barcode)
        {
            for (int i = lvInHouseAcknowledgement.Items.Count - 1; i >= 0; i--)
            {
                if (lvInHouseAcknowledgement.Items[i].Text == barcode)
                {
                    return true;
                }
            }
            return false;
        }

        private void UnloadScanner()
        {
            barcodeScanner.DetachReadNotify();
            barcodeScanner.DetachStatusNotify();
            barcodeScanner.TermReader();
        }
    }
}