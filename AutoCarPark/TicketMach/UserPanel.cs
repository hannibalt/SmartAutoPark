using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMach
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            scR_Register1.Visible = true;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            scR_Register1.Visible = false;
             

        }

        private void scR_Register1_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

        }
    }
}
