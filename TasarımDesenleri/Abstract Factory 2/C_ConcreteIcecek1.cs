using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    class C_ConcreteIcecek1 : C_AbstractIcecek
    {
        public override string f_IcecekUret
        {
            get
            {
                return "Icecek1 Uretildi.";
            }
        }
        public override void f_Islem()
        {
            Console.WriteLine("Kola aroması hazır.");
        }
    }
}
