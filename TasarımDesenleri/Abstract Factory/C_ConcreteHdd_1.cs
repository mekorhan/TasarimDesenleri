using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class C_ConcreteHdd_1 : C_AbstractHdd
    {
        public override void f_HddIslem() { }
        public override string HddTur
        {
            get
            {
                return "Bu Hdd türü: 1. Tür!";
            }
        }
    }
}
