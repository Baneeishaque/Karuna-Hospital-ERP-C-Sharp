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
    public partial class OP_list : Form
    {
        public OP_list()
        {
            InitializeComponent();
        }

        private void OP_list_Load(object sender, EventArgs e)
        {
            MyDBhandler DH = new MyDBhandler();
            DataTable dt1 = DH.GetTable("SELECT no as OP_Number,name as Name,panchayath as Place FROM `op` ");
            dataGridView1.DataSource = dt1;
           // dataGridView1.DataBind();

               
        }
    }
}
