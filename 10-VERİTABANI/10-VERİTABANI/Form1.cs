using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _10_VERİTABANI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        //DataTable dt;
        DataSet ds;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
            if (radioButton1.Checked)
                da = new OleDbDataAdapter("select * from Bolum",con);
            if (radioButton2.Checked)
                da = new OleDbDataAdapter("select * from Ogrenci", con);
            ds = new DataSet();
           // dt = new DataTable();
            con.Open();
           // da.Fill(dt);
            da.Fill(ds, "mehmet");
            dataGridView1.DataSource = ds.Tables["mehmet"];
            con.Close();
        }
    }
}
