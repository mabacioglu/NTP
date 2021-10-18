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
    public partial class PositifNegatifSiralam : Form
    {
        public PositifNegatifSiralam()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            lstNegatif.Items.Clear();
            lstPozitif.Items.Clear();
            lstSirala.Items.Clear();

            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sayi3 = Convert.ToInt32(txtSayi3.Text);
                       
            if (sayi1 > 0)
                lstPozitif.Items.Add(sayi1);
            if (sayi1 < 0)
                lstNegatif.Items.Add(sayi1);
            if (sayi2 < 0)
                lstNegatif.Items.Add(sayi2);
            if (sayi2 > 0)
                lstPozitif.Items.Add(sayi2); 
            if (sayi3 > 0)
                lstPozitif.Items.Add(sayi3);
            if (sayi3 < 0)
                lstNegatif.Items.Add(sayi3);

            // s1>s2>s3  s1>s3>s2  s2>s1>s3  s2>s3>s1    s3>s1>s2   s3>s2>s1 
            if (sayi1 > sayi2 && sayi2 > sayi3)
            {
                lstSirala.Items.Add(sayi1);
                lstSirala.Items.Add(sayi2);
                lstSirala.Items.Add(sayi3);
            }

            if (sayi1 > sayi3 && sayi3 > sayi2)
            {
                lstSirala.Items.Add(sayi1);
                lstSirala.Items.Add(sayi3);
                lstSirala.Items.Add(sayi2);
            }
            if (sayi2 > sayi1 && sayi1 > sayi3)
            {
                lstSirala.Items.Add(sayi2);
                lstSirala.Items.Add(sayi1);
                lstSirala.Items.Add(sayi3);
            }
            if (sayi2 > sayi3 && sayi3 > sayi1)
            {
                lstSirala.Items.Add(sayi2);
                lstSirala.Items.Add(sayi3);
                lstSirala.Items.Add(sayi1);
            }
            if (sayi3 > sayi1 && sayi1 > sayi2)
            {
                lstSirala.Items.Add(sayi3);
                lstSirala.Items.Add(sayi1);
                lstSirala.Items.Add(sayi2);
            }
            if (sayi3 > sayi2 && sayi2 > sayi1)
            {
                lstSirala.Items.Add(sayi3);
                lstSirala.Items.Add(sayi2);
                lstSirala.Items.Add(sayi1);
            }

            txtSayi1.Clear();
            txtSayi2.Clear();
            txtSayi3.Clear();
        }
    }
}
