using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESNE.ÖDEV.GONCAA
{
    public class hastane
    {
        public string Ad {  get; set; }
        public List<hastane> hastaneler { get; set; }=new List<hastane>();
        public List<doktor> Doktorlar { get; set; }= new List<doktor>();
        public hastane (string ad)
        {
            Ad = ad;
            List <hasta> hastalar = new 
                List<hasta> ();
            List <doktor> doktorlar = new 
                List<doktor> ();
        }
        private List<Hasta> hastalar = new List<Hasta>();//liste tanımladık
        public void HastalarEkle (hasta yeniHasta)//yeniHasta adında parametre ekledik 
        {
            hastalar.Add(yeniHasta);//listeye yeni hasta ekledik
        }
        private List<Doktor> doktorlar = List<Doktor>();
        public void DoktorlarEkle(doktor yeniDoktor)
        {
            doktorlar.Add(yeniDoktor);
        }
    }
}
