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
    public partial class Admission_Details : Form
    {
        String date1, ip1, name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1;
        String room_bed,aother;
        String opn1;
        int cflag = 0;
       
        public Admission_Details()
        {
            InitializeComponent();
            
        }

        public Admission_Details(String date, String ip, String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath,
            String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department)
        {
            InitializeComponent();
            date1 = date;
            ip1 = ip;
            name1 = name;
            age1 = age;
            sex1 = sex;
            blood1 = blood;
            relation1 = relation;
            father1 = father;
            house1 = house;
            village1 = village;
            panchayath1 = panchayath;
            ward1 = ward;
            post1 = post;
            pin1 = pin;
            phone1 = phone;
            mobile1 = mobile;
            other1 = other;
            doctor1 = doctor;
            department1 = department;
            ctxt_type.SelectedItem = "Ward";
            panel2.Hide();

        }

        public Admission_Details(String date, String ip, String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath,
            String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department,String opn)
        {
            InitializeComponent();
            date1 = date;
            ip1 = ip;
            name1 = name;
            age1 = age;
            sex1 = sex;
            blood1 = blood;
            relation1 = relation;
            father1 = father;
            house1 = house;
            village1 = village;
            panchayath1 = panchayath;
            ward1 = ward;
            post1 = post;
            pin1 = pin;
            phone1 = phone;
            mobile1 = mobile;
            other1 = other;
            doctor1 = doctor;
            department1 = department;
            opn1 = opn;
            cflag = 1;
            ctxt_type.SelectedItem = "Ward";
            panel2.Hide();

        }

        public Admission_Details(String date, String ip, String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath,
           String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department,String atype,String room_bed,String aother)
        {
            InitializeComponent();
            date1 = date;
            ip1 = ip;
            name1 = name;
            age1 = age;
            sex1 = sex;
            blood1 = blood;
            relation1 = relation;
            father1 = father;
            house1 = house;
            village1 = village;
            panchayath1 = panchayath;
            ward1 = ward;
            post1 = post;
            pin1 = pin;
            phone1 = phone;
            mobile1 = mobile;
            other1 = other;
            doctor1 = doctor;
            department1 = department;

            if(atype.Equals("Ward"))
            {
                ctxt_type.SelectedItem = "Ward";
                txt_bed.Text = room_bed;
                rtxtw_other.Text = aother;
                panel2.Hide();
                panel3.Show();
            }
            else
            {
                if (atype.Equals("Room"))
                {
                    ctxt_type.SelectedItem = "Room";
                    txt_room.Text = room_bed;
                    rtxr_other.Text = aother;
                    
                    panel3.Hide();
                    panel2.Show();
                }
            }

        }

        private void Admission_Details_Load(object sender, EventArgs e)
        {
        
           // dtpr.CustomFormat = "ddd , MMM , dd , yyyy - hh:mm:ss tt";
            //dtpw.CustomFormat = "ddd , MMM , dd , yyyy - hh:mm:ss tt";
           

        }

        private void combo_type_select(object sender, EventArgs e)
        {
     
            if (ctxt_type.SelectedItem.ToString().Equals("Ward"))
            {
                panel2.Hide();
                panel3.Show();
            }
            if (ctxt_type.SelectedItem.ToString().Equals("Room"))
            {
                panel3.Hide();
                panel2.Show();
            }
        }

       

        private void bt_cancelr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_returnr_Click(object sender, EventArgs e)
        {
            if(cflag!=1)
            {
                new Karuna.IP_Registration(ip1, name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1).Visible = true;
         
            }
            else
            {
                new Karuna.IP_Registration(ip1,name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1, opn1, "Conversion").Visible = true;
                
            }
            this.Close();
        }

        private void bt_gor_Click(object sender, EventArgs e)
        {
            if(ctxt_type.SelectedItem.ToString().Equals("Ward"))
            {
                room_bed = txt_bed.Text;
                aother = rtxtw_other.Text;
            }
            else
            {
                if (ctxt_type.SelectedItem.ToString().Equals("Room"))
                {
                    room_bed = txt_room.Text;
                    aother = rtxr_other.Text;
                }
            }

            if(cflag!=1)
            {
                new Karuna.IP_View(date1, ip1, name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1, ctxt_type.SelectedItem.ToString(), room_bed, aother).Show();
            
            }
            else
            {
                new Karuna.IP_View(date1, ip1, name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1, ctxt_type.SelectedItem.ToString(), room_bed, aother,opn1).Show();
            
            }
           
            this.Close();
        }
    }
}
