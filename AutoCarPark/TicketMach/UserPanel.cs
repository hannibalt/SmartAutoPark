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

        private void ClearPages()
        {
            lblnamesecond.Text = "";
            lblsurnamesecond.Text = "";
            lblcarplatesecond.Text = "";
            lblcostsecond.Text = "";
            lblleftday.Text = "";
            lblcarpark.Text = "";
            txt_name.Text = "";
            txt_surname.Text = "";
            lblcost.Text = "";
            txt_CarPlate.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Save_Data()
        {
            lblnamesecond.Text = txt_name.Text;
            lblsurnamesecond.Text = txt_surname.Text;
            lblcarplatesecond.Text = txt_CarPlate.Text;
            lblcostsecond.Text = lblcost.Text;
            lblleftday.Text = Convert.ToString(cmb_pay.Text);
            lblcarpark.Text = "Sube Default";
        }

        private void Register_Click(object sender, EventArgs e)
        {
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            pnlpay.Visible = false;
            btn_register.BackColor = Color.Yellow;
            pnllastpage.Visible = false;
            btn_pay.BackColor = Color.Gray;
            btn_where.BackColor = Color.Gray;

        }



        private void btn_pay_Click(object sender, EventArgs e)
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
            else if (cmb_pay.SelectedIndex == 2)
            {
                lblcost.Text = "200";
                btntlicon.Visible = true;

            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (txt_CarPlate.Text.Length > 6 && txt_name.Text.Length > 0 && txt_surname.Text.Length > 0 && cmb_pay.SelectedIndex > -1)
            {
                pnlpay.Visible = true;
                btn_register.BackColor = Color.Green;
                btn_pay.BackColor = Color.Yellow;
                Save_Data();
                txteposta.Visible = true;
                lbleposta.Visible = true;
            }
        }

        private void btnnedit_Click(object sender, EventArgs e)
        {
            pnlpay.Visible = false;
            btn_register.BackColor = Color.Yellow;
            btn_pay.BackColor = Color.Gray;
            txteposta.Visible = false;
            lbleposta.Visible = false;
        }



        private void btnComplete_Click(object sender, EventArgs e)
        {
            btn_register.BackColor = Color.Green;
            btn_pay.BackColor = Color.Green;
            btn_where.BackColor = Color.Green;
            pnllastpage.Visible = true;
            txteposta.Visible = false;
            lbleposta.Visible = false;
            
        }

        private void btnclearpages_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(UserPanel_Load));
            ClearPages();
        }
    }
}
