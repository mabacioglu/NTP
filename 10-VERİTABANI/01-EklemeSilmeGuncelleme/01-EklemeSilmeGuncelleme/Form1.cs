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

namespace _01_EklemeSilmeGuncelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection connection;
        OleDbDataAdapter dataAtapter;
        OleDbCommand command;
        DataTable table;
        private void Form1_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void gridDoldur()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
            dataAtapter = new OleDbDataAdapter("select * from ogrenci", connection);
            table = new DataTable();
            connection.Open();
            dataAtapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = " insert into ogrenci (ogr_no,ogr_ad,ogr_soyad,ogr_tel) values ('"+txtOgrNo.Text+"','"+txtOgrAd.Text+"','"+txtOgrSoyad.Text+"','"+txtOgrTel.Text+"') ";
            command.ExecuteNonQuery();
            connection.Close();
            gridDoldur();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgrAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtOgrTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            command=new OleDbCommand();
            connection.Open();
            command.Connection=connection;
            command.CommandText="delete from ogrenci where ogr_no="+txtOgrNo.Text+" ";
            command.ExecuteNonQuery();
            connection.Close();
            gridDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = " update ogrenci set ogr_ad='"+txtOgrAd.Text+"', ogr_soyad='"+txtOgrSoyad.Text+"',ogr_tel='"+txtOgrTel.Text+"' where ogr_no="+txtOgrNo.Text+"   ";
            command.ExecuteNonQuery();
            connection.Close();
            gridDoldur();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
            dataAtapter = new OleDbDataAdapter("select * from ogrenci where ogr_ad like  '"+txtAra.Text+"%'  ", connection);
            table = new DataTable();
            connection.Open();
            dataAtapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

       
    }
}
