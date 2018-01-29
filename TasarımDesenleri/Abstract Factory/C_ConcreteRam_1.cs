using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class C_ConcreteRam_1 : C_AbstractRam
    {
        public override void f_RamIslem() { }
        public override string RamTur
        {
            get
            {
                return "Bu Ram türü: 1. Tür!";
            }
        }
    }
}
