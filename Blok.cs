using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleMining
{
    public struct Blok
    {
        int Hp = 100;
        int nagroda = 20;

        public Blok()
        {
        }
        public void CoSekunde()
        {
            TimerCallback timerCallback = Kopanie;
            Timer timer = new Timer(timerCallback, null, 0, 1500);
            Console.ReadLine();
        }

         static  void Kopanie(object state)
        {

        }
    }

    
}
