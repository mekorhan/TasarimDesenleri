using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility1
{
    abstract class C_A_KrediTalebiVeritabanı
    {
        public Boolean v_ONAY;

        protected C_A_KrediTalebiVeritabanı o_Next;

        public void seto_Next(C_A_KrediTalebiVeritabanı islem) {
            this.o_Next = islem;
        }

        public void f_Execute(C_Customer c) {
            f_ExecuteProcess(c);
            if (this.o_Next != null) {
                this.o_Next.v_ONAY = this.v_ONAY;
                this.o_Next.f_Execute(c);
            }
        }

        public abstract void f_ExecuteProcess(C_Customer customer);

    }
}
