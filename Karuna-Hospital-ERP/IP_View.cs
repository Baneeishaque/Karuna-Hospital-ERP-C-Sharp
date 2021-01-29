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
    public partial class IP_View : Form
    {
        String date1, op1, name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1;
        String atype1, room_bed1, aother1;
        String opn1;
        int cflag = 0;

        MyDBhandler d = new MyDBhandler();
        
        public IP_View(String date,String op, String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department,String atype,String room_bed,String aother)
        {
            InitializeComponent();

            date1 = date;
            op1 = op;
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
            atype1 = atype;
            room_bed1 = room_bed;
            aother1 = aother;

            label8.Text = date;
            label9.Text = op;
            label12.Text = name;
            label29.Text = age + " , " + sex + " , " + blood;
            Label2.Text = relation + " Name";
            label28.Text = father;
            label27.Text = house;
            label26.Text = village;
            label25.Text = panchayath + " , " + ward;
            label24.Text = post + " , " + pin;
            label23.Text = phone;
            label22.Text = mobile;
            label21.Text = other;
            label20.Text = doctor;
            label19.Text = department;
            label18.Text = atype;
            label34.Text = aother;
            if(atype.Equals("Ward"))
            {
                label31.Text = "Bed Number";
            }
            else
            {
                if (atype.Equals("Room"))
                {
                    label31.Text = "Room Number";
                }
            }
            label32.Text = room_bed;
        }

        public IP_View(String date, String op, String name, String age, String sex, String blood, String relation, String father, String house, String village, String panchayath, String ward, String post, String pin, String phone, String mobile, String other, String doctor, String department, String atype, String room_bed, String aother,String opn)
        {
            InitializeComponent();

            date1 = date;
            op1 = op;
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
            atype1 = atype;
            room_bed1 = room_bed;
            aother1 = aother;

            opn1 = opn;
            cflag = 1;

            label8.Text = date;
            label9.Text = op;
            label12.Text = name;
            label29.Text = age + " , " + sex + " , " + blood;
            Label2.Text = relation + " Name";
            label28.Text = father;
            label27.Text = house;
            label26.Text = village;
            label25.Text = panchayath + " , " + ward;
            label24.Text = post + " , " + pin;
            label23.Text = phone;
            label22.Text = mobile;
            label21.Text = other;
            label20.Text = doctor;
            label19.Text = department;
            label18.Text = atype;
            label34.Text = aother;
            if (atype.Equals("Ward"))
            {
                label31.Text = "Bed Number";
            }
            else
            {
                if (atype.Equals("Room"))
                {
                    label31.Text = "Room Number";
                }
            }
            label32.Text = room_bed;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bt_returnip_Click(object sender, EventArgs e)
        {
            new Karuna.IP_Registration(op1, name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1,atype1,room_bed1,aother1).Visible = true;
            this.Close();
        }

        private void bt_returnadmission_Click(object sender, EventArgs e)
        {
            new Karuna.Admission_Details(date1,op1, name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1, atype1, room_bed1, aother1).Visible = true;
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            if(cflag!=1)
            {
                
                try
                {
                    d.Ins_Up_Del("INSERT INTO `ip`(`date`, `no`, `name`, `age`, `sex`, `blood`,`relation`, `father`, `house`, `village`, `panchayath`, `ward`, `post`, `pin`, `phone`, `mobile`, `other`, `doctor`, `department`,`atype`,`room_bed`,`aother`) VALUES ('" + date1 + "', '" + op1 + "', '" + name1 + "','" + age1 + "','" + sex1 + "','" + blood1 + "', '" + relation1 + "', '" + father1 + "', '" + house1 + "', '" + village1 + "', '" + panchayath1 + "', '" + ward1 + "', '" + post1 + "', '" + pin1 + "', '" + phone1 + "', '" + mobile1 + "', '" + other1 + "', '" + doctor1 + "', '" + department1 + "', '" + atype1 + "', '" + room_bed1 + "', '" + aother1 + "')");

                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + ex.Message);

                }
            }
            else
            {
                try
                {
                    other1 = "Converted from OP No. " + opn1 + " at " + date1+" , "+other1;
                    d.Ins_Up_Del("INSERT INTO `ip`(`date`, `no`, `name`, `age`, `sex`, `blood`,`relation`, `father`, `house`, `village`, `panchayath`, `ward`, `post`, `pin`, `phone`, `mobile`, `other`, `doctor`, `department`,`atype`,`room_bed`,`aother`) VALUES ('" + date1 + "', '" + op1 + "', '" + name1 + "','" + age1 + "','" + sex1 + "','" + blood1 + "', '" + relation1 + "', '" + father1 + "', '" + house1 + "', '" + village1 + "', '" + panchayath1 + "', '" + ward1 + "', '" + post1 + "', '" + pin1 + "', '" + phone1 + "', '" + mobile1 + "', '" + other1 + "', '" + doctor1 + "', '" + department1 + "', '" + atype1 + "', '" + room_bed1 + "', '" + aother1 + "')");
                  //  d.Ins_Up_Del("DELETE FROM `op` WHERE `no`='"+opn1+"'");
                    
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + ex.Message);

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
