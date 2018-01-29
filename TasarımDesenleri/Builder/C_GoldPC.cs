using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class C_GoldPC : InterfaceBilgisayarToplayicisi
    {
        private Bilgisayar mBilgisayar;
        public Bilgisayar Bilgisayar
        {
            get
            {
                return mBilgisayar;
            }
        }

        public C_GoldPC(){
            mBilgisayar = new Bilgisayar("GOLD-PC");
        }

        public void f_CDROM_Olustur()
        {
            mBilgisayar["cdrom"] = "52X GoldStar";
        }

        public void f_HDD_Olustur()
        {
            mBilgisayar["hdd"] = "60 GB Seagate";
        }

        public void f_MonitorOlustur()
        {
            mBilgisayar["monitor"] = "17' Hyundai";
        }

        public void f_RAM_Olustur()
        {
            mBilgisayar["ram"] = "512 MB DDR Kingston";
        }
    }
}
