using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_METOTLAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            myMethod1("Mehmet");
            int x = 100;
            int y = 200;
            myMethod(x, y);
            myMethod1("Ahmet");
            myMethod(3,5);
            myMethod(-8,10);
            myMethod(0,0);
            myMethod(-254,255);
            myMethod(5,6);
            myMethod(6,7);
            myMethod(10,15);

        }

        public void myMethod(int toplanacakSayi1,int toplanacakSayi2)
        {
            int sonuc;
            sonuc = toplanacakSayi1 + toplanacakSayi2;
            MessageBox.Show("Sonuc: "+sonuc.ToString());
        }
        public void myMethod1(string ad)
        {
            ad = "Welcome Mr. " + ad;
            MessageBox.Show(ad.ToString());
        }
        


        
    }
}
