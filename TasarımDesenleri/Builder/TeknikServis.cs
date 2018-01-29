using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TeknikServis
    {
        public void BilgisayarTopla(InterfaceBilgisayarToplayicisi bilgisayartoplayicisi) {
            bilgisayartoplayicisi.f_CDROM_Olustur();
            bilgisayartoplayicisi.f_HDD_Olustur();
            bilgisayartoplayicisi.f_MonitorOlustur();
            bilgisayartoplayicisi.f_RAM_Olustur();
        }
    }
}
