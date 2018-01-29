using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class C_ConcreteRam_2 : C_AbstractRam
    {
        public override void f_RamIslem() { }
        public override string RamTur
        {
            get
            {
                return "Bu Ram türü: 2. Tür!";
            }
        }
    }
}
