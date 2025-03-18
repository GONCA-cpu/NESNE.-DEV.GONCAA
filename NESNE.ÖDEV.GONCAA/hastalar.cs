using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESNE.ÖDEV.GONCAA
{
    public class hastalar
    {
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Hastalik { get; set; }

        public hastalar(string ad, string soyad, string yas, string hastalik)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Hastalik = hastalik;
        }
        public override string ToString()
        {
            return $"{Ad}  {Soyad} , {Yas} yasinda, Hastalık:{Hastalık}";
        }
    }
}
