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

namespace ControlSRC
{
    public partial class ApproveScreen : Form
    {
        private static HttpClient httpClient = new HttpClient();

        public ApproveScreen()
        {
            InitializeComponent();
        }
        private void ClearValues()
        {

            txt_day.Text = "";
            txt_parkid.Text = "";
            txt_cost.Text = "";
            txt_carplate.Text = "";
            lbl_payid.Text = "";
        }

        private async void FillDTGD()
        {
            using (var response = await httpClient.GetAsync("https://localhost:44325/api/Payments/ParkId?ParkId=" + Properties.Settings.Default.PARKid))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                //var result = JsonConvert.DeserializeObject(apiResponse);
                List<Payments> products = JsonConvert.DeserializeObject<List<Payments>>(apiResponse);

                dtgrd.DataSource = products;

            }
        }
        private void GetBack()
        {
            AdminRoot ScreenTWO = new AdminRoot();
            ScreenTWO.Show();
            this.Hide();

        }
        private async void ApproveScreen_Load(object sender, EventArgs e)
        {

            FillDTGD();
        }

        private async void dtgrd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44325/api/Payments"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    //var result = JsonConvert.DeserializeObject(apiResponse);
                    List<Payments> products = JsonConvert.DeserializeObject<List<Payments>>(apiResponse);
                    foreach (var item in products)
                    {
                        if (item.PaymId == Convert.ToInt32(dtgrd.Rows[e.RowIndex].Cells["PaymId"].Value))
                        {
                            txt_carplate.Text = item.PaymUserPlate.ToString();
                            txt_cost.Text = item.PaymCost.ToString();
                            txt_day.Text = item.LeftDay.ToString();
                            lbl_payid.Text = item.PaymId.ToString();
                            txteventdate.Text = item.EventDate.ToString();
                            txt_parkid.Text = item.ParkId.ToString();



                        }
                    }


                }
            }
        }

        private void Btn_GetBack_Click(object sender, EventArgs e)
        {
            GetBack();
        }

        private async void btn_approve_Click(object sender, EventArgs e)
        {

            if(txt_cost.Text=="")
            {
                MessageBox.Show("Onaylamak İçin Fatura Seçiniz");
            }
            else
            { 
            btn_approve.Enabled = false;
            using (var httpClient = new HttpClient())
            {

                Payments payments = new Payments();
                payments.LeftDay = Convert.ToInt32(txt_day.Text);
                payments.EventDate = Convert.ToDateTime(DateTime.Now);
                payments.ParkId = Convert.ToInt32(txt_parkid.Text);
                payments.PaymCost = Convert.ToDecimal(txt_cost.Text);
                payments.PaymUserPlate = Convert.ToString(txt_carplate.Text);
                payments.PaymId = Convert.ToInt32(lbl_payid.Text);


                var convertModel = JsonConvert.SerializeObject(payments);
                var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");



                var response = await httpClient.PutAsync("https://localhost:44325/api/Payments", content);
            }
            FillDTGD();
            ClearValues();
            btn_approve.Enabled = true;
            }
        }
    }
}
