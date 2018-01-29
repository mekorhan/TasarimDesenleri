using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class C_AbstractUrun
    {
        public string f_UrunAdi { set; get; }
        private decimal v_fiyat;

        public List<C_InterfaceUye> o_TakipList = new List<C_InterfaceUye>();

        public C_AbstractUrun(string v_UrunAd, decimal v_UrunFiyat) {
            this.f_UrunAdi = v_UrunAd;
            this.v_fiyat = v_UrunFiyat;
        }

        public decimal f_Fiyat{
            get { return v_fiyat; }
            set {
                if (v_fiyat != value)
                    f_NotifyUrun();
                v_fiyat = value;
            }
        }

        public void f_NotifyUrun() {
            foreach (C_InterfaceUye item in o_TakipList)
                item.f_Update(this);
        }
        

    }
}
