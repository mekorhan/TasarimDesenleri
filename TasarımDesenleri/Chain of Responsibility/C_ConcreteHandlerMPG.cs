using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class C_ConcreteHandlerMPG : C_A_PlayerHandler
    {
        public override void f_Play(string v_filePath)
        {
            if (v_filePath.EndsWith(".mpg"))
                Console.WriteLine("{0} dosyası oynatılıyor (mpg player)", v_filePath);
            else {
                if (o__SonrakiHandler != null)
                    o__SonrakiHandler.f_Play(v_filePath);
            }
        }
    }
}
