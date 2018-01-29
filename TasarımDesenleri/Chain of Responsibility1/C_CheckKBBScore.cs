using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility1
{
    class C_CheckKBBScore : C_A_KrediTalebiVeritabanı
    {
        public override void f_ExecuteProcess(C_Customer customer)
        {
            int v_kbbScore = 1200;
            if (v_kbbScore >= 1000)
                base.v_ONAY = true;
            else
                base.v_ONAY = true;
        }
    }
}
