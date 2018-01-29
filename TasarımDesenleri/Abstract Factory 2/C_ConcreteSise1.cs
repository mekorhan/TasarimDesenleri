using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    class C_ConcreteSise1 : C_AbstractSise
    {
        public override string f_SiseUret
        {
            get
            {
                return "Şişe1 Üretildi";
            }
        }

        public override void f_islem()
        {
            Console.WriteLine("Kola şişesi hazır.");
        }
    }
}
