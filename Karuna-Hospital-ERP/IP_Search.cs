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
    public partial class IP_Search : Form
    {
        MyDBhandler DH = new MyDBhandler();
        int flag = 0;
        String date1,name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1,atype1,room_bed1,aother1;
        
        public IP_Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag != 1)
            {
                DataTable dt1 = DH.GetTable("SELECT * FROM `ip` WHERE `no`='" + txt_op.Text + "'");
                if (dt1.Rows.Count > 0)
                {
                    label8.Text = dt1.Rows[0]["date"].ToString();
                    date1 = dt1.Rows[0]["date"].ToString();
                    label12.Text = dt1.Rows[0]["name"].ToString();
                    name1 = dt1.Rows[0]["name"].ToString();
                    label29.Text = dt1.Rows[0]["age"].ToString() + " , " + dt1.Rows[0]["sex"].ToString() + " , " + dt1.Rows[0]["blood"].ToString();
                    age1 = dt1.Rows[0]["age"].ToString();
                    sex1 = dt1.Rows[0]["sex"].ToString();
                    blood1 = dt1.Rows[0]["blood"].ToString();

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
                    ward1 = dt1.Rows[0]["ward"].ToString();

                    label24.Text = dt1.Rows[0]["post"].ToString() + " , " + dt1.Rows[0]["pin"].ToString();
                    post1 = dt1.Rows[0]["post"].ToString();
                    pin1 = dt1.Rows[0]["pin"].ToString();

                    label23.Text = dt1.Rows[0]["phone"].ToString();
                    phone1 = dt1.Rows[0]["phone"].ToString();

                    label22.Text = dt1.Rows[0]["mobile"].ToString();
                    mobile1 = dt1.Rows[0]["mobile"].ToString();

                    label21.Text = dt1.Rows[0]["other"].ToString();
                    other1 = dt1.Rows[0]["other"].ToString();
                    label20.Text = dt1.Rows[0]["doctor"].ToString();
                    doctor1 = dt1.Rows[0]["doctor"].ToString();
                    label19.Text = dt1.Rows[0]["department"].ToString();
                    department1 = dt1.Rows[0]["department"].ToString();
                    label18.Text = dt1.Rows[0]["atype"].ToString();
                    atype1 = dt1.Rows[0]["atype"].ToString(); ;
                    
                    if(atype1.Equals("Ward"))
                    {
                        label31.Text = "Bed Number";
                    }
                    else
                    {
                        if (atype1.Equals("Room"))
                        {
                            label31.Text = "Room Number";
                        }
                    }
                    label32.Text = dt1.Rows[0]["room_bed"].ToString();
                    room_bed1 = dt1.Rows[0]["room_bed"].ToString();
                    label34.Text = dt1.Rows[0]["aother"].ToString();
                    aother1 = dt1.Rows[0]["aother"].ToString();
                    
                    flag = 1;
                    panel2.Hide();
                    // txt_op.Text = "";
                    panel1.Show();
                    panel3.Show();



                }

                else
                {

                    MessageBox.Show("Invalid User or Key! ");
                }
            }
            else
            {
                new Karuna.IP_Registration(name1, age1, sex1, blood1, relation1, father1, house1, village1, panchayath1, ward1, post1, pin1, phone1, mobile1, other1, doctor1, department1, txt_op.Text, "Conversion").Visible = true;
                this.Close();
            }
            
        }

        private void IP_Search_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Hide();
            // txt_op.Text = "";
            panel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Hide();
            txt_op.Text = "";
            panel2.Show();
            flag = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Karuna.Discharge(atype1,txt_op.Text.ToString(),date1,name1,room_bed1,doctor1).Show();
            this.Close();
        }
    }
}
