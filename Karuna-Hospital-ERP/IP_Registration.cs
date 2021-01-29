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
    public partial class IP_Registration : Form
    {
        int flag = 0;
        int cflag = 0;
        String atype1, room_bed1, aother1;
        String op1;
        public IP_Registration()
        {
            InitializeComponent();
            dtp.CustomFormat = "dd - MM - yyyy";
            ctxt_sex.SelectedItem = "Male";
            ctxt_blood.SelectedItem = "A +";
            ctxt_relation.SelectedItem = "Father";
        }

         public IP_Registration(String ip, String name, String age, String sex, String blood,String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department)
        {

            InitializeComponent();

            dtp.CustomFormat = "dd - MM - yyyy";

            txt_ip.Text = ip;
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

         public IP_Registration(String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department)
         {

             InitializeComponent();

             dtp.CustomFormat = "dd - MM - yyyy";

          
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

         public IP_Registration(String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department,String op,String type)
         {

             InitializeComponent();

             dtp.CustomFormat = "dd - MM - yyyy";

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
                 op1 = op;
                 cflag = 1;

            
             
         }

         public IP_Registration(String ip,String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department, String op, String type)
         {

             InitializeComponent();

             dtp.CustomFormat = "dd - MM - yyyy";
             txt_ip.Text = ip;
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
             op1 = op;
             cflag = 1;



         }


         public IP_Registration(String ip, String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department,String atype,String room_bed,String aother)
         {

             InitializeComponent();

             dtp.CustomFormat = "dd - MM - yyyy";

             txt_ip.Text = ip;
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

             flag = 1;
             atype1 = atype;
             room_bed1 = room_bed;
             aother1 = aother;

         }

        private void IP_Registration_Load(object sender, EventArgs e)
        {
            dtp.CustomFormat = "dd - MM - yyyy";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Karuna.Admission_Details().Visible = true;
            this.Hide();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if(cflag!=1)
            {
                if (flag != 1)
                {
                    new Karuna.Admission_Details(dtp.Value.ToString("dd - MM - yyyy"), txt_ip.Text, txt_name.Text, txt_age.Text, ctxt_sex.SelectedItem.ToString(), ctxt_blood.SelectedItem.ToString(), ctxt_relation.SelectedItem.ToString(), txt_father.Text, txt_house.Text, txt_village.Text, txt_panchayath.Text, txt_ward.Text, txt_post.Text, txt_pin.Text, txt_phone.Text, txt_mobile.Text, rtxt_other.Text, txt_doctor.Text, txt_department.Text).Show();

                }
                else
                {
                    if (flag == 1)
                    {
                        new Karuna.Admission_Details(dtp.Value.ToString("dd - MM - yyyy"), txt_ip.Text, txt_name.Text, txt_age.Text, ctxt_sex.SelectedItem.ToString(), ctxt_blood.SelectedItem.ToString(), ctxt_relation.SelectedItem.ToString(), txt_father.Text, txt_house.Text, txt_village.Text, txt_panchayath.Text, txt_ward.Text, txt_post.Text, txt_pin.Text, txt_phone.Text, txt_mobile.Text, rtxt_other.Text, txt_doctor.Text, txt_department.Text, atype1, room_bed1, aother1).Show();

                    }
                }
            }
            else
            {
                new Karuna.Admission_Details(dtp.Value.ToString("dd - MM - yyyy"), txt_ip.Text, txt_name.Text, txt_age.Text, ctxt_sex.SelectedItem.ToString(), ctxt_blood.SelectedItem.ToString(), ctxt_relation.SelectedItem.ToString(), txt_father.Text, txt_house.Text, txt_village.Text, txt_panchayath.Text, txt_ward.Text, txt_post.Text, txt_pin.Text, txt_phone.Text, txt_mobile.Text, rtxt_other.Text, txt_doctor.Text, txt_department.Text, op1).Show();
            }
            
            this.Close();
        }

        private void conversion_Click(object sender, EventArgs e)
        {
            new Karuna.OP_search().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
