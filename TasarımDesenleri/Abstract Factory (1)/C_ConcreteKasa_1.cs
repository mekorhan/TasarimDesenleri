using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory__1_
{
    class C_ConcreteKasa_1 : C_AbstractKasa
    {
        public override string s_KasaModel
        {
            get
            {
                return "Mercedes E200 kasası üretildi";
            }
        }

        public override void f_KasaUret()
        {
            Console.WriteLine("");
        }
    }
}
