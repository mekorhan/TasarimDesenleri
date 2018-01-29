using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            TeknikServis teknikservis = new TeknikServis();

            InterfaceBilgisayarToplayicisi BT1 = new C_GoldPC();
            InterfaceBilgisayarToplayicisi BT2 = new C_SilverPC();

            teknikservis.BilgisayarTopla(BT1);
            teknikservis.BilgisayarTopla(BT2);

            BT1.Bilgisayar.BilgisayarGoster();
            Console.WriteLine("--------");
            BT2.Bilgisayar.BilgisayarGoster();
            Console.ReadKey();
        }
    }
}
