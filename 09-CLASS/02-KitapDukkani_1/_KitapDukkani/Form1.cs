using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KitapDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Yazar> yazarlar = new List<Yazar>();
        List<Kitap> kitaplar = new List<Kitap>();
        List<Musteri> musteriler = new List<Musteri>();
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yzr = new Yazar();
            yzr.Adi = txtYazarAdi.Text;
            yzr.DogumTarihi = dtYazarDogumTarihi.Value;
            if (chkNobel.Checked==true)
	        {
                yzr.NobelOduluVarMi = true;
	        }
            else
            {
                yzr.NobelOduluVarMi = false;
            }

            yazarlar.Add(yzr);
            cmbYazar.Items.Add(yzr);
            cmbYazar.DisplayMember = "Adi";
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap ktp = new Kitap();
            ktp.KitapAdi = txtKitapAdi.Text;
            ktp.KitapTuru = cmbKitapTuru.SelectedItem.ToString();
            ktp.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            ktp.Fiyat = decimal.Parse(txtFiyat.Text);
            ktp.Yazari = (Yazar)cmbYazar.SelectedItem;
            kitaplar.Add(ktp);
            cmbKitap.Items.Add(ktp);
            cmbKitap.DisplayMember = "KitapAdi";
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri mstr = new Musteri();
            mstr.MusteriAdi = txtMusteriAdi.Text;
            mstr.Meslegi = txtMeslegi.Text;
            mstr.Kitap = (Kitap)cmbKitap.SelectedItem;
            mstr.Yas = int.Parse(txtMusteriYas.Text);

            musteriler.Add(mstr);
        }

        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            foreach (Musteri item in musteriler)
            {
                lsbMusteriler.Items.Add(item.MusteriAdi + "  " + item.Kitap.KitapAdi + "  " + item.Kitap.Fiyat + "  " + item.Kitap.Yazari.Adi);
            }
        }


       
        
    }
}
