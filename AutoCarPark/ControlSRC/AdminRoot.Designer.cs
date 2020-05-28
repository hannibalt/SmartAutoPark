namespace ControlSRC
{
    partial class AdminRoot
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
            this.btnGoCameraScreen = new System.Windows.Forms.Button();
            this.btnPaymentScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoCameraScreen
            // 
            this.btnGoCameraScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnGoCameraScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGoCameraScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoCameraScreen.Image = global::ControlSRC.Properties.Resources.sjoerdverbeek_schiphol_icondesign_large_parking_removebg_preview;
            this.btnGoCameraScreen.Location = new System.Drawing.Point(414, 0);
            this.btnGoCameraScreen.Name = "btnGoCameraScreen";
            this.btnGoCameraScreen.Size = new System.Drawing.Size(386, 450);
            this.btnGoCameraScreen.TabIndex = 1;
            this.btnGoCameraScreen.Text = ",";
            this.btnGoCameraScreen.UseVisualStyleBackColor = false;
            this.btnGoCameraScreen.Click += new System.EventHandler(this.btnGoCameraScreen_Click);
            // 
            // btnPaymentScreen
            // 
            this.btnPaymentScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnPaymentScreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPaymentScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentScreen.Image = global::ControlSRC.Properties.Resources.download_payment_icon_2_ask_the_expert_payment_png_image_with_no_payment_png_500_501;
            this.btnPaymentScreen.Location = new System.Drawing.Point(0, 0);
            this.btnPaymentScreen.Name = "btnPaymentScreen";
            this.btnPaymentScreen.Size = new System.Drawing.Size(408, 450);
            this.btnPaymentScreen.TabIndex = 0;
            this.btnPaymentScreen.UseVisualStyleBackColor = false;
            this.btnPaymentScreen.Click += new System.EventHandler(this.btnPaymentScreen_Click);
            // 
            // AdminRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoCameraScreen);
            this.Controls.Add(this.btnPaymentScreen);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRoot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaymentScreen;
        private System.Windows.Forms.Button btnGoCameraScreen;
    }
}