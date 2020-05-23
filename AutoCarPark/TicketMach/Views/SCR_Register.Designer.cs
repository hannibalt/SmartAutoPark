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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_CarPlate = new System.Windows.Forms.TextBox();
            this.cmb_pay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btntlicon = new System.Windows.Forms.Button();
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
            this.cmb_pay.Items.AddRange(new object[] {
            "20 GÜN",
            "35 GÜN",
            "40 GÜN"});
            this.cmb_pay.Location = new System.Drawing.Point(504, 221);
            this.cmb_pay.Name = "cmb_pay";
            this.cmb_pay.Size = new System.Drawing.Size(192, 36);
            this.cmb_pay.TabIndex = 3;
            this.cmb_pay.SelectedIndexChanged += new System.EventHandler(this.cmb_pay_SelectedIndexChanged);
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
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcost.Font = new System.Drawing.Font("Reem Kufi", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblcost.Location = new System.Drawing.Point(448, 325);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(0, 39);
            this.lblcost.TabIndex = 12;
            // 
            // btnApprove
            // 
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Reem Kufi", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnApprove.Image = global::TicketMach.Properties.Resources.success_icon_png_53;
            this.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.Location = new System.Drawing.Point(535, 424);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(125, 63);
            this.btnApprove.TabIndex = 11;
            this.btnApprove.Text = "ONAYLA";
            this.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApprove.UseVisualStyleBackColor = true;
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
            // btntlicon
            // 
            this.btntlicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntlicon.ForeColor = System.Drawing.Color.Transparent;
            this.btntlicon.Image = global::TicketMach.Properties.Resources.tlpara;
            this.btntlicon.Location = new System.Drawing.Point(516, 314);
            this.btntlicon.Name = "btntlicon";
            this.btntlicon.Size = new System.Drawing.Size(75, 58);
            this.btntlicon.TabIndex = 13;
            this.btntlicon.UseVisualStyleBackColor = true;
            this.btntlicon.Visible = false;
            // 
            // SCR_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btntlicon);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.label5);
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
            this.Load += new System.EventHandler(this.SCR_Register_Load);
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
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Button btntlicon;
    }
}
