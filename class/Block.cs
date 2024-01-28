using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ConsoleMining
{
    public class Block
    {

       static Player player1 = new();

        //właściwości bloka:
        static public int Hp { get; set; } = 100;
        static public int Level { get; set; } = 1;

        //nagrody które daje:
        static public int nagrodaMonety { get; set; } = 5;
        public int nagrodapunkty = 10;

        public int nagrodaWengla = 2;
        public int nagrodaZelaza = 2;
        public int nagrodaZłota  = 2;



        static public void Kopanie(object state)
        {
           if(Hp <= 0)
           {
               
                
                    Random random = new Random();
                    int ruda = random.Next(1, 4);
                 switch (ruda)
                 {
                        case 1:
                            {


                                break;
                            }
                        case 2:
                            {
                                //wybrał żelazo

                                break;
                            }
                        case 3:
                            {
                                //wybrał złoto

                                break;
                            }


                 }
                
           }
           else
           {
                Hp -= player1.moc;
           }

        }


       
    





        public void timer()
        {
            TimerCallback timerCallback = Kopanie;
            Timer timer = new Timer(timerCallback, null, 0, 1500);
            Console.ReadLine();
        }








    }



    
     

}  