using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class C_Uye : C_InterfaceUye
    {
        public string v_email { get; set; }
        public void f_Update(C_AbstractUrun abstracturun)
        {
            Console.WriteLine("{0} ürünün fiyatı {1}TL oldu {2} adresine gönderildi.",abstracturun.f_UrunAdi,abstracturun.f_Fiyat,v_email);
        }
    }
}
