using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESNE.ÖDEV.GONCAA
{
    public class doktorlar
    {
        public string Ad {  get; set; }

        public string Soyad { get; set; }
        public string Uzmanlik { get; set; }
        public doktorlar(string  ad, string soyad,string uzmanlik)
        {
            Ad = ad;
            Soyad = soyad;
            Uzmanlik = uzmanlik;
        }
        public override string ToString()
        {
            return $"{Ad}  {Soyad}, Uzmanlik:{Uzmanlik}";
        }
    }
}
