using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    class C_Factory
    {
        private C_AbstractFactory o_abstractfactory;
        private C_AbstractIcecek o_abstracticecek;
        private C_AbstractSise o_abstractsise;
        public C_Factory(C_AbstractFactory o__abstractfactory) {
            o_abstractfactory = o__abstractfactory;
            o_abstracticecek = o_abstractfactory.f_IcecekUret();
            o_abstractsise = o_abstractfactory.f_SiseUret();
        }
        public void birlestir() {
            Console.WriteLine(o_abstractsise.f_SiseUret);
            o_abstractsise.f_islem();
            Console.WriteLine(o_abstracticecek.f_IcecekUret);
            o_abstracticecek.f_Islem();

        }
    }
}
