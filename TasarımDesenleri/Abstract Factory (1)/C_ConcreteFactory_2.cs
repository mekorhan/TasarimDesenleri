using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory__1_
{
    class C_ConcreteFactory_2 : C_AbstractFactory
    {
        public override C_AbstractKasa f_CreateKasa()
        {
            return new C_ConcreteKasa_2();
        }

        public override C_AbstractLastik f_CreateLastik()
        {
            return new C_ConcreteLastik_2();
        }
    }
}
