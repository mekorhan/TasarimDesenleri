using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility1
{
    class C_CustomersEarningsIsEnoughToPayCredit : C_A_KrediTalebiVeritabanı
    {
        public override void f_ExecuteProcess(C_Customer customer)
        {
            if (base.v_ONAY)
            {
                bool EarningIsFine = true;
                if (EarningIsFine)
                    base.v_ONAY=true;
                else
                    base.v_ONAY = false;
            }
        }
    }
}
