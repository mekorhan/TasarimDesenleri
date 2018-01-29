using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    abstract class C_AbstractFactory
    {
        public abstract C_AbstractHdd f_CreateHdd();
        public abstract C_AbstractRam f_CreateRam();
    }
}
