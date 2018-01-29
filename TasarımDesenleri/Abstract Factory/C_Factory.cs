using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class C_Factory
    {
        private C_AbstractFactory o_abstractfactory;
        private C_AbstractHdd o_abstracthdd;
        private C_AbstractRam o_abstractram;
        public C_Factory(C_AbstractFactory o__abstractfactory) {
            o_abstractfactory = o__abstractfactory;
            o_abstracthdd = o_abstractfactory.f_CreateHdd();
            o_abstractram = o_abstractfactory.f_CreateRam();
        }
        public void birlestir() {
            Console.WriteLine(o_abstracthdd.HddTur);
            o_abstracthdd.f_HddIslem();
            Console.WriteLine(o_abstractram.RamTur);
            o_abstractram.f_RamIslem();
        }
    }
}
