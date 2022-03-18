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

namespace _02_ParametreKullanımı
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
            GridDoldur();
        }

        private void GridDoldur()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=vt1.accdb");
            dataAtapter = new OleDbDataAdapter("select * from bilgiler", connection);
            connection.Open();
            table = new DataTable();
            dataAtapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into bilgiler(Adi,Soyadi,DogumTarihi,KardesSayisi,Cinsiyet,NotOrtalamasi,AylikGeliri,EgitimDurumu,DahaOnceBasvuruYaptiMi) values (@adi,@soyadi,@dogumTarihi,@kardesSayisi,@cinsiyet,@notOrtalamasi,@aylikGeliri,@egitimDurumu,@basvuru)";
           
            command.Parameters.AddWithValue("@adi",txtAdi.Text);
            command.Parameters.AddWithValue("@soyadi",txtSoyadi.Text);
            command.Parameters.AddWithValue("@dogumTarihi", dtpDogumTarihi.Value.ToShortDateString());
            command.Parameters.AddWithValue("@kardesSayisi", int.Parse(txtKardesSayisi.Text));
            if (rdbErkek.Checked)
                command.Parameters.AddWithValue("@cinsiyet", rdbErkek.Text);
            if (rdbKadin.Checked)
                command.Parameters.AddWithValue("@cinsiyet", rdbKadin.Text);
            command.Parameters.AddWithValue("@notOrtalamasi", double.Parse(txtNotOrtalamasi.Text));
            command.Parameters.AddWithValue("@aylikGelir", decimal.Parse(txtAylikGeliri.Text));
            command.Parameters.AddWithValue("@egitimDurumu", cmbEgitimDurumu.SelectedItem.ToString());
            if (chkDahaOnceBasvuruYaptiMi.Checked)
                command.Parameters.AddWithValue("@basvuru", true);
            else
                command.Parameters.AddWithValue("@basvuru", false);

            
            command.ExecuteNonQuery();
            connection.Close();
            GridDoldur();
        }
    }
}
