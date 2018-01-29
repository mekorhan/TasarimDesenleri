using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class C_SilverPC : InterfaceBilgisayarToplayicisi
    {
        private Bilgisayar mBilgisayar;
        public Bilgisayar Bilgisayar
        {
            get
            {
                return mBilgisayar;
            }
        }

        public C_SilverPC() {
            mBilgisayar = new Bilgisayar("SILVER-PC");
        }

        public void f_CDROM_Olustur()
        {
            mBilgisayar["cdrom"] = "48X Creative";
        }

        public void f_HDD_Olustur()
        {
            mBilgisayar["hdd"] = "30 GB Maxtor";
        }

        public void f_MonitorOlustur()
        {
            mBilgisayar["monitor"] = "15' Vestel";
        }

        public void f_RAM_Olustur()
        {
            mBilgisayar["ram"] = "256 MB SD Kingston";
        }
    }
}
