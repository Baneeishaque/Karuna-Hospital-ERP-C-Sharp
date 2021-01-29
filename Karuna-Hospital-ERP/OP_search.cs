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
    public partial class OP_search : Form
    {
        MyDBhandler DH = new MyDBhandler();
        int flag = 0;
        String name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1;
        
        
        public OP_search()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(flag!=1)
            {
                DataTable dt1 = DH.GetTable("SELECT * FROM `op` WHERE `no`='" + txt_op.Text + "'");
                if (dt1.Rows.Count > 0)
                {
                    label8.Text = dt1.Rows[0]["date"].ToString();

                    label12.Text = dt1.Rows[0]["name"].ToString();
                    name1 = dt1.Rows[0]["name"].ToString();
                    label29.Text = dt1.Rows[0]["age"].ToString() + " , " + dt1.Rows[0]["sex"].ToString() + " , " + dt1.Rows[0]["blood"].ToString();
                    age1 = dt1.Rows[0]["age"].ToString();
                    sex1 = dt1.Rows[0]["sex"].ToString();
                    blood1 =dt1.Rows[0]["blood"].ToString();
                    
                    Label2.Text = dt1.Rows[0]["relation"].ToString() + " Name";
                    relation1 = dt1.Rows[0]["relation"].ToString();

                    label28.Text = dt1.Rows[0]["father"].ToString();
                    father1 = dt1.Rows[0]["father"].ToString();
                    
                    label27.Text = dt1.Rows[0]["house"].ToString();
                    house1 = dt1.Rows[0]["house"].ToString();
                    label26.Text = dt1.Rows[0]["village"].ToString();
                    village1 = dt1.Rows[0]["village"].ToString();
                    label25.Text = dt1.Rows[0]["panchayath"].ToString() + " , " + dt1.Rows[0]["ward"].ToString();
                    panchayath1 = dt1.Rows[0]["panchayath"].ToString();
                    ward1 =dt1.Rows[0]["ward"].ToString();
                    
                    label24.Text = dt1.Rows[0]["post"].ToString() + " , " + dt1.Rows[0]["pin"].ToString();
                    post1 = dt1.Rows[0]["post"].ToString();
                    pin1 = dt1.Rows[0]["pin"].ToString();
                    
                    label23.Text = dt1.Rows[0]["phone"].ToString();
                    phone1 = dt1.Rows[0]["phone"].ToString();
                    
                    label22.Text = dt1.Rows[0]["mobile"].ToString();
                    mobile1=dt1.Rows[0]["mobile"].ToString();
                    
                    label21.Text = dt1.Rows[0]["other"].ToString();
                    other1 = dt1.Rows[0]["other"].ToString();
                    label20.Text = dt1.Rows[0]["doctor"].ToString();
                    doctor1 = dt1.Rows[0]["doctor"].ToString();
                    label19.Text = dt1.Rows[0]["department"].ToString();
                    department1 = dt1.Rows[0]["department"].ToString();
                    flag = 1;
                    panel2.Hide();
                    // txt_op.Text = "";
                    panel1.Show();
                   


                }

                else
                {

                    MessageBox.Show("Invalid User or Key! ");
                }
            }
            else
            {
                new Karuna.IP_Registration(name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1,txt_op.Text,"Conversion").Visible = true;
                this.Close();
            }
            
        }

        private void OP_search_Load(object sender, EventArgs e)
        {
            panel1.Hide();
           // txt_op.Text = "";
            panel2.Show();
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            txt_op.Text = "";
            panel2.Show();
            flag = 0;
        }
    }
}
