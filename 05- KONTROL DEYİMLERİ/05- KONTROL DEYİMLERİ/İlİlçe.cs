using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05__KONTROL_DEYİMLERİ
{
    public partial class İlİlçe : Form
    {
        public İlİlçe()
        {
            InitializeComponent();
        }
        string[] hatayIlceleri = { "Dörtyol", "İskenderun", "Arsuz", "Defne" };
        private void İlİlçe_Load(object sender, EventArgs e)
        {
            cmbSehir.Items.Add("Ankara");
            cmbSehir.Items.Add("İstanbul");
            cmbSehir.Items.Add("Hatay");
            cmbSehir.Text = "Seçiniz...";
            cmbIlce.Enabled = false;
            
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Enabled = true;
            cmbIlce.Items.Clear();
            cmbIlce.Text = "Seçiniz...";
            if (cmbSehir.SelectedIndex == 0)
            {
                cmbIlce.Items.Add("Çankaya");
                cmbIlce.Items.Add("Yenimahalle");
                cmbIlce.Items.Add("Altındağ");
                cmbIlce.Items.Add("Keçiören");
            
            }
            if (cmbSehir.SelectedIndex == 1)
            {
                cmbIlce.Items.Add("Kadıköy");
                cmbIlce.Items.Add("Beşiktaş");
                cmbIlce.Items.Add("Kartal");
                cmbIlce.Items.Add("Ümraniye");
                cmbIlce.Items.Add("Sarıyer");
            }
            if (cmbSehir.SelectedIndex == 2)
            {

                cmbIlce.Items.AddRange(hatayIlceleri);
            }

        }
    }
}
