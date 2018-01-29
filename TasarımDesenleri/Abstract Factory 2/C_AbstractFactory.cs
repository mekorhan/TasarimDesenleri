using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    abstract class C_AbstractFactory
    {
        public abstract C_AbstractIcecek f_IcecekUret();
        public abstract C_AbstractSise f_SiseUret();
    }
}
