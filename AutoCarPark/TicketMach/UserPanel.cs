using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Service.ServiceHelp;
using Service.VMs;


namespace TicketMach
{
    public partial class UserPanel : Form
    {
        Service.ServiceHelp.MailSender mailSender = new Service.ServiceHelp.MailSender();
        Service.ServiceHelp.Client client = new Service.ServiceHelp.Client();
        private static HttpClient httpClient = new HttpClient();

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
            txteposta.Text = "";
            ContextLbl.Text = "Kayıt Başarı İle Oluşturulmuştur e-Fatura Mail İle İletilmiştir.";

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
            lblcarpark.Text = "1";
        }

        private void Register_Click(object sender, EventArgs e)
        {
        }

        private async void UserPanel_Load(object sender, EventArgs e)
        {
            pnlpay.Visible = false;
            btn_register.BackColor = Color.Yellow;
            pnllastpage.Visible = false;
            btn_pay.BackColor = Color.Gray;
            btn_where.BackColor = Color.Gray;
            cmb_pay.Items.Clear();



            //using (var res = await httpclient.getasync("https://localhost:44332/api/carts%22))
            //    {
            //    var apiresponse = await res.content.readasstringasync();
            //    //var result = jsonconvert.deserializeobject(apiresponse);
            //    list<paymenttype> payments = jsonconvert.deserializeobject<list<paymenttype>>(apiresponse);
            //}
            //list<paymenttype> payments = jsonconvert.deserializeobject<list<paymenttype>>(apiresponse);

            //Task<List<PaymentType>> Task<List><paymentType>  =  await client.PaymentTypesRequest();
            //string result = await response.Content.ReadAsStringAsync();

            //List<PaymentType> businessunits = JsonConvert.DeserializeObject<List<PaymentType>>(result);

            var response = await httpClient.GetAsync("https://localhost:44325/api/PaymentType");
            string result = await response.Content.ReadAsStringAsync();
            List<PaymentType> businessunits = JsonConvert.DeserializeObject<List<PaymentType>>(result);
            //var myobjList = JsonConvert.DeserializeObject<List<PaymentType>>(result);
            //var myObj = myobjList[0];

            for (int i = 0; i < businessunits.Count; i++)
            {
                cmb_pay.Items.Add(businessunits[i].PaymtValidity);

            }



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
                if (txt_CarPlate.Text.Length < 9)
                {
                    pnlpay.Visible = true;
                    btn_register.BackColor = Color.Green;
                    btn_pay.BackColor = Color.Yellow;
                    Save_Data();
                    txteposta.Visible = true;
                    lbleposta.Visible = true;
                }
                else
                {
                    MessageBox.Show("Araç Plakanızı Eksik veya Fazla Tuşladınız!!");
                }
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



        private async void btnComplete_Click(object sender, EventArgs e)
        {
            int succes = 0;
            Users users = new Users();
            Payments payments = new Payments();



            int hasaccount = await client.HasAccountRequest(txt_CarPlate.Text);
            if (Convert.ToInt32(hasaccount) == 0)
            {
                users.UseName = txt_name.Text;
                users.UseSurname = txt_surname.Text;
                users.UseCarPlate = txt_CarPlate.Text;
                users.UseActive = false;
                var b = await client.NewUserCreateRequest(users);

                payments.ParkId = 1;
                payments.LeftDay = Convert.ToInt32(cmb_pay.Text);
                payments.PaymCost = Convert.ToDecimal(lblcost.Text);
                payments.PaymUserPlate = txt_CarPlate.Text;
                payments.EventDate = Convert.ToDateTime(null);

                var NewUserSuccesPayment = await client.CreatePayment(payments);
            }
            //else if ()
            //{

            //}
            else
            {

                payments.PaymUserPlate = Convert.ToString(txt_CarPlate.Text);
                var pay = await client.HasBills(payments);
                if (pay == 1)
                {
                    payments.PaymUserPlate = txt_CarPlate.Text;
                    payments.EventDate = Convert.ToDateTime(null);
                    payments.ParkId = 1;
                    payments.LeftDay = Convert.ToInt32(cmb_pay.Text);
                    payments.PaymCost = Convert.ToDecimal(lblcost.Text);
                    var SuccesPayment = await client.CreatePayment(payments);
                }
                else
                {
                    pnllastpage.Visible = true;
                    ContextLbl.Text = "Plakanıza Ait Abonmalık Hakkı Devam Etmektedir";
                    btn_register.BackColor = Color.Green;
                    btn_pay.BackColor = Color.Green;
                    btn_where.BackColor = Color.Green;
                    pnllastpage.Visible = true;
                    txteposta.Visible = false;
                    lbleposta.Visible = false;
                    succes++;
                }
            }

            string cont = "";

            if (txteposta.Text != "" && succes != 1)
            {

                Service.ServiceHelp.MailSender mailSender = new Service.ServiceHelp.MailSender();
                if (Convert.ToInt32(hasaccount) == 1)
                {
                    cont = txt_CarPlate.Text + "  Plaka için Zaten Kayıt Bulunmaktadır" + lblleftday.Text + "    Günlük Üyelik Alınmıştır. \n Tutar:" + lblcost.Text;

                }
                else
                    cont = txt_CarPlate.Text + "  Plaka için" + lblleftday.Text + "    Günlük Kayıt alınmıştır. \n Tutar:" + lblcost.Text;

                var i = mailSender.SendMail(txteposta.Text, cont);
                if (i == false)
                {
                    ContextLbl.Text = "Eposta Hatalı Kayıt Oluşturuldu \n En Yakın Zamandaa Şubeden Faturanızı Alabilirsiniz";
                    btn_register.BackColor = Color.Green;
                    btn_pay.BackColor = Color.Green;
                    btn_where.BackColor = Color.Green;
                    pnllastpage.Visible = true;
                    txteposta.Visible = false;
                    lbleposta.Visible = false;
                }


            }
            else if (succes != 1)
            {
                ContextLbl.Text = "Eposta  Adresi Girmediniz \n En Yakın Zamandaa Şubeden Faturanızı Alabilirsiniz";
                btn_register.BackColor = Color.Green;
                btn_pay.BackColor = Color.Green;
                btn_where.BackColor = Color.Green;
                pnllastpage.Visible = true;
                txteposta.Visible = false;
                lbleposta.Visible = false;
            }

        }

        private void btnclearpages_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(UserPanel_Load));
            ClearPages();
        }
    }
}
