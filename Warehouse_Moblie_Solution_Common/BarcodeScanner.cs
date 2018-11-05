using System;
using System.Windows.Forms;

namespace Warehouse_Moblie_Solution_Common
{

    public class BarcodeScanner
    {
        private Symbol.Barcode.Reader myReader = null;
        private Symbol.Barcode.ReaderData myReaderData = null;
        private System.EventHandler myReadNotifyHandler = null;
        private System.EventHandler myStatusNotifyHandler = null;

        internal bool isBackground = false; //The flag used to track whether the application is in background or not (in foreground).

        /// <summary>
        /// Initialize the reader.
        /// </summary>
        public bool InitReader()
        {
            // If the reader is already initialized then fail the initialization.
            if (myReader != null)
            {
                return false;
            }
            else // Else initialize the reader.
            {
                try
                {
                    // Get the device selected by the user.
                    Symbol.Generic.Device MyDevice =
                        Symbol.StandardForms.SelectDevice.Select(
                        Symbol.Barcode.Device.Title,
                        Symbol.Barcode.Device.AvailableDevices);

                    if (MyDevice == null)
                    {
                        MessageBox.Show(Resources.GetString("NoDeviceSelected"), Resources.GetString("SelectDevice"));
                        return false;
                    }

                    // Create the reader, based on selected device.
                    myReader = new Symbol.Barcode.Reader(MyDevice);

                    // Create the reader data.
                    myReaderData = new Symbol.Barcode.ReaderData(
                        Symbol.Barcode.ReaderDataTypes.Text,
                        Symbol.Barcode.ReaderDataLengths.MaximumLabel);

                    // Enable the Reader.
                    myReader.Actions.Enable();

                    // In this sample, we are setting the aim type to trigger. 
                    switch (myReader.ReaderParameters.ReaderType)
                    {
                        case Symbol.Barcode.READER_TYPE.READER_TYPE_IMAGER:
                            myReader.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Symbol.Barcode.AIM_TYPE.AIM_TYPE_TRIGGER;
                            break;
                        case Symbol.Barcode.READER_TYPE.READER_TYPE_LASER:
                            myReader.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Symbol.Barcode.AIM_TYPE.AIM_TYPE_TRIGGER;
                            break;
                        case Symbol.Barcode.READER_TYPE.READER_TYPE_CONTACT:
                            // AimType is not supported by the contact readers.
                            break;
                    }
                    myReader.Actions.SetParameters();


                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show(Resources.GetString("InitReader") + "\n" +
                        Resources.GetString("OperationFailure") + "\n" + ex.Message +
                        "\n" +
                        Resources.GetString("Result") + " = " + (Symbol.Results)((uint)ex.Result)
                        );

                    return false;
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show(Resources.GetString("InitReader") + "\n" +
                        Resources.GetString("InvalidRequest") + "\n" +
                        ex.Message);

                    return false;
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show(Resources.GetString("InitReader") + "\n" +
                        Resources.GetString("InvalidIndexer") + "\n" +
                        ex.Message);

                    return false;
                };

                return true;
            }
        }

        /// <summary>
        /// Stop reading and disable/close the reader.
        /// </summary>
        public void TermReader()
        {
            // If we have a reader
            if (myReader != null)
            {
                try
                {
                    // stop all the notifications.
                    StopRead();

                    //Detach all the notification handler if the user has not done it already.
                    DetachReadNotify();
                    DetachStatusNotify();

                    // Disable the reader.
                    myReader.Actions.Disable();

                    // Free it up.
                    myReader.Dispose();

                    // Make the reference null.
                    myReader = null;
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show(Resources.GetString("TermReader") + "\n" +
                        Resources.GetString("OperationFailure") + "\n" + ex.Message +
                        "\n" +
                        Resources.GetString("Result") + " = " + (Symbol.Results)((uint)ex.Result)
                        );
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show(Resources.GetString("TermReader") + "\n" +
                        Resources.GetString("InvalidRequest") + "\n" +
                        ex.Message);
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show(Resources.GetString("TermReader") + "\n" +
                        Resources.GetString("InvalidIndexer") + "\n" +
                        ex.Message);
                };
            }

            // After disposing the reader, dispose the reader data. 
            if (myReaderData != null)
            {
                try
                {
                    // Free it up.
                    myReaderData.Dispose();

                    // Make the reference null.
                    myReaderData = null;
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show(Resources.GetString("TermReader") + "\n" +
                        Resources.GetString("OperationFailure") + "\n" + ex.Message +
                        "\n" +
                        Resources.GetString("Result") + " = " + (Symbol.Results)((uint)ex.Result)
                        );
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show(Resources.GetString("TermReader") + "\n" +
                        Resources.GetString("InvalidRequest") + "\n" +
                        ex.Message);
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show(Resources.GetString("TermReader") + "\n" +
                        Resources.GetString("InvalidIndexer") + "\n" +
                        ex.Message);
                };
            }
        }

        /// <summary>
        /// Start a read on the reader.
        /// </summary>
        public void StartRead(bool toggleSoftTrigger)
        {
            // If we have both a reader and a reader data
            if ((myReader != null) &&
                (myReaderData != null) && (isBackground == false))

                try
                {
                    if (!myReaderData.IsPending)
                    {
                        // Submit a read.
                        myReader.Actions.Read(myReaderData);

                        if (toggleSoftTrigger && myReader.Info.SoftTrigger == false)
                        {
                            myReader.Info.SoftTrigger = true;
                        }
                    }
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show(Resources.GetString("StartRead") + "\n" +
                        Resources.GetString("OperationFailure") + "\n" + ex.Message +
                        "\n" +
                        Resources.GetString("Result") + " = " + (Symbol.Results)((uint)ex.Result));
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show(Resources.GetString("StartRead") + "\n" +
                        Resources.GetString("InvalidRequest") + "\n" +
                        ex.Message);

                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show(Resources.GetString("StartRead") + "\n" +
                        Resources.GetString("InvalidIndexer") + "\n" +
                        ex.Message);

                };
        }

        /// <summary>
        /// Stop all reads on the reader.
        /// </summary>
        public void StopRead()
        {
            //If we have a reader
            if (myReader != null)
            {
                try
                {
                    // Flush (Cancel all pending reads).
                    if (myReader.Info.SoftTrigger == true)
                    {
                        myReader.Info.SoftTrigger = false;
                    }
                    myReader.Actions.Flush();
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show(Resources.GetString("StopRead") + "\n" +
                        Resources.GetString("OperationFailure") + "\n" + ex.Message +
                        "\n" +
                        Resources.GetString("Result") + " = " + (Symbol.Results)((uint)ex.Result)
                        );
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show(Resources.GetString("StopRead") + "\n" +
                        Resources.GetString("InvalidRequest") + "\n" +
                        ex.Message);
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show(Resources.GetString("StopRead") + "\n" +
                        Resources.GetString("InvalidIndexer") + "\n" +
                        ex.Message);
                };
            }
        }

        /// <summary>
        /// Provides the access to the Symbol.Barcode.Reader reference.
        /// The user can use this reference for his additional Reader - related operations.
        /// </summary>
        public Symbol.Barcode.Reader Reader
        {
            get
            {
                return myReader;
            }
        }

        /// <summary>
        /// Attach a ReadNotify handler.
        /// </summary>
        public void AttachReadNotify(System.EventHandler ReadNotifyHandler)
        {
            // If we have a reader
            if (myReader != null)
            {
                // Attach the read notification handler.
                myReader.ReadNotify += ReadNotifyHandler;
                myReadNotifyHandler = ReadNotifyHandler;
            }

        }

        /// <summary>
        /// Detach the ReadNotify handler.
        /// </summary>
        public void DetachReadNotify()
        {
            if ((myReader != null) && (myReadNotifyHandler != null))
            {
                // Detach the read notification handler.
                myReader.ReadNotify -= myReadNotifyHandler;
                myReadNotifyHandler = null;
            }
        }

        /// <summary>
        /// Attach a StatusNotify handler.
        /// </summary>
        public void AttachStatusNotify(System.EventHandler StatusNotifyHandler)
        {
            // If we have a reader
            if (myReader != null)
            {
                // Attach status notification handler.
                myReader.StatusNotify += StatusNotifyHandler;
                myStatusNotifyHandler = StatusNotifyHandler;
            }
        }

        /// <summary>
        /// Detach a StatusNotify handler.
        /// </summary>
        public void DetachStatusNotify()
        {
            // If we have a reader registered for receiving the status notifications
            if ((myReader != null) && (myStatusNotifyHandler != null))
            {
                // Detach the status notification handler.
                myReader.StatusNotify -= myStatusNotifyHandler;
                myStatusNotifyHandler = null;
            }
        }

    }

}
