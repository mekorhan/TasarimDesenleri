using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            C_AbstractUrun o_Kitap = new C_Urun("Kitap", 7M);
            o_Kitap.o_TakipList.Add(new C_Uye { v_email = "mekrh4n@gmail.com" });
            o_Kitap.o_TakipList.Add(new C_Uye { v_email = "henesos@outlook.com" });
            o_Kitap.f_Fiyat = 08.25M;
            Console.ReadKey();
        }
    }
}