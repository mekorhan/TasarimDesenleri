using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility1
{
    class C_CheckKreditCardPaymentTime : C_A_KrediTalebiVeritabanı
    {
        public override void f_ExecuteProcess(C_Customer customer)
        {
            if (base.v_ONAY) {
                int v_PaymentDelayTime = 1;
                if (v_PaymentDelayTime > 3)
                    base.v_ONAY = false;
                else
                    base.v_ONAY = true;
            }
        }
    }
}
