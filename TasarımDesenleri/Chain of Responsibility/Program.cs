using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            C_A_PlayerHandler o_mp4player = new C_ConcreteHandlerMP4();
            C_A_PlayerHandler o_mpgplayer = new C_ConcreteHandlerMPG();
            C_A_PlayerHandler o_aviplayer = new C_ConcreteHandlerAVI();

            o_mp4player.o_SonrakiHandler = o_mpgplayer;
            o_mpgplayer.o_SonrakiHandler = o_aviplayer;

            o_mp4player.f_Play("matrix.mp4");
            o_mp4player.f_Play("lotr.mpg");
            o_mp4player.f_Play("harrypotter.avi");
            o_mp4player.f_Play("12Monkeys.swt");

            Console.ReadKey();
        }
    }
}
