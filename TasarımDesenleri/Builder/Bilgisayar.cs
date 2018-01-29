using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Bilgisayar
    {
        private string mBilgisayarTipi;
        private System.Collections.Hashtable mParcalar = new System.Collections.Hashtable();

        public Bilgisayar(string BilgisayarTipi) {
            mBilgisayarTipi = BilgisayarTipi;
        }
        public object this[string key] {
            get {
                return mParcalar[key];
            }
            set {
                mParcalar[key] = value;
            }
        }
        public void BilgisayarGoster() {
            Console.WriteLine("Bilgisayar Tipi: " + mBilgisayarTipi);
            Console.WriteLine("CD_ROM model: " + mParcalar["cdrom"]);
            Console.WriteLine("Hard Disk Model: " + mParcalar["hdd"]);
            Console.WriteLine("Monitör Model: " + mParcalar["monitor"]);
            Console.WriteLine("RAM Model: " + mParcalar["ram"]);
        }
    }
}
