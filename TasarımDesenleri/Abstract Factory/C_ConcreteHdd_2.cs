using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class C_ConcreteHdd_2 : C_AbstractHdd
    {
        public override void f_HddIslem() { }
        public override string HddTur
        {
            get
            {
                return "Bu Hdd türü: 2.Tür!";
            }
        }
    }
}
