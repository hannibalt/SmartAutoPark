using _AutoParkProcessor.FileHelper;
using _AutoParkProcessor.ImageProc;
using AForge.Video;
using AForge.Video.DirectShow;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using Service.VMs;
using Service.ServiceHelp;

namespace ControlSRC
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private FilterInfoCollection webcam;//webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi. 
        private VideoCaptureDevice cam;//cam ise bizim kullanacağımız aygıt
        string cevap = "", Folder = "";
        bool stop = false;
        Client client = new Client();
        FileHelper Helper = new FileHelper();
        private void GetBack()
        {
            AdminRoot ScreenTWO = new AdminRoot();
            ScreenTWO.Show();
            this.Hide();
            ArdunioReader.Close();

        }
        int onstream = 0;
        private string ArdunioData;   //ardunio data değişkenini oluştur


        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            Firststate.Image = bit;
        }


        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            string samplepatch = Folder;
            string saveplace;
            int count = Helper.CaughtFolder(samplepatch);
            count--;
            Convert.ToString(count);
            saveplace = samplepatch + @"\lastimage" + count + ".jpg";
            cevap = ImageEditor.processImageFile(saveplace);
            if (cevap != "")
            {
                txt_result.Text = Convert.ToString(cevap).Trim();

            }

            OpenCamera();
        }
        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.Exit();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblparkId.Text = Convert.ToString(Properties.Settings.Default.PARKid);
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);//webcam dizisine mevcut kameraları dolduruyoruz.
            foreach (FilterInfo videocapturedevice in webcam)
            {
                cmb_CamList.Items.Add(videocapturedevice.Name);//kameraları combobox a dolduruyoruz.
            }
            cmb_CamList.SelectedIndex = 0; //Comboboxtaki ilk index numaralı kameranın ekranda görünmesi için
        }
        private void OpenCamera()
        {
            cam = new VideoCaptureDevice(webcam[cmb_CamList.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
            onstream = 1;
            btn_camconnect.BackColor = Color.Green;
        }

        private void btn_camconnect_Click_1(object sender, EventArgs e)
        {
            if (onstream == 0)
            {

                OpenCamera();
            }
        }


        private void CatchImage()
        {

            if (onstream == 1 && Folder != "")
            {
                string samplepatch = Folder;
                string savereplace;
                int count = Helper.CaughtFolder(samplepatch);
                Convert.ToString(count);
                savereplace = samplepatch + @"\lastimage" + count + ".jpg";
                Firststate.Image.Save(savereplace);
                if (LastStat.Image != null)
                    Firststate.Image = null;
                LastStat.Image = Firststate.Image;
                cam.SignalToStop();
                stop = false;
            }
            else
                MessageBox.Show("Kamera Baglantısından Emin Olunuz!!");


        }
        private void btn_prosss_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                ImageEditor.processImageFile(openFileDialog.FileName);

            }
        }

        private void ArdunioReader_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                ArdunioData = ArdunioReader.ReadLine();//Gelen veriyi okuma
                Convert.ToInt32(ArdunioData);
                this.Invoke(new EventHandler(displayData_event));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //cam.Start();


            }


        }

        private void displayData_event(object sender, EventArgs e)
        {
            try
            {
                label1.Text = ArdunioData;
                //Gelen veriyi label2'ye yaz //
                if (Convert.ToInt32(ArdunioData) < 70)
                {
                    if (stop == false)
                    {
                        stop = true;
                        if (stop == true)
                            CatchImage();
                    }

                }




            }
            catch (Exception)
            {
                cam.Start();
                stop = false;


            }
        }
        private void ArdunioCreater()
        {
            ArdunioReader = new SerialPort();
            ArdunioReader.PortName = "COM4";       //Port ismini comboBox1'in text'i olarak belirle
            ArdunioReader.BaudRate = 9600;
            ArdunioReader.Open();
            ArdunioReader.DataReceived += new SerialDataReceivedEventHandler(ArdunioReader_DataReceived); //DataReceived eventini oluşturma  
        }
        private void CheckDoor_Click(object sender, EventArgs e)
        {
            try
            {
                ArdunioCreater();                                                                                         //Seri portu aç
                CheckDoor.Enabled = false;
                CheckDoor.BackColor = Color.Green;

                //"Bağlan" butonunu tıklanamaz yap
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kapı Baglantı Sorunu");  //Hata mesajı
            }
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ArdunioReader.IsOpen) ArdunioReader.Close();    //Seri port açıksa kapat

        }

        private void button1_Click(object sender, EventArgs e)
        {


            ArdunioReader.Write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArdunioReader.Write("0");
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private async void xuiResult_TextChanged(object sender, EventArgs e)
        //{

        //}

        private async void txt_result_TextChanged(object sender, EventArgs e)
        {
            if (txt_result.Text == "")
            {
                return;
            }
            else
            {
                Logs logs = new Logs();
                logs.SubPlate = txt_result.Text.Trim();
                logs.VehicleType = 1;
                logs.ParkId = Properties.Settings.Default.PARKid;

                var OpenTheDoor = await client.UserActive(txt_result.Text.Trim());

                if (OpenTheDoor == 1)
                {

                    var SuccesLog = await client.NewLog(logs);


                    ArdunioReader.Write("1");

                }
                OpenCamera();
                stop = false;

            }

        }


        private void Btn_GetBack_Click(object sender, EventArgs e)
        {
            GetBack();
        }

        private void btntriggercam_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
            txt_result.Text = "16NOG95";
            OpenCamera();

        }

        private void BTN_RECORDON_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SourceCheck_Click(object sender, EventArgs e)
        {

            if (FindRootSource.ShowDialog(this) == DialogResult.OK)
            {
                Btn_SourceCheck.BackColor = Color.Green;
                FileInfo dosyabilgisi = new FileInfo(FindRootSource.SelectedPath);

                Folder = (dosyabilgisi.FullName);


            }
        }
    }
}
