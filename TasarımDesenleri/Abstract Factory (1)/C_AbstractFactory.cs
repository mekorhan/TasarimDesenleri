using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory__1_
{
    abstract class C_AbstractFactory
    {
        public abstract C_AbstractLastik f_CreateLastik();
        public abstract C_AbstractKasa f_CreateKasa();
    }
}
