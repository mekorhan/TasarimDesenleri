using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory__1_
{
    class C_Factory
    {
        private C_AbstractFactory o_abstractfactory;
        private C_AbstractKasa o_abstractkasa;
        private C_AbstractLastik o_abstractlastik;
        public C_Factory(C_AbstractFactory o__abstractfactory) {
            o_abstractfactory = o__abstractfactory;
            o_abstractkasa = o_abstractfactory.f_CreateKasa();
            o_abstractlastik = o_abstractfactory.f_CreateLastik();
        }
        public void birlestir(){
            Console.WriteLine(o_abstractkasa.s_KasaModel);
            o_abstractkasa.f_KasaUret();
            Console.WriteLine(o_abstractlastik.s_LastikTip);
            o_abstractlastik.f_LastikUret();
        }
    }
}
