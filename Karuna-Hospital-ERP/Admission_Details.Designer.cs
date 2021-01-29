namespace Karuna
{
    partial class Admission_Details
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
            this.ctxt_type = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_cancelw = new System.Windows.Forms.Button();
            this.bt_returnw = new System.Windows.Forms.Button();
            this.bt_gow = new System.Windows.Forms.Button();
            this.rtxtw_other = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bed = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_gor = new System.Windows.Forms.Button();
            this.bt_returnr = new System.Windows.Forms.Button();
            this.bt_cancelr = new System.Windows.Forms.Button();
            this.rtxr_other = new System.Windows.Forms.RichTextBox();
            this.txt_room = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.ctxt_type);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 410);
            this.panel1.TabIndex = 0;
            // 
            // ctxt_type
            // 
            this.ctxt_type.FormattingEnabled = true;
            this.ctxt_type.Items.AddRange(new object[] {
            "Ward",
            "Room"});
            this.ctxt_type.Location = new System.Drawing.Point(158, 65);
            this.ctxt_type.Name = "ctxt_type";
            this.ctxt_type.Size = new System.Drawing.Size(121, 21);
            this.ctxt_type.TabIndex = 37;
            this.ctxt_type.SelectedIndexChanged += new System.EventHandler(this.combo_type_select);
            this.ctxt_type.SelectedValueChanged += new System.EventHandler(this.combo_type_select);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 15);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Admission Type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_cancelw);
            this.panel3.Controls.Add(this.bt_returnw);
            this.panel3.Controls.Add(this.bt_gow);
            this.panel3.Controls.Add(this.rtxtw_other);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_bed);
            this.panel3.Controls.Add(this.Label11);
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 325);
            this.panel3.TabIndex = 44;
            // 
            // bt_cancelw
            // 
            this.bt_cancelw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelw.Location = new System.Drawing.Point(364, 195);
            this.bt_cancelw.Name = "bt_cancelw";
            this.bt_cancelw.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelw.TabIndex = 42;
            this.bt_cancelw.Text = "Cancel";
            this.bt_cancelw.UseVisualStyleBackColor = true;
            this.bt_cancelw.Click += new System.EventHandler(this.bt_cancelr_Click);
            // 
            // bt_returnw
            // 
            this.bt_returnw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_returnw.Location = new System.Drawing.Point(283, 195);
            this.bt_returnw.Name = "bt_returnw";
            this.bt_returnw.Size = new System.Drawing.Size(75, 23);
            this.bt_returnw.TabIndex = 41;
            this.bt_returnw.Text = "Return";
            this.bt_returnw.UseVisualStyleBackColor = true;
            this.bt_returnw.Click += new System.EventHandler(this.bt_returnr_Click);
            // 
            // bt_gow
            // 
            this.bt_gow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gow.Location = new System.Drawing.Point(202, 195);
            this.bt_gow.Name = "bt_gow";
            this.bt_gow.Size = new System.Drawing.Size(75, 23);
            this.bt_gow.TabIndex = 40;
            this.bt_gow.Text = "Go";
            this.bt_gow.UseVisualStyleBackColor = true;
            this.bt_gow.Click += new System.EventHandler(this.bt_gor_Click);
            // 
            // rtxtw_other
            // 
            this.rtxtw_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtw_other.Location = new System.Drawing.Point(158, 111);
            this.rtxtw_other.Name = "rtxtw_other";
            this.rtxtw_other.Size = new System.Drawing.Size(335, 59);
            this.rtxtw_other.TabIndex = 39;
            this.rtxtw_other.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Other Details";
            // 
            // txt_bed
            // 
            this.txt_bed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bed.Location = new System.Drawing.Point(154, 38);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.Size = new System.Drawing.Size(337, 21);
            this.txt_bed.TabIndex = 38;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(11, 41);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(77, 15);
            this.Label11.TabIndex = 37;
            this.Label11.Text = "Bed Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_gor);
            this.panel2.Controls.Add(this.bt_returnr);
            this.panel2.Controls.Add(this.bt_cancelr);
            this.panel2.Controls.Add(this.rtxr_other);
            this.panel2.Controls.Add(this.txt_room);
            this.panel2.Controls.Add(this.Label6);
            this.panel2.Controls.Add(this.Label4);
            this.panel2.Location = new System.Drawing.Point(3, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 325);
            this.panel2.TabIndex = 43;
            // 
            // bt_gor
            // 
            this.bt_gor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gor.Location = new System.Drawing.Point(188, 195);
            this.bt_gor.Name = "bt_gor";
            this.bt_gor.Size = new System.Drawing.Size(75, 23);
            this.bt_gor.TabIndex = 40;
            this.bt_gor.Text = "Go";
            this.bt_gor.UseVisualStyleBackColor = true;
            this.bt_gor.Click += new System.EventHandler(this.bt_gor_Click);
            // 
            // bt_returnr
            // 
            this.bt_returnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_returnr.Location = new System.Drawing.Point(284, 195);
            this.bt_returnr.Name = "bt_returnr";
            this.bt_returnr.Size = new System.Drawing.Size(75, 23);
            this.bt_returnr.TabIndex = 41;
            this.bt_returnr.Text = "Return";
            this.bt_returnr.UseVisualStyleBackColor = true;
            this.bt_returnr.Click += new System.EventHandler(this.bt_returnr_Click);
            // 
            // bt_cancelr
            // 
            this.bt_cancelr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelr.Location = new System.Drawing.Point(376, 195);
            this.bt_cancelr.Name = "bt_cancelr";
            this.bt_cancelr.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelr.TabIndex = 42;
            this.bt_cancelr.Text = "Cancel";
            this.bt_cancelr.UseVisualStyleBackColor = true;
            this.bt_cancelr.Click += new System.EventHandler(this.bt_cancelr_Click);
            // 
            // rtxr_other
            // 
            this.rtxr_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxr_other.Location = new System.Drawing.Point(157, 109);
            this.rtxr_other.Name = "rtxr_other";
            this.rtxr_other.Size = new System.Drawing.Size(335, 59);
            this.rtxr_other.TabIndex = 39;
            this.rtxr_other.Text = "";
            // 
            // txt_room
            // 
            this.txt_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room.Location = new System.Drawing.Point(157, 31);
            this.txt_room.Name = "txt_room";
            this.txt_room.Size = new System.Drawing.Size(335, 21);
            this.txt_room.TabIndex = 38;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(10, 126);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 15);
            this.Label6.TabIndex = 43;
            this.Label6.Text = "Other Details";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(10, 38);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(89, 15);
            this.Label4.TabIndex = 44;
            this.Label4.Text = "Room Number";
            // 
            // Admission_Details
            // 
            this.AccessibleName = "Admission_Details";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 434);
            this.Controls.Add(this.panel1);
            this.Name = "Admission_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admission Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admission_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox txt_bed;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox txt_room;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button bt_gor;
        internal System.Windows.Forms.Button bt_returnr;
        internal System.Windows.Forms.Button bt_cancelr;
        internal System.Windows.Forms.RichTextBox rtxr_other;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button bt_cancelw;
        internal System.Windows.Forms.Button bt_returnw;
        internal System.Windows.Forms.Button bt_gow;
        internal System.Windows.Forms.RichTextBox rtxtw_other;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ctxt_type;

    }
}