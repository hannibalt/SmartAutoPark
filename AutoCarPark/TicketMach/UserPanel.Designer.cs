namespace TicketMach
{
    partial class UserPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_where = new System.Windows.Forms.Button();
            this.scR_Register1 = new TicketMach.Views.SCR_Register();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(167)))), ((int)(((byte)(179)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.btn_pay);
            this.panel1.Controls.Add(this.btn_where);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 630);
            this.panel1.TabIndex = 44;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(102)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.ForeColor = System.Drawing.Color.Transparent;
            this.btn_register.Image = global::TicketMach.Properties.Resources.register_and_manage_customer_devices_with_connected_field_service_social1;
            this.btn_register.Location = new System.Drawing.Point(-1, -1);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(216, 132);
            this.btn_register.TabIndex = 35;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.Register_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pay.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pay.Image = global::TicketMach.Properties.Resources._1554401;
            this.btn_pay.Location = new System.Drawing.Point(-2, 126);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(216, 129);
            this.btn_pay.TabIndex = 34;
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_where
            // 
            this.btn_where.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
            this.btn_where.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_where.ForeColor = System.Drawing.Color.Transparent;
            this.btn_where.Image = global::TicketMach.Properties.Resources.sadasd;
            this.btn_where.Location = new System.Drawing.Point(-2, 250);
            this.btn_where.Margin = new System.Windows.Forms.Padding(2);
            this.btn_where.Name = "btn_where";
            this.btn_where.Size = new System.Drawing.Size(217, 135);
            this.btn_where.TabIndex = 24;
            this.btn_where.UseVisualStyleBackColor = false;
            // 
            // scR_Register1
            // 
            this.scR_Register1.BackColor = System.Drawing.Color.Transparent;
            this.scR_Register1.Location = new System.Drawing.Point(212, 0);
            this.scR_Register1.Name = "scR_Register1";
            this.scR_Register1.Size = new System.Drawing.Size(777, 630);
            this.scR_Register1.TabIndex = 45;
            this.scR_Register1.Load += new System.EventHandler(this.scR_Register1_Load);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(120)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(991, 630);
            this.Controls.Add(this.scR_Register1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserScreen";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Views.SCR_Register scR_Register1;
        public System.Windows.Forms.Button btn_pay;
        public System.Windows.Forms.Button btn_where;
        public System.Windows.Forms.Button btn_register;
    }
}

