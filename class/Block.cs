using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ConsoleMining
{
    public class Block
    {
        public int Hp = 100;
        public int nagroda = 20;
        public int Level = 1;


        public void WybórRudy()
        {
            Random random = new Random();
            int ruda = random.Next(1, 4);
        }

        public void timer()
        {
            TimerCallback timerCallback = Kopanie;
            Timer timer = new Timer(timerCallback, null, 0, 1500);
            Console.ReadLine();
        }

       static public void Kopanie(object state)
        {
           
            Console.WriteLine("udało się");
        }
    }



    
     

}  