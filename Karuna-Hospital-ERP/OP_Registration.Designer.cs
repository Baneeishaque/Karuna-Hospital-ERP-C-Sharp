namespace Karuna
{
    partial class OP_Registration
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
            this.ctxt_relation = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_view = new System.Windows.Forms.Button();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_doctor = new System.Windows.Forms.TextBox();
            this.rtxt_other = new System.Windows.Forms.RichTextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.txt_post = new System.Windows.Forms.TextBox();
            this.txt_ward = new System.Windows.Forms.TextBox();
            this.txt_panchayath = new System.Windows.Forms.TextBox();
            this.txt_village = new System.Windows.Forms.TextBox();
            this.txt_house = new System.Windows.Forms.TextBox();
            this.txt_father = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctxt_blood = new System.Windows.Forms.ComboBox();
            this.ctxt_sex = new System.Windows.Forms.ComboBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_op = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.ctxt_relation);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Controls.Add(this.bt_view);
            this.panel1.Controls.Add(this.txt_department);
            this.panel1.Controls.Add(this.txt_doctor);
            this.panel1.Controls.Add(this.rtxt_other);
            this.panel1.Controls.Add(this.txt_mobile);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_pin);
            this.panel1.Controls.Add(this.txt_post);
            this.panel1.Controls.Add(this.txt_ward);
            this.panel1.Controls.Add(this.txt_panchayath);
            this.panel1.Controls.Add(this.txt_village);
            this.panel1.Controls.Add(this.txt_house);
            this.panel1.Controls.Add(this.txt_father);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ctxt_blood);
            this.panel1.Controls.Add(this.ctxt_sex);
            this.panel1.Controls.Add(this.txt_age);
            this.panel1.Controls.Add(this.txt_op);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.Label16);
            this.panel1.Controls.Add(this.Label14);
            this.panel1.Controls.Add(this.Label15);
            this.panel1.Controls.Add(this.Label11);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label13);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 717);
            this.panel1.TabIndex = 0;
        
            // 
            // ctxt_relation
            // 
            this.ctxt_relation.DisplayMember = "A +";
            this.ctxt_relation.FormattingEnabled = true;
            this.ctxt_relation.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Husband",
            "Wife"});
            this.ctxt_relation.Location = new System.Drawing.Point(18, 204);
            this.ctxt_relation.Name = "ctxt_relation";
            this.ctxt_relation.Size = new System.Drawing.Size(122, 23);
            this.ctxt_relation.TabIndex = 162;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(676, 14);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(256, 21);
            this.dtp.TabIndex = 204;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(804, 632);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 203;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click_1);
            // 
            // bt_view
            // 
            this.bt_view.Location = new System.Drawing.Point(707, 632);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(75, 23);
            this.bt_view.TabIndex = 179;
            this.bt_view.Text = "Go";
            this.bt_view.UseVisualStyleBackColor = true;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(221, 660);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(412, 21);
            this.txt_department.TabIndex = 178;
            // 
            // txt_doctor
            // 
            this.txt_doctor.Location = new System.Drawing.Point(221, 617);
            this.txt_doctor.Name = "txt_doctor";
            this.txt_doctor.Size = new System.Drawing.Size(412, 21);
            this.txt_doctor.TabIndex = 177;
            // 
            // rtxt_other
            // 
            this.rtxt_other.Location = new System.Drawing.Point(221, 489);
            this.rtxt_other.Name = "rtxt_other";
            this.rtxt_other.Size = new System.Drawing.Size(412, 96);
            this.rtxt_other.TabIndex = 176;
            this.rtxt_other.Text = "";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(221, 447);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(412, 21);
            this.txt_mobile.TabIndex = 175;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(221, 407);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(412, 21);
            this.txt_phone.TabIndex = 174;
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(456, 367);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(177, 21);
            this.txt_pin.TabIndex = 173;
            // 
            // txt_post
            // 
            this.txt_post.Location = new System.Drawing.Point(221, 367);
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(229, 21);
            this.txt_post.TabIndex = 172;
            // 
            // txt_ward
            // 
            this.txt_ward.Location = new System.Drawing.Point(561, 324);
            this.txt_ward.Name = "txt_ward";
            this.txt_ward.Size = new System.Drawing.Size(72, 21);
            this.txt_ward.TabIndex = 171;
            // 
            // txt_panchayath
            // 
            this.txt_panchayath.Location = new System.Drawing.Point(221, 324);
            this.txt_panchayath.Name = "txt_panchayath";
            this.txt_panchayath.Size = new System.Drawing.Size(334, 21);
            this.txt_panchayath.TabIndex = 170;
            // 
            // txt_village
            // 
            this.txt_village.Location = new System.Drawing.Point(221, 284);
            this.txt_village.Name = "txt_village";
            this.txt_village.Size = new System.Drawing.Size(412, 21);
            this.txt_village.TabIndex = 169;
            // 
            // txt_house
            // 
            this.txt_house.Location = new System.Drawing.Point(221, 244);
            this.txt_house.Name = "txt_house";
            this.txt_house.Size = new System.Drawing.Size(412, 21);
            this.txt_house.TabIndex = 168;
            // 
            // txt_father
            // 
            this.txt_father.Location = new System.Drawing.Point(221, 206);
            this.txt_father.Name = "txt_father";
            this.txt_father.Size = new System.Drawing.Size(412, 21);
            this.txt_father.TabIndex = 167;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(16, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 15);
            this.label10.TabIndex = 165;
            this.label10.Text = "Age  ,  Sex  , Blood Group";
            // 
            // ctxt_blood
            // 
            this.ctxt_blood.DisplayMember = "A +";
            this.ctxt_blood.FormattingEnabled = true;
            this.ctxt_blood.Items.AddRange(new object[] {
            "A +",
            "A -",
            "B +",
            "B -",
            "O +",
            "O -",
            "AB +",
            "AB -"});
            this.ctxt_blood.Location = new System.Drawing.Point(358, 161);
            this.ctxt_blood.Name = "ctxt_blood";
            this.ctxt_blood.Size = new System.Drawing.Size(45, 23);
            this.ctxt_blood.TabIndex = 161;
            // 
            // ctxt_sex
            // 
            this.ctxt_sex.FormattingEnabled = true;
            this.ctxt_sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ctxt_sex.Location = new System.Drawing.Point(271, 161);
            this.ctxt_sex.Name = "ctxt_sex";
            this.ctxt_sex.Size = new System.Drawing.Size(81, 23);
            this.ctxt_sex.TabIndex = 154;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(221, 163);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(44, 21);
            this.txt_age.TabIndex = 148;
            // 
            // txt_op
            // 
            this.txt_op.Location = new System.Drawing.Point(751, 58);
            this.txt_op.Name = "txt_op";
            this.txt_op.Size = new System.Drawing.Size(181, 21);
            this.txt_op.TabIndex = 142;
    
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(221, 118);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(412, 21);
            this.txt_name.TabIndex = 143;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label16.Location = new System.Drawing.Point(13, 666);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(72, 15);
            this.Label16.TabIndex = 131;
            this.Label16.Text = "Department";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label14.Location = new System.Drawing.Point(16, 521);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(37, 15);
            this.Label14.TabIndex = 130;
            this.Label14.Text = "Other";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label15.Location = new System.Drawing.Point(13, 623);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(89, 15);
            this.Label15.TabIndex = 133;
            this.Label15.Text = "Doctor\'s Name";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label11.Location = new System.Drawing.Point(16, 453);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(45, 15);
            this.Label11.TabIndex = 132;
            this.Label11.Text = "Mobile";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label7.Location = new System.Drawing.Point(15, 413);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(88, 15);
            this.Label7.TabIndex = 128;
            this.Label7.Text = "Phone (Home)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label6.Location = new System.Drawing.Point(15, 373);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(125, 15);
            this.Label6.TabIndex = 139;
            this.Label6.Text = "Post Office  ,  Pincode";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label5.Location = new System.Drawing.Point(15, 330);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(137, 15);
            this.Label5.TabIndex = 138;
            this.Label5.Text = "Panchayath  ,  Ward No.";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label4.Location = new System.Drawing.Point(16, 290);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 15);
            this.Label4.TabIndex = 141;
            this.Label4.Text = "Name of Village";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label3.Location = new System.Drawing.Point(16, 250);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 15);
            this.Label3.TabIndex = 140;
            this.Label3.Text = "House Name";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label13.Location = new System.Drawing.Point(673, 64);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(72, 15);
            this.Label13.TabIndex = 135;
            this.Label13.Text = "OP Number";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label1.Location = new System.Drawing.Point(16, 124);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 15);
            this.Label1.TabIndex = 137;
            this.Label1.Text = "Name of Patient";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label2.Location = new System.Drawing.Point(146, 212);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 15);
            this.Label2.TabIndex = 136;
            this.Label2.Text = "Name";
            // 
            // OP_Registration
            // 
            this.AccessibleName = "OP_Registration";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 741);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OP_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OP Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OP_Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ComboBox ctxt_blood;
        internal System.Windows.Forms.ComboBox ctxt_sex;
        internal System.Windows.Forms.TextBox txt_age;
        internal System.Windows.Forms.TextBox txt_op;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_father;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.TextBox txt_post;
        private System.Windows.Forms.TextBox txt_ward;
        private System.Windows.Forms.TextBox txt_panchayath;
        private System.Windows.Forms.TextBox txt_village;
        private System.Windows.Forms.TextBox txt_house;
        private System.Windows.Forms.Button bt_view;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_doctor;
        private System.Windows.Forms.RichTextBox rtxt_other;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.ComboBox ctxt_relation;
        internal System.Windows.Forms.Label Label2;

    }
}