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
    public partial class Discharge : Form
    {
        String atype1, ip1, date1, name1, room1, doctor1;
        int total=0,days;
       
        public Discharge(String atype,String ip,String date,String name,String room,String doctor)
        {
            InitializeComponent();
            if (atype.Equals("Ward"))
            {
               
                Label7.Text = "Bed Number";
                panel3.Hide();
                panel4.Show();

            }
            else
            {
                if (atype.Equals("Room"))
                {
                    Label7.Text = "Room Number";
                    panel4.Hide();
                    panel3.Show();
                }
            }
            label20.Text = ip;
            label27.Text = date;
            label30.Text = name;
            label28.Text = room;
            label29.Text = doctor;
            atype1 = atype;
            ip1 = ip;
            date1 = date;
            name1 = name;
            room1 = room;
            doctor1 = doctor;

                    
        }

        private void Discharge_Bill_Load(object sender, EventArgs e)
        {
            dtp_register.CustomFormat = "dd - MM - yyyy";
            DateTime a;
            
            a = Convert.ToDateTime(date1);
            //String ab = 
            DateTime b = Convert.ToDateTime(dtp_register.Value.ToString("dd - MM - yyyy"));
            label31.Text = (b - a).TotalDays.ToString();
            days = Convert.ToInt32(label31.Text.ToString());
            if (days.Equals(0))
            {
                days = 1;
                label31.Text = "1";
            }
            //dateTimePicker1.CustomFormat = "ddd , MMM , dd , yyyy - hh:mm:ss tt";
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (atype1.Equals("Ward"))
            {

                //Label7.Text = "Bed Number";
                //panel3.Hide();
                //panel4.Show();
                total = total + Convert.ToInt32(textBox31.Text);
                total = total + Convert.ToInt32(textBox30.Text);
                total = total + Convert.ToInt32(textBox3.Text);
                total = total + Convert.ToInt32(textBox2.Text);
                total = total + Convert.ToInt32(textBox29.Text);
                total = total + Convert.ToInt32(textBox27.Text);
                total = total + Convert.ToInt32(textBox28.Text);
                total = total + Convert.ToInt32(textBox5.Text);
                total = total + Convert.ToInt32(textBox26.Text);
                total = total + Convert.ToInt32(textBox25.Text);
                total = total + Convert.ToInt32(textBox24.Text);
                total = total + Convert.ToInt32(textBox6.Text);
                total = total * days;
                if (textBox4.Text.Length.Equals(0))
                {
                    MessageBox.Show("Invalid value on medicine field");
                    total = 0;
                }
                else
                {
                    total = total + Convert.ToInt32(textBox4.Text);
                    //new Karuna.Bill_view(dtp_register.Value.ToString("dd - MM - yyyy"),days.ToString(),atype1, TextBox7.Text, ip1,date1,name1,room1,doctor1,total, textBox31.Text, textBox30.Text, textBox3.Text, textBox2.Text, textBox29.Text, textBox27.Text, textBox28.Text, textBox5.Text, textBox26.Text, textBox25.Text, textBox24.Text, textBox6.Text, textBox4.Text).Show();
                    new PrintWindowsForm.Wprint(TextBox7.Text.ToString(),ip1, name1, date1, doctor1, room1, dtp_register.Value.ToString("dd - MM - yyyy"), days.ToString(), textBox31.Text + " x " + days.ToString(), textBox30.Text + " x " + days.ToString(), textBox3.Text + " x " + days.ToString(), textBox2.Text + " x " + days.ToString(), textBox29.Text + " x " + days.ToString(), textBox27.Text + " x " + days.ToString(), textBox28.Text + " x " + days.ToString(), textBox5.Text + " x " + days.ToString(), textBox26.Text + " x " + days.ToString(), textBox25.Text + " x " + days.ToString(), textBox24.Text + " x " + days.ToString(), textBox6.Text + " x " + days.ToString(), textBox4.Text + " x " + days.ToString(), total.ToString()).Show();
                
                    this.Close();
            
                }
                
            }
            else
            {
                if (atype1.Equals("Room"))
                {
                    //Label7.Text = "Room Number";
                    //panel4.Hide();
                    //panel3.Show();
                    total = total + Convert.ToInt32(textBox17.Text);
                    total = total + Convert.ToInt32(textBox16.Text);
                    total = total + Convert.ToInt32(textBox9.Text);
                    total = total + Convert.ToInt32(textBox8.Text);
                    total = total + Convert.ToInt32(textBox10.Text);
                    total = total + Convert.ToInt32(textBox13.Text);
                    total = total + Convert.ToInt32(textBox11.Text);
                    total = total + Convert.ToInt32(textBox12.Text);
                    total = total + Convert.ToInt32(textBox1.Text);
                    total = total + Convert.ToInt32(textBox18.Text);
                    total = total + Convert.ToInt32(textBox19.Text);
                    total = total + Convert.ToInt32(textBox20.Text);
                    total = total + Convert.ToInt32(textBox21.Text);
                    total = total + Convert.ToInt32(textBox22.Text);
                    total = total + Convert.ToInt32(textBox15.Text);
                    total = total + Convert.ToInt32(textBox14.Text);
                    total = total * days;
                    if (textBox23.Text.Length.Equals(0))
                    {
                        MessageBox.Show("Invalid value on medicine field");
                        total = 0;
                    }
                    else
                    {
                        total = total + Convert.ToInt32(textBox23.Text);
                       // new Karuna.Bill_view(dtp_register.Value.ToString("dd - MM - yyyy"),days.ToString(),atype1,TextBox7.Text, ip1, date1, name1, room1, doctor1, total, textBox17.Text, textBox16.Text, textBox9.Text, textBox8.Text, textBox10.Text, textBox13.Text, textBox11.Text, textBox12.Text, textBox1.Text, textBox18.Text, textBox19.Text, textBox20.Text, textBox21.Text, textBox22.Text, textBox15.Text, textBox14.Text, textBox23.Text).Show();
                        new PrintWindowsForm.Rprint(TextBox7.Text.ToString(), ip1, name1, date1, doctor1, room1, dtp_register.Value.ToString("dd - MM - yyyy"), days.ToString(), textBox17.Text + " x " + days.ToString(), textBox16.Text + " x " + days.ToString(), textBox9.Text + " x " + days.ToString(), textBox8.Text + " x " + days.ToString(), textBox10.Text + " x " + days.ToString(), textBox13.Text + " x " + days.ToString(), textBox11.Text + " x " + days.ToString(), textBox12.Text + " x " + days.ToString(), textBox1.Text + " x " + days.ToString(), textBox18.Text + " x " + days.ToString(), textBox19.Text + " x " + days.ToString(), textBox20.Text + " x " + days.ToString(), textBox21.Text + " x " + days.ToString(), textBox22.Text + " x " + days.ToString(), textBox15.Text + " x " + days.ToString(), textBox14.Text + " x " + days.ToString(), textBox23.Text + " x " + days.ToString(), total.ToString()).Show();
                
                        this.Close();

                    }
                }
            }
        }
    }
}
