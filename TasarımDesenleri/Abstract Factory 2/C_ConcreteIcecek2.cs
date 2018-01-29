using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    class C_ConcreteIcecek2 : C_AbstractIcecek
    {
        public override string f_IcecekUret
        {
            get
            {
                return "İçecek2 Üretildi.";
            }
        }

        public override void f_Islem()
        {
            Console.WriteLine("Fanta aroması hazır.");
        }
    }
}
