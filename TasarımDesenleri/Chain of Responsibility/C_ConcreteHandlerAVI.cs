using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class C_ConcreteHandlerAVI : C_A_PlayerHandler
    {
        public override void f_Play(string v_filePath)
        {
            if (v_filePath.EndsWith(".avi"))
                Console.WriteLine("{0} dosyası oynatılıyor (avi player)",v_filePath);
            else {
                if (o__SonrakiHandler == null)
                    Console.WriteLine("{0} Oynatılamayan kaynak.", v_filePath);
            }
        }
    }
}
