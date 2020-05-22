using ControlSRC.VModels;
using Newtonsoft.Json;
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
using Service.ServiceHelp;

namespace ControlSRC
{
    public partial class LoginPage : Form
    {

        Service.ServiceHelp.Client client = new Service.ServiceHelp.Client();
        public LoginPage()
        {
            InitializeComponent();
            Init_Data();
        }
        private void Save_Data(int id)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserName = txtusername.Text;
                Properties.Settings.Default.Password = txtpassword.Text;
                Properties.Settings.Default.PARKid = id;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = txtusername.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.PARKid = id;
                Properties.Settings.Default.Save();
            }

        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    txtusername.Text = Properties.Settings.Default.UserName;
                    txtpassword.Text = Properties.Settings.Default.Password;

                    checkBox1.Checked = true;

                }
            }
        }
        private void nextPage()
        {
            MainScreen ScreenTWO = new MainScreen();
            ScreenTWO.Show();
            this.Hide();

        }
        private async void btnlogin_Click(object sender, EventArgs e)
        {

            var result = await client.LoginRequest(txtusername.Text, txtpassword.Text);

            if (result > 0)
            {
                Save_Data(Convert.ToInt32(result));
                nextPage();
            }
            else
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!!", "BAŞARISIZ GİRİŞ");

        }
    }
}
