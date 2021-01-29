using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Karuna
{
    public partial class OP_Registration : Form
    {
        
        
        public OP_Registration()
        {
            InitializeComponent();
          //  dtp.CustomFormat = "ddd , MMM , dd , yyyy - hh:mm:ss tt";
            ctxt_sex.SelectedItem = "Male";
            ctxt_blood.SelectedItem = "A +";
            ctxt_relation.SelectedItem = "Father";
            
        }

        public OP_Registration(String op, String name, String age, String sex, String blood,String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department)
        {

            InitializeComponent();

           // dtp.CustomFormat = "ddd , MMM , dd , yyyy - hh:mm:ss tt";

            txt_op.Text = op;
            txt_name.Text = name;
            txt_age.Text = age;
            ctxt_sex.SelectedItem = sex;
            ctxt_blood.SelectedItem = blood;
            ctxt_relation.SelectedItem = relation;
            txt_father.Text = father;
            txt_house.Text = house;
            txt_village.Text = village;
            txt_panchayath.Text = panchayath;
            txt_ward.Text = ward;
            txt_post.Text = post;
            txt_pin.Text = pin;
            txt_phone.Text = phone;
            txt_doctor.Text = mobile;
            rtxt_other.Text = other;
            txt_department.Text = doctor;
            txt_mobile.Text = department;

        }


        private void OP_Registration_Load(object sender, EventArgs e)
        {

            //dtp.CustomFormat = "ddd , MMM , dd , yyyy - hh:mm:ss tt";
           
            
            
        }

      
       
        private void bt_view_Click(object sender, EventArgs e)
        {
             new Karuna.OP_view(dtp.Value.ToString("ddd , MMM , dd , yyyy - hh:mm:ss tt"), txt_op.Text, txt_name.Text, txt_age.Text,ctxt_sex.SelectedItem.ToString(),ctxt_blood.SelectedItem.ToString(),ctxt_relation.SelectedItem.ToString(), txt_father.Text, txt_house.Text, txt_village.Text, txt_panchayath.Text,txt_ward.Text, txt_post.Text,txt_pin.Text, txt_phone.Text, txt_mobile.Text, rtxt_other.Text, txt_doctor.Text, txt_department.Text).Visible = true;
            this.Close();
            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
        private void bt_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
