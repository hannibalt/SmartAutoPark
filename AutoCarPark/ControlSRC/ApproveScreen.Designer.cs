namespace ControlSRC
{
    partial class ApproveScreen
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
            this.dtgrd = new System.Windows.Forms.DataGridView();
            this.PaymCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymUserPlateNavigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Park = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymUserPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_carplate = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_parkid = new System.Windows.Forms.TextBox();
            this.lbl_payid = new System.Windows.Forms.Label();
            this.txteventdate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_GetBack = new System.Windows.Forms.Button();
            this.btn_approve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrd
            // 
            this.dtgrd.AllowUserToAddRows = false;
            this.dtgrd.AllowUserToDeleteRows = false;
            this.dtgrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymCost,
            this.PaymUserPlateNavigation,
            this.Park,
            this.LeftDay,
            this.ParkId,
            this.PaymUserPlate,
            this.PaymId,
            this.EventDate});
            this.dtgrd.Location = new System.Drawing.Point(195, 227);
            this.dtgrd.Name = "dtgrd";
            this.dtgrd.ReadOnly = true;
            this.dtgrd.Size = new System.Drawing.Size(716, 410);
            this.dtgrd.TabIndex = 0;
            this.dtgrd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_RowEnter);
            // 
            // PaymCost
            // 
            this.PaymCost.DataPropertyName = "PaymCost";
            this.PaymCost.HeaderText = "Ödenecek Tutar";
            this.PaymCost.Name = "PaymCost";
            this.PaymCost.ReadOnly = true;
            // 
            // PaymUserPlateNavigation
            // 
            this.PaymUserPlateNavigation.DataPropertyName = "PaymUserPlateNavigation";
            this.PaymUserPlateNavigation.HeaderText = "PaymUserPlateNavigation";
            this.PaymUserPlateNavigation.Name = "PaymUserPlateNavigation";
            this.PaymUserPlateNavigation.ReadOnly = true;
            this.PaymUserPlateNavigation.Visible = false;
            // 
            // Park
            // 
            this.Park.DataPropertyName = "Park";
            this.Park.HeaderText = "Park";
            this.Park.Name = "Park";
            this.Park.ReadOnly = true;
            this.Park.Visible = false;
            // 
            // LeftDay
            // 
            this.LeftDay.DataPropertyName = "LeftDay";
            this.LeftDay.HeaderText = "Kullanım Hakkı";
            this.LeftDay.Name = "LeftDay";
            this.LeftDay.ReadOnly = true;
            // 
            // ParkId
            // 
            this.ParkId.DataPropertyName = "ParkId";
            this.ParkId.HeaderText = "OtoparkNumarası";
            this.ParkId.Name = "ParkId";
            this.ParkId.ReadOnly = true;
            // 
            // PaymUserPlate
            // 
            this.PaymUserPlate.DataPropertyName = "PaymUserPlate";
            this.PaymUserPlate.HeaderText = "Araç Plakası";
            this.PaymUserPlate.Name = "PaymUserPlate";
            this.PaymUserPlate.ReadOnly = true;
            // 
            // PaymId
            // 
            this.PaymId.DataPropertyName = "PaymId";
            this.PaymId.HeaderText = "PAYM_Id";
            this.PaymId.Name = "PaymId";
            this.PaymId.ReadOnly = true;
            this.PaymId.Visible = false;
            // 
            // EventDate
            // 
            this.EventDate.DataPropertyName = "EventDate";
            this.EventDate.HeaderText = "İşlem Tarihi";
            this.EventDate.Name = "EventDate";
            this.EventDate.ReadOnly = true;
            // 
            // txt_carplate
            // 
            this.txt_carplate.Enabled = false;
            this.txt_carplate.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_carplate.Location = new System.Drawing.Point(98, 37);
            this.txt_carplate.Name = "txt_carplate";
            this.txt_carplate.Size = new System.Drawing.Size(131, 26);
            this.txt_carplate.TabIndex = 1;
            // 
            // txt_day
            // 
            this.txt_day.Enabled = false;
            this.txt_day.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_day.Location = new System.Drawing.Point(98, 92);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(131, 26);
            this.txt_day.TabIndex = 2;
            // 
            // txt_cost
            // 
            this.txt_cost.Enabled = false;
            this.txt_cost.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_cost.Location = new System.Drawing.Point(299, 37);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(131, 26);
            this.txt_cost.TabIndex = 3;
            // 
            // txt_parkid
            // 
            this.txt_parkid.Enabled = false;
            this.txt_parkid.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_parkid.Location = new System.Drawing.Point(299, 92);
            this.txt_parkid.Multiline = true;
            this.txt_parkid.Name = "txt_parkid";
            this.txt_parkid.Size = new System.Drawing.Size(131, 26);
            this.txt_parkid.TabIndex = 4;
            // 
            // lbl_payid
            // 
            this.lbl_payid.AutoSize = true;
            this.lbl_payid.Location = new System.Drawing.Point(26, 13);
            this.lbl_payid.Name = "lbl_payid";
            this.lbl_payid.Size = new System.Drawing.Size(0, 13);
            this.lbl_payid.TabIndex = 6;
            this.lbl_payid.Visible = false;
            // 
            // txteventdate
            // 
            this.txteventdate.Enabled = false;
            this.txteventdate.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.txteventdate.Location = new System.Drawing.Point(513, 37);
            this.txteventdate.Name = "txteventdate";
            this.txteventdate.Size = new System.Drawing.Size(131, 26);
            this.txteventdate.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_carplate);
            this.groupBox1.Controls.Add(this.txteventdate);
            this.groupBox1.Controls.Add(this.txt_day);
            this.groupBox1.Controls.Add(this.txt_cost);
            this.groupBox1.Controls.Add(this.txt_parkid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(195, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // Btn_GetBack
            // 
            this.Btn_GetBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GetBack.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_GetBack.Image = global::ControlSRC.Properties.Resources._return;
            this.Btn_GetBack.Location = new System.Drawing.Point(12, 62);
            this.Btn_GetBack.Name = "Btn_GetBack";
            this.Btn_GetBack.Size = new System.Drawing.Size(158, 130);
            this.Btn_GetBack.TabIndex = 9;
            this.Btn_GetBack.UseVisualStyleBackColor = true;
            this.Btn_GetBack.Click += new System.EventHandler(this.Btn_GetBack_Click);
            // 
            // btn_approve
            // 
            this.btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve.ForeColor = System.Drawing.Color.Transparent;
            this.btn_approve.Image = global::ControlSRC.Properties.Resources.cash_in_hand;
            this.btn_approve.Location = new System.Drawing.Point(934, 62);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(158, 130);
            this.btn_approve.TabIndex = 5;
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // ApproveScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1104, 649);
            this.Controls.Add(this.Btn_GetBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_payid);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.dtgrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApproveScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApproveScreen";
            this.Load += new System.EventHandler(this.ApproveScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrd;
        private System.Windows.Forms.TextBox txt_carplate;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_parkid;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymUserPlateNavigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Park;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymUserPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.Label lbl_payid;
        private System.Windows.Forms.TextBox txteventdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_GetBack;
    }
}