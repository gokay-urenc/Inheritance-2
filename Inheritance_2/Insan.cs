using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    class Insan : Ortak
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public char cinsiyet { get; set; }
        public DateTime dogum_tarihi { get; set; }
        public int yas { get; set; }
        public int boy { get; set; }
        public double kilo { get; set; }
    }
}