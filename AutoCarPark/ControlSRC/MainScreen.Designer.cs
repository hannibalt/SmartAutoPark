namespace ControlSRC
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.LastStat = new System.Windows.Forms.PictureBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_prosss = new System.Windows.Forms.Button();
            this.pc_procesone = new System.Windows.Forms.PictureBox();
            this.btn_screensave = new System.Windows.Forms.Button();
            this.btn_screens = new System.Windows.Forms.Button();
            this.cmb_CamList = new System.Windows.Forms.ComboBox();
            this.btn_camconnect = new System.Windows.Forms.Button();
            this.Firststate = new System.Windows.Forms.PictureBox();
            this.SaveFiledialog = new System.Windows.Forms.SaveFileDialog();
            this.fswWatchImage = new System.IO.FileSystemWatcher();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ArdunioReader = new System.IO.Ports.SerialPort(this.components);
            this.Btn_SourceCheck = new System.Windows.Forms.Button();
            this.FindRootSource = new System.Windows.Forms.FolderBrowserDialog();
            this.CheckDoor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LastStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_procesone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firststate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswWatchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LastStat
            // 
            this.LastStat.BackColor = System.Drawing.Color.Transparent;
            this.LastStat.Location = new System.Drawing.Point(592, 127);
            this.LastStat.Margin = new System.Windows.Forms.Padding(2);
            this.LastStat.Name = "LastStat";
            this.LastStat.Size = new System.Drawing.Size(302, 219);
            this.LastStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LastStat.TabIndex = 33;
            this.LastStat.TabStop = false;
            // 
            // txt_result
            // 
            this.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_result.Location = new System.Drawing.Point(155, 423);
            this.txt_result.Margin = new System.Windows.Forms.Padding(2);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(206, 19);
            this.txt_result.TabIndex = 31;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // btn_prosss
            // 
            this.btn_prosss.BackColor = System.Drawing.Color.Transparent;
            this.btn_prosss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prosss.ForeColor = System.Drawing.Color.Transparent;
            this.btn_prosss.Image = ((System.Drawing.Image)(resources.GetObject("btn_prosss.Image")));
            this.btn_prosss.Location = new System.Drawing.Point(709, 364);
            this.btn_prosss.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prosss.Name = "btn_prosss";
            this.btn_prosss.Size = new System.Drawing.Size(76, 78);
            this.btn_prosss.TabIndex = 30;
            this.btn_prosss.UseVisualStyleBackColor = false;
            this.btn_prosss.Click += new System.EventHandler(this.btn_prosss_Click);
            // 
            // pc_procesone
            // 
            this.pc_procesone.BackColor = System.Drawing.Color.Transparent;
            this.pc_procesone.Location = new System.Drawing.Point(949, 142);
            this.pc_procesone.Margin = new System.Windows.Forms.Padding(2);
            this.pc_procesone.Name = "pc_procesone";
            this.pc_procesone.Size = new System.Drawing.Size(236, 204);
            this.pc_procesone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_procesone.TabIndex = 28;
            this.pc_procesone.TabStop = false;
            // 
            // btn_screensave
            // 
            this.btn_screensave.BackColor = System.Drawing.Color.Transparent;
            this.btn_screensave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_screensave.ForeColor = System.Drawing.Color.Transparent;
            this.btn_screensave.Image = ((System.Drawing.Image)(resources.GetObject("btn_screensave.Image")));
            this.btn_screensave.Location = new System.Drawing.Point(592, 364);
            this.btn_screensave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_screensave.Name = "btn_screensave";
            this.btn_screensave.Size = new System.Drawing.Size(72, 78);
            this.btn_screensave.TabIndex = 27;
            this.btn_screensave.UseVisualStyleBackColor = false;
            this.btn_screensave.Click += new System.EventHandler(this.btn_screensave_Click);
            // 
            // btn_screens
            // 
            this.btn_screens.BackColor = System.Drawing.Color.Transparent;
            this.btn_screens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_screens.ForeColor = System.Drawing.Color.Transparent;
            this.btn_screens.Image = ((System.Drawing.Image)(resources.GetObject("btn_screens.Image")));
            this.btn_screens.Location = new System.Drawing.Point(473, 364);
            this.btn_screens.Margin = new System.Windows.Forms.Padding(2);
            this.btn_screens.Name = "btn_screens";
            this.btn_screens.Size = new System.Drawing.Size(72, 78);
            this.btn_screens.TabIndex = 26;
            this.btn_screens.UseVisualStyleBackColor = false;
            // 
            // cmb_CamList
            // 
            this.cmb_CamList.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_CamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CamList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_CamList.FormattingEnabled = true;
            this.cmb_CamList.Location = new System.Drawing.Point(11, 103);
            this.cmb_CamList.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CamList.Name = "cmb_CamList";
            this.cmb_CamList.Size = new System.Drawing.Size(150, 21);
            this.cmb_CamList.TabIndex = 25;
            // 
            // btn_camconnect
            // 
            this.btn_camconnect.BackColor = System.Drawing.Color.Transparent;
            this.btn_camconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camconnect.ForeColor = System.Drawing.Color.Transparent;
            this.btn_camconnect.Image = global::ControlSRC.MainImages.icons8_video_message_451;
            this.btn_camconnect.Location = new System.Drawing.Point(11, 11);
            this.btn_camconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_camconnect.Name = "btn_camconnect";
            this.btn_camconnect.Size = new System.Drawing.Size(90, 72);
            this.btn_camconnect.TabIndex = 24;
            this.btn_camconnect.UseVisualStyleBackColor = false;
            this.btn_camconnect.Click += new System.EventHandler(this.btn_camconnect_Click_1);
            // 
            // Firststate
            // 
            this.Firststate.BackColor = System.Drawing.Color.Transparent;
            this.Firststate.Location = new System.Drawing.Point(263, 127);
            this.Firststate.Margin = new System.Windows.Forms.Padding(2);
            this.Firststate.Name = "Firststate";
            this.Firststate.Size = new System.Drawing.Size(282, 219);
            this.Firststate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Firststate.TabIndex = 23;
            this.Firststate.TabStop = false;
            // 
            // fswWatchImage
            // 
            this.fswWatchImage.EnableRaisingEvents = true;
            this.fswWatchImage.Path = "C:\\Users\\Hannibal\\Desktop\\projeornek";
            this.fswWatchImage.SynchronizingObject = this;
            this.fswWatchImage.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ArdunioReader
            // 
            this.ArdunioReader.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ArdunioReader_DataReceived);
            // 
            // Btn_SourceCheck
            // 
            this.Btn_SourceCheck.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SourceCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SourceCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_SourceCheck.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_SourceCheck.Image = global::ControlSRC.MainImages.icons8_folder_45;
            this.Btn_SourceCheck.Location = new System.Drawing.Point(331, 29);
            this.Btn_SourceCheck.Name = "Btn_SourceCheck";
            this.Btn_SourceCheck.Size = new System.Drawing.Size(90, 70);
            this.Btn_SourceCheck.TabIndex = 34;
            this.Btn_SourceCheck.UseVisualStyleBackColor = false;
            this.Btn_SourceCheck.Click += new System.EventHandler(this.Btn_SourceCheck_Click);
            // 
            // CheckDoor
            // 
            this.CheckDoor.BackColor = System.Drawing.Color.Transparent;
            this.CheckDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDoor.ForeColor = System.Drawing.Color.Transparent;
            this.CheckDoor.Image = global::ControlSRC.MainImages.icons8_door_symbol_45;
            this.CheckDoor.Location = new System.Drawing.Point(473, 33);
            this.CheckDoor.Name = "CheckDoor";
            this.CheckDoor.Size = new System.Drawing.Size(75, 66);
            this.CheckDoor.TabIndex = 35;
            this.CheckDoor.UseVisualStyleBackColor = false;
            this.CheckDoor.Click += new System.EventHandler(this.CheckDoor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1001, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(755, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(870, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1233, 613);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckDoor);
            this.Controls.Add(this.Btn_SourceCheck);
            this.Controls.Add(this.LastStat);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_prosss);
            this.Controls.Add(this.pc_procesone);
            this.Controls.Add(this.btn_screensave);
            this.Controls.Add(this.btn_screens);
            this.Controls.Add(this.cmb_CamList);
            this.Controls.Add(this.btn_camconnect);
            this.Controls.Add(this.Firststate);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.LastStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_procesone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firststate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswWatchImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LastStat;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_prosss;
        private System.Windows.Forms.PictureBox pc_procesone;
        private System.Windows.Forms.Button btn_screensave;
        private System.Windows.Forms.Button btn_screens;
        private System.Windows.Forms.ComboBox cmb_CamList;
        private System.Windows.Forms.Button btn_camconnect;
        private System.Windows.Forms.PictureBox Firststate;
        private System.Windows.Forms.SaveFileDialog SaveFiledialog;
        private System.IO.FileSystemWatcher fswWatchImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.IO.Ports.SerialPort ArdunioReader;
        private System.Windows.Forms.Button Btn_SourceCheck;
        private System.Windows.Forms.FolderBrowserDialog FindRootSource;
        private System.Windows.Forms.Button CheckDoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

