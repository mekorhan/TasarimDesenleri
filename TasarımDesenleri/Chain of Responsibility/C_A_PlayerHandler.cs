using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    abstract class C_A_PlayerHandler
    {
        protected C_A_PlayerHandler o__SonrakiHandler;
        public C_A_PlayerHandler o_SonrakiHandler { set { o__SonrakiHandler=value; } }

        public abstract void f_Play(string v_filePath);
    }
}
