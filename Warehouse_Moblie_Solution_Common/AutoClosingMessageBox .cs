using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Warehouse_Moblie_Solution_Common
{
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;

        AutoClosingMessageBox(string text, string caption, int timeout, MessageTypes type)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            frmMessageBox form = new frmMessageBox(type, text, caption);
            form.ShowDialog();
        }

        public static void Show(string text, string caption, int timeout, MessageTypes type)
        {
            new AutoClosingMessageBox(text, caption, timeout, type);
        }

        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow(null, _caption);
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }

        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("coredll.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("coredll.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}
