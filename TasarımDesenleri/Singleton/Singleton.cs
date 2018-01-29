using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static object locker = new Object();
        private Singleton() { Console.WriteLine("Constractor çağrıldı");}
        public static Singleton getInstance() {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }
            return _instance;
        }
        public void fonk() {
            Console.WriteLine("Fonksiyon çağrıldı"); Console.ReadKey();
        }
    }
}
