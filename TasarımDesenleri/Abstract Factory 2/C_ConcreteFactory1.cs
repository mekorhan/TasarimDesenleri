using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    class C_ConcreteFactory1 : C_AbstractFactory
    {
        public override C_AbstractIcecek f_IcecekUret()
        {
            return new C_ConcreteIcecek1();
        }

        public override C_AbstractSise f_SiseUret()
        {
            return new C_ConcreteSise1();
        }
    }
}
