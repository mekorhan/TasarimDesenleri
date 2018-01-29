using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class C_ConcreteFactory_2 : C_AbstractFactory
    {
        public override C_AbstractHdd f_CreateHdd() {
            return new C_ConcreteHdd_2();
        }
        public override C_AbstractRam f_CreateRam() {
            return new C_ConcreteRam_2();
        }
    }
}
