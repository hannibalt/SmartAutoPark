using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMach.Views
{
    public partial class SCR_Register : UserControl
    {
        public SCR_Register()
        {
            InitializeComponent();
        }

        private void SCR_Register_Load(object sender, EventArgs e)
        {

        }

        private void cmb_pay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pay.SelectedIndex == 0)
            {
                lblcost.Text = "120";
                btntlicon.Visible = true;
            }
            else if (cmb_pay.SelectedIndex == 1)
            {
                lblcost.Text = "150";
                btntlicon.Visible = true;

            }
            else if(cmb_pay.SelectedIndex==2)
            {
                lblcost.Text = "200";
                btntlicon.Visible = true;

            }
        }
    }
}
