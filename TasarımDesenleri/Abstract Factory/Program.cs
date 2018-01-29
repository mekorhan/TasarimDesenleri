using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            C_Factory factory;
            factory = new C_Factory(new C_ConcreteFactory_1());
            factory.birlestir();
            factory = new C_Factory(new C_ConcreteFactory_2());
            factory.birlestir();
            Console.ReadKey();
        }
    }
}
