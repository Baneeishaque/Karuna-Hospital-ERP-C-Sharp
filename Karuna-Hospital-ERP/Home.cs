using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using PrintForm;
//using PrintForm;

namespace Karuna
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bt_op_Click(object sender, EventArgs e)
        {
            new Karuna.OP_Registration().Visible = true;   
        }

        private void bt_ip_Click(object sender, EventArgs e)
        {
            new Karuna.IP_Registration().Visible = true;
        }

        private void bt_discharge_Click(object sender, EventArgs e)
        {
            //new Karuna.Discharge_Bill().Visible = true;
        }

        private void bt_room_Click(object sender, EventArgs e)
        {
            new Karuna.Rooms().Show();
        }

        private void bt_bill_view_Click(object sender, EventArgs e)
        {
            new Karuna.Bills().Visible = true;
        }

        private void bt_op_view_Click(object sender, EventArgs e)
        {
            new Karuna.OP_list().Show();
        }

        private void bt_admission_view_Click(object sender, EventArgs e)
        {
            new Karuna.Admission_Details().Visible = true;
        }

        private void bt_about_Click(object sender, EventArgs e)
        {
            new Karuna.About_Us().ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dtp_register.CustomFormat = "ddd , MMM , dd , yyyy - hh:mm:ss tt";
        }

        private void bt_backup_Click(object sender, EventArgs e)
        {
            new Karuna.Print().Visible = true;
           //new PrintForm.Test().Visible = true;
        }

        private void bt_ip_view_Click(object sender, EventArgs e)
        {
            new Karuna.IP_list().Show();
        }

        private void bt_discharge_Click_1(object sender, EventArgs e)
        {
            new Karuna.IP_Search().Show();
        }

        
    }
}
