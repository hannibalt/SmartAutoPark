namespace TicketMach.Views
{
    partial class SCR_Register
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCR_Register));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_CarPlate = new System.Windows.Forms.TextBox();
            this.cmb_pay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_name.Location = new System.Drawing.Point(186, 224);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(197, 36);
            this.txt_name.TabIndex = 0;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_surname.Location = new System.Drawing.Point(186, 280);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(197, 36);
            this.txt_surname.TabIndex = 1;
            // 
            // txt_CarPlate
            // 
            this.txt_CarPlate.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_CarPlate.Location = new System.Drawing.Point(186, 336);
            this.txt_CarPlate.Name = "txt_CarPlate";
            this.txt_CarPlate.Size = new System.Drawing.Size(197, 36);
            this.txt_CarPlate.TabIndex = 2;
            // 
            // cmb_pay
            // 
            this.cmb_pay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pay.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmb_pay.FormattingEnabled = true;
            this.cmb_pay.Location = new System.Drawing.Point(504, 221);
            this.cmb_pay.Name = "cmb_pay";
            this.cmb_pay.Size = new System.Drawing.Size(192, 36);
            this.cmb_pay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "İlk Kayıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(108, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(82, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Araç Plakası:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketMach.Properties.Resources.banner_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(87, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 159);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton1.ButtonImage")));
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "Onayla";
            this.xuiSuperButton1.CornerRadius = 5;
            this.xuiSuperButton1.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(559, 421);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(128, 56);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 9;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(389, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme Planı";
            // 
            // SCR_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xuiSuperButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_pay);
            this.Controls.Add(this.txt_CarPlate);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Name = "SCR_Register";
            this.Size = new System.Drawing.Size(724, 504);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_CarPlate;
        private System.Windows.Forms.ComboBox cmb_pay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public XanderUI.XUISuperButton xuiSuperButton1;
    }
}
