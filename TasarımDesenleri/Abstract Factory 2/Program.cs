using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_2
{
    class Program
    {
        static void Main(string[] args)
        {
            C_Factory factory;
            string s;
            s = Console.ReadLine();
            switch (s)
            {
                case "kola":
                    factory = new C_Factory(new C_ConcreteFactory1());
                    factory.birlestir();
                    break;
                case "fanta":
                    factory = new C_Factory(new C_ConcreteFactory2());
                    factory.birlestir();
                    break;
            }
            Console.ReadKey();
        }
    }
}
