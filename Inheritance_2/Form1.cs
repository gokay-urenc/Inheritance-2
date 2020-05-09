using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Egitmen egt = new Egitmen();
            egt.adi = "Onur";
            egt.soyadi = "Şişoğlu";
            egt.yas = 27;
            egt.sertifika = "Microsoft";
            egt.personel_no = "000";
            egt.ayakkabi_no = 43; // Çoklu miras. (Interface).

            Ogrenci ogr = new Ogrenci();
            ogr.adi = "Negan";
            ogr.soyadi = "Lucille";
            ogr.yas = 52;
            ogr.ogr_no = "765";
            ogr.ortalama = 65;
            ogr.ayakkabi_no = 47; // Çoklu miras. (Interface).

            MessageBox.Show(ogr.adi + " " + ogr.soyadi + " " + ogr.ogr_no);
            MessageBox.Show(egt.adi + " " + egt.soyadi + " " + egt.personel_no);
        }
    }
}