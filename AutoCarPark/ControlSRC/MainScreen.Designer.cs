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
            this.LastStat = new System.Windows.Forms.PictureBox();
            this.pc_procesone = new System.Windows.Forms.PictureBox();
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
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblparkId = new System.Windows.Forms.Label();
            this.xuiResult = new XanderUI.XUIBanner();
            ((System.ComponentModel.ISupportInitialize)(this.LastStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_procesone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firststate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswWatchImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LastStat
            // 
            this.LastStat.BackColor = System.Drawing.Color.Transparent;
            this.LastStat.Location = new System.Drawing.Point(541, 127);
            this.LastStat.Margin = new System.Windows.Forms.Padding(2);
            this.LastStat.Name = "LastStat";
            this.LastStat.Size = new System.Drawing.Size(302, 219);
            this.LastStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LastStat.TabIndex = 33;
            this.LastStat.TabStop = false;
            // 
            // pc_procesone
            // 
            this.pc_procesone.BackColor = System.Drawing.Color.Transparent;
            this.pc_procesone.Location = new System.Drawing.Point(883, 127);
            this.pc_procesone.Margin = new System.Windows.Forms.Padding(2);
            this.pc_procesone.Name = "pc_procesone";
            this.pc_procesone.Size = new System.Drawing.Size(280, 219);
            this.pc_procesone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_procesone.TabIndex = 28;
            this.pc_procesone.TabStop = false;
            // 
            // cmb_CamList
            // 
            this.cmb_CamList.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_CamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CamList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_CamList.FormattingEnabled = true;
            this.cmb_CamList.Location = new System.Drawing.Point(234, 44);
            this.cmb_CamList.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CamList.Name = "cmb_CamList";
            this.cmb_CamList.Size = new System.Drawing.Size(150, 21);
            this.cmb_CamList.TabIndex = 25;
            // 
            // btn_camconnect
            // 
            this.btn_camconnect.BackColor = System.Drawing.Color.DarkGray;
            this.btn_camconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camconnect.ForeColor = System.Drawing.Color.Transparent;
            this.btn_camconnect.Image = global::ControlSRC.MainImages.icons8_video_message_451;
            this.btn_camconnect.Location = new System.Drawing.Point(-2, 250);
            this.btn_camconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_camconnect.Name = "btn_camconnect";
            this.btn_camconnect.Size = new System.Drawing.Size(217, 135);
            this.btn_camconnect.TabIndex = 24;
            this.btn_camconnect.UseVisualStyleBackColor = false;
            this.btn_camconnect.Click += new System.EventHandler(this.btn_camconnect_Click_1);
            // 
            // Firststate
            // 
            this.Firststate.BackColor = System.Drawing.Color.Transparent;
            this.Firststate.Location = new System.Drawing.Point(220, 127);
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
            this.Btn_SourceCheck.BackColor = System.Drawing.Color.Gray;
            this.Btn_SourceCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SourceCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_SourceCheck.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_SourceCheck.Image = global::ControlSRC.MainImages.icons8_folder_45;
            this.Btn_SourceCheck.Location = new System.Drawing.Point(-2, 126);
            this.Btn_SourceCheck.Name = "Btn_SourceCheck";
            this.Btn_SourceCheck.Size = new System.Drawing.Size(216, 129);
            this.Btn_SourceCheck.TabIndex = 34;
            this.Btn_SourceCheck.UseVisualStyleBackColor = false;
            this.Btn_SourceCheck.Click += new System.EventHandler(this.Btn_SourceCheck_Click);
            // 
            // CheckDoor
            // 
            this.CheckDoor.BackColor = System.Drawing.Color.DimGray;
            this.CheckDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDoor.ForeColor = System.Drawing.Color.Transparent;
            this.CheckDoor.Image = global::ControlSRC.MainImages.icons8_door_symbol_45;
            this.CheckDoor.Location = new System.Drawing.Point(-1, -1);
            this.CheckDoor.Name = "CheckDoor";
            this.CheckDoor.Size = new System.Drawing.Size(216, 132);
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
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Image = global::ControlSRC.MainImages.exit1;
            this.btnexit.Location = new System.Drawing.Point(1143, 11);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(77, 65);
            this.btnexit.TabIndex = 40;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CheckDoor);
            this.panel1.Controls.Add(this.Btn_SourceCheck);
            this.panel1.Controls.Add(this.btn_camconnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 613);
            this.panel1.TabIndex = 41;
            // 
            // lblparkId
            // 
            this.lblparkId.AutoSize = true;
            this.lblparkId.Location = new System.Drawing.Point(820, 11);
            this.lblparkId.Name = "lblparkId";
            this.lblparkId.Size = new System.Drawing.Size(47, 13);
            this.lblparkId.TabIndex = 42;
            this.lblparkId.Text = "lblparkId";
            // 
            // xuiResult
            // 
            this.xuiResult.BackColor = System.Drawing.Color.Transparent;
            this.xuiResult.BannerColor = System.Drawing.Color.Transparent;
            this.xuiResult.BorderColor = System.Drawing.Color.White;
            this.xuiResult.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(174)))), ((int)(((byte)(185)))));
            this.xuiResult.Location = new System.Drawing.Point(251, 471);
            this.xuiResult.Name = "xuiResult";
            this.xuiResult.Size = new System.Drawing.Size(187, 44);
            this.xuiResult.TabIndex = 43;
            this.xuiResult.TextChanged += new System.EventHandler(this.xuiResult_TextChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1232, 613);
            this.Controls.Add(this.xuiResult);
            this.Controls.Add(this.lblparkId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastStat);
            this.Controls.Add(this.pc_procesone);
            this.Controls.Add(this.cmb_CamList);
            this.Controls.Add(this.Firststate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.LastStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_procesone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firststate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswWatchImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LastStat;
        private System.Windows.Forms.PictureBox pc_procesone;
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
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblparkId;
        private XanderUI.XUIBanner xuiResult;
    }
}

