﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory__1_
{
    class C_ConcreteKasa_2 : C_AbstractKasa
    {
        public override string s_KasaModel
        {
            get
            {
                return "Ford Focus kasası üretildi";
            }
        }

        public override void f_KasaUret()
        {
            Console.WriteLine("");
        }
    }
}
