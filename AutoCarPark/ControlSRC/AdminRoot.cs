using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSRC
{
    public partial class AdminRoot : Form
    {
        public AdminRoot()
        {
            InitializeComponent();
        }
        private void goMainScreen()
        {
            MainScreen ScreenTWO = new MainScreen();
            ScreenTWO.Show();
            this.Hide();

        }
        private void GoApprove()
        {
            ApproveScreen ScreenOne = new ApproveScreen();
            ScreenOne.Show();
            this.Hide();

        }
        private void btnGoCameraScreen_Click(object sender, EventArgs e)
        {
            goMainScreen();
        }

        private void btnPaymentScreen_Click(object sender, EventArgs e)
        {
            GoApprove();
        }
    }
}
