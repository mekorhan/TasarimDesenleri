using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface InterfaceBilgisayarToplayicisi
    {
        Bilgisayar Bilgisayar { get; }

        void f_CDROM_Olustur();
        void f_HDD_Olustur();
        void f_MonitorOlustur();
        void f_RAM_Olustur();
    }
}
