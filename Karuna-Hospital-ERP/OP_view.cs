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
    public partial class OP_view : Form
    {
        String date1,op1, name1, age1, sex1, blood1, relation1,father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1;

        MyDBhandler d = new MyDBhandler();
        
        public OP_view()
        {
            InitializeComponent();
        }

        public OP_view(String date,String op,String name,String age,String sex,String blood,String relation,String father,String house,String village,String panchayath,
            String ward,String post,String pin,String phone,String mobile,String other,String doctor,String department)
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

            label8.Text = date;
            label9.Text = op;
            label12.Text = name;
            label29.Text = age+" , "+sex+" , "+blood;
            Label2.Text = relation + " Name";
            label28.Text = father;
            label27.Text = house;
            label26.Text = village;
            label25.Text = panchayath+" , "+ward;
            label24.Text = post+" , "+pin;
            label23.Text = phone;
            label22.Text = mobile;
            label21.Text = other;
            label20.Text = doctor;
            label19.Text = department;
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            new Karuna.OP_Registration(op1, name1, age1, sex1, blood1,relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1).Visible = true;
            this.Close();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            
            try
            {
               d.Ins_Up_Del("INSERT INTO `op`(`date`, `no`, `name`, `age`, `sex`, `blood`,`relation`, `father`, `house`, `village`, `panchayath`, `ward`, `post`, `pin`, `phone`, `mobile`, `other`, `doctor`, `department`) VALUES ('" + date1 + "', '" + op1 + "', '" + name1 + "','" + age1 + "','" + sex1 + "','" + blood1 + "', '" + relation1 + "', '" + father1 + "', '" + house1 + "', '" + village1 + "', '" + panchayath1 + "', '" + ward1 + "', '" + post1 + "', '" + pin1 + "', '" + phone1 + "', '" + mobile1 + "', '" + other1 + "', '" + doctor1 + "', '" + department1 + "')");

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);

            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OP_view_Load(object sender, EventArgs e)
        {

        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            //new PrintForm.Test().Show();  
            //new Printing.MainForm().Show();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
