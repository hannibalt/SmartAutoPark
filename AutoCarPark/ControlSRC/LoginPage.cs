using System;
using System.Windows.Forms;

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
            AdminRoot ScreenTWO = new AdminRoot();
            ScreenTWO.Show();
            this.Hide();

        }
        private async void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length == 0 && txtpassword.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz", "BAŞARISIZ GİRİŞ");

            }
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
