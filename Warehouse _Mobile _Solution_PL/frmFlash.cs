using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Warehouse__Mobile__Solution_PL
{
    public partial class frmFlash : Form
    {
        public int timeLeft { get; set; }
        public frmFlash()
        {
            InitializeComponent();
        }

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;

            }
            else
            {
                flashTimer.Enabled = false;
                new frmUserLogin().Show();
                this.Hide();
            }
        }

        private void frmFlash_Load(object sender, EventArgs e)
        {
            //the timer is now going to start
            timeLeft = 10;
            flashTimer.Enabled=true;
      
        }
    }
}