using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory__1_
{
    class C_ConcreteLastik_2 : C_AbstractLastik
    {
        public override string s_LastikTip
        {
            get
            {
                return "Skoda Lastiği Üretildi";
            }
        }

        public override void f_LastikUret()
        {
        }
    }
}
