using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<C_A_KrediTalebiVeritabanı> islem = new List<C_A_KrediTalebiVeritabanı>();
            islem.Add(new C_CheckKBBScore());
            islem.Add(new C_CheckKreditCardPaymentTime());
            islem.Add(new C_CheckGuarantorIsFine());
            islem.Add(new C_CustomersEarningsIsEnoughToPayCredit());
            islem.Add(new C_CheckCompanyCustomerWork());

            islem[0].seto_Next(islem[1]);
            islem[1].seto_Next(islem[2]);
            islem[2].seto_Next(islem[3]);
            islem[3].seto_Next(islem[4]);

            islem[0].f_Execute(new C_Customer());

            bool ONAY = islem[islem.Count - 1].v_ONAY;
            if (ONAY)
            {
                Console.WriteLine("Krediniz onaylanmıştır!");
            }
            else
            {
                Console.WriteLine("Krediniz onaylanmamıştır!");
            }
            Console.ReadKey();
        }
    }
}
