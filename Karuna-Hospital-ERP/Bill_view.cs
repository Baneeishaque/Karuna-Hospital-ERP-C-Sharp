using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using 

namespace Karuna
{
    public partial class Bill_view : Form
    {
        String atype1;
        public Bill_view(String dis,String days,String atype,String no,String ip1, String date1, String name1, String room1, String doctor1, int total, String t31, String t30, String t3, String t2, String t29, String t27, String t28, String t5, String t26, String t25, String t24, String t6, String t4)
        {
            InitializeComponent();
           
                Label7.Text = "Bed Number";
                label20.Text = ip1;
                label27.Text = date1;
                label30.Text = name1;
                label28.Text = room1;
                label29.Text = doctor1;
                label72.Text = no;
                label31.Text = days;
                label45.Text = dis;
                

                panel3.Hide();
                label57.Text = t31 + " x " + days;
                label50.Text = t30 + " x " + days;
                label56.Text = t3 + " x " + days;
                label49.Text = t2 + " x " + days;
                label55.Text = t29 + " x " + days;
                label48.Text = t27 + " x " + days;
                label54.Text = t28 + " x " + days;
                label47.Text = t5 + " x " + days;
                label53.Text = t26 + " x " + days;
                label46.Text = t25 + " x " + days;
                label52.Text = t24 + " x " + days;
                label58.Text = t6 + " x " + days;
                label51.Text = t4;

                atype1 = atype;
                label60.Text = total.ToString();
                panel4.Show();

          
            
        }

        public Bill_view(String dis, String days, String atype, String no, String ip1, String date1, String name1, String room1, String doctor1, int total, String t17, String t16, String t9, String t8, String t10, String t13, String t11, String t12, String t1, String t18, String t19, String t20, String t21, String t22, String t15, String t14, String t23)
        {
            InitializeComponent();
                    Label7.Text = "Room Number";
                    label20.Text = ip1;
                    label27.Text = date1;
                    label30.Text = name1;
                    label28.Text = room1;
                    label29.Text = doctor1;
                    label72.Text = no;
                    label31.Text = days;
                    label45.Text = dis;

                    panel4.Hide();
                    label71.Text = t17 + " x " + days;
                    label62.Text = t16 + " x " + days;
                    label70.Text = t9 + " x " + days;
                    label61.Text = t8 + " x " + days;
                    label69.Text = t10 + " x " + days;
                    label80.Text = t13 + " x " + days;
                    label68.Text = t11 + " x " + days;
                    label79.Text = t12 + " x " + days;
                    label67.Text = t1 + " x " + days;
                    label78.Text = t18 + " x " + days;
                    label66.Text = t19 + " x " + days;
                    label77.Text = t20 + " x " + days;
                    label65.Text = t21 + " x " + days;
                    label76.Text = t22 + " x " + days;
                    label64.Text = t15 + " x " + days;
                    label75.Text = t14 + " x " + days;
                    label63.Text = t23;

                    atype1 = atype;
                    label73.Text = total.ToString();
                
                    panel3.Show();
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Printing.MainForm().Show();
            if (atype1.Equals("Ward"))
            {
                //new Karuna.Wprint().Show();
                //new Printform.Wprint(label20.Text.ToString(), label30.Text.ToString(), label27.Text.ToString(), label29.Text.ToString(), label28.Text.ToString(), label45.Text.ToString(), label31.Text.ToString(), label57.Text.ToString(), label50.Text.ToString(), label56.Text.ToString(), label49.Text.ToString(), label55.Text.ToString(), label48.Text.ToString(), label54.Text.ToString(), label47.Text.ToString(), label53.Text.ToString(), label46.Text.ToString(), label52.Text.ToString(), label58.Text.ToString(), label51.Text.ToString(), label60.Text.ToString()).Show();
                this.Close();
            }
            else
            {
                if (atype1.Equals("Room"))
                {
                    //new Karuna.Discharge_Bill().Show();
                    //new Printform.Rprint(TextBox7.Text.ToString(), label20.Text.ToString(), label30.Text.ToString(), label27.Text.ToString(), label29.Text.ToString(), label28.Text.ToString(), label45.Text.ToString(), label31.Text.ToString(), label71.Text.ToString(), label62.Text.ToString(), label70.Text.ToString(), label61.Text.ToString(), label69.Text.ToString(), label80.Text.ToString(), label68.Text.ToString(), label79.Text.ToString(), label67.Text.ToString(), label78.Text.ToString(), label66.Text.ToString(), label77.Text.ToString(), label65.Text.ToString(), label76.Text.ToString(), label64.Text.ToString(), label75.Text.ToString(), label63.Text.ToString(), label73.Text.ToString()).Show();
                
                    this.Close();
                }
            }
        }
    }
}
