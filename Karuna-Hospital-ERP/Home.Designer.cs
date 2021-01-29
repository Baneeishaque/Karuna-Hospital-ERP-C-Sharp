namespace Karuna
{
    partial class Home
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
            this.dtp_register = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ip_view = new System.Windows.Forms.Button();
            this.bt_op_view = new System.Windows.Forms.Button();
            this.bt_op = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.bt_discharge = new System.Windows.Forms.Button();
            this.bt_ip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_register
            // 
            this.dtp_register.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_register.Location = new System.Drawing.Point(602, 96);
            this.dtp_register.Name = "dtp_register";
            this.dtp_register.Size = new System.Drawing.Size(227, 20);
            this.dtp_register.TabIndex = 480;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bt_ip_view);
            this.panel1.Controls.Add(this.bt_op_view);
            this.panel1.Controls.Add(this.bt_op);
            this.panel1.Controls.Add(this.bt_about);
            this.panel1.Controls.Add(this.bt_discharge);
            this.panel1.Controls.Add(this.bt_ip);
            this.panel1.Location = new System.Drawing.Point(190, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 152);
            this.panel1.TabIndex = 61;
            // 
            // bt_ip_view
            // 
            this.bt_ip_view.Location = new System.Drawing.Point(177, 81);
            this.bt_ip_view.Name = "bt_ip_view";
            this.bt_ip_view.Size = new System.Drawing.Size(160, 51);
            this.bt_ip_view.TabIndex = 5;
            this.bt_ip_view.Text = "Registered Patients (IP)";
            this.bt_ip_view.UseVisualStyleBackColor = true;
            this.bt_ip_view.Click += new System.EventHandler(this.bt_ip_view_Click);
            // 
            // bt_op_view
            // 
            this.bt_op_view.Location = new System.Drawing.Point(13, 81);
            this.bt_op_view.Name = "bt_op_view";
            this.bt_op_view.Size = new System.Drawing.Size(158, 51);
            this.bt_op_view.TabIndex = 4;
            this.bt_op_view.Text = "Registered Patients (OP)";
            this.bt_op_view.UseVisualStyleBackColor = true;
            this.bt_op_view.Click += new System.EventHandler(this.bt_op_view_Click);
            // 
            // bt_op
            // 
            this.bt_op.AccessibleName = "bt_op";
            this.bt_op.Location = new System.Drawing.Point(13, 21);
            this.bt_op.Name = "bt_op";
            this.bt_op.Size = new System.Drawing.Size(158, 51);
            this.bt_op.TabIndex = 1;
            this.bt_op.Text = "New Registration (OP)";
            this.bt_op.UseVisualStyleBackColor = true;
            this.bt_op.Click += new System.EventHandler(this.bt_op_Click);
            // 
            // bt_about
            // 
            this.bt_about.Location = new System.Drawing.Point(343, 79);
            this.bt_about.Name = "bt_about";
            this.bt_about.Size = new System.Drawing.Size(158, 52);
            this.bt_about.TabIndex = 6;
            this.bt_about.Text = "About Us";
            this.bt_about.UseVisualStyleBackColor = true;
            this.bt_about.Click += new System.EventHandler(this.bt_about_Click);
            // 
            // bt_discharge
            // 
            this.bt_discharge.Location = new System.Drawing.Point(343, 21);
            this.bt_discharge.Name = "bt_discharge";
            this.bt_discharge.Size = new System.Drawing.Size(158, 52);
            this.bt_discharge.TabIndex = 3;
            this.bt_discharge.Text = "Discharge";
            this.bt_discharge.UseVisualStyleBackColor = true;
            this.bt_discharge.Click += new System.EventHandler(this.bt_discharge_Click_1);
            this.bt_discharge.MouseCaptureChanged += new System.EventHandler(this.bt_discharge_Click);
            // 
            // bt_ip
            // 
            this.bt_ip.Location = new System.Drawing.Point(177, 21);
            this.bt_ip.Name = "bt_ip";
            this.bt_ip.Size = new System.Drawing.Size(160, 52);
            this.bt_ip.TabIndex = 2;
            this.bt_ip.Text = "New Registration(IP)";
            this.bt_ip.UseVisualStyleBackColor = true;
            this.bt_ip.Click += new System.EventHandler(this.bt_ip_Click);
            // 
            // Home
            // 
            this.AccessibleName = "Home";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::KarunaHospitalErp.Properties.Resources.Home_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_register);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtp_register;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button bt_ip_view;
        internal System.Windows.Forms.Button bt_op_view;
        internal System.Windows.Forms.Button bt_op;
        internal System.Windows.Forms.Button bt_about;
        internal System.Windows.Forms.Button bt_discharge;
        internal System.Windows.Forms.Button bt_ip;
    }
}