using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleMining
{
    public class NoweOkno
    {
        static public void UruchomKopanie()
        {
            Thread KopanieThread = new Thread(Block.timer);
            KopanieThread.Start();
        }
    }
}
