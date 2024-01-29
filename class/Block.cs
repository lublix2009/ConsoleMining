using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ConsoleMining
{
    public class Block
    {

      

        //właściwości bloka:
        static public int Hp { get; set; } = 100;
        static public int Level { get; set; } = 1;
        static public int DodawanieHpBlokowi { get; set; } = 100;
     

        //nagrody które daje:
        static public int nagrodapunkty = 10;

        static public int nagrodaWengla = 2;
        static public int nagrodaZelaza = 2;
        static public int nagrodaZłota  = 2;



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
                            // wybrał wengiel
                             Player.ilośćwengiel += Block.nagrodaWengla;
                            Player.Score += Block.nagrodapunkty;
                            Block.Hp += Block.DodawanieHpBlokowi;
                            Console.WriteLine("Gratulacje wykopałeś : " + Block.nagrodaWengla + " węgla!");
                            Console.WriteLine("Wpisz:");
                            Console.WriteLine("1 - wyjdz");
                            Console.WriteLine("2 - Kontynuj");
                            string WyjdzZKopania = Console.ReadLine();
                            switch (WyjdzZKopania)
                            {
                                case "1":
                                {
                                       Menu.MenuWyboru();
                                       break;
                                }
                                case "2":
                                    {
                                        Block.timer();
                                        break;
                                    }
                            }

                            break;
                            }
                        case 2:
                            {
                            //wybrał żelazo
                            Player.ilośćzelazo += Block.nagrodaZelaza;
                            Player.Score += Block.nagrodapunkty;
                            Block.Hp += Block.DodawanieHpBlokowi;
                            Console.WriteLine("Gratulacje wykopałeś : " + Block.nagrodaZelaza + " Żelaza!");
                            Console.WriteLine("Wpisz:");
                            Console.WriteLine("1 - wyjdz");
                            Console.WriteLine("2 - Kontynuj");
                             string WyjdzZKopania = Console.ReadLine();
                            switch (WyjdzZKopania)
                            {
                                case "1":
                                    {
                                        Menu.MenuWyboru();
                                        break;
                                    }
                                case "2":
                                    {
                                        Block.timer();
                                        break;
                                    }
                            }
                            break;
                            }
                        case 3:
                            {
                            //wybrał złoto
                            Player.ilośćzłoto += Block.nagrodaZłota;
                            Player.Score += Block.nagrodapunkty;
                            Block.Hp += Block.DodawanieHpBlokowi;
                            Console.WriteLine("Gratulacje wykopałeś : " + Block.nagrodaZłota + " Złota!");
                            Console.WriteLine("Wpisz:");
                            Console.WriteLine("1 - wyjdz");
                            Console.WriteLine("2 - Kontynuj");
                            string WyjdzZKopania = Console.ReadLine();
                            switch (WyjdzZKopania)
                            {
                                case "1":
                                    {
                                        Menu.MenuWyboru();
                                        break;
                                    }
                                case "2":
                                    {
                                        Block.timer();
                                        break;
                                    }
                            }
                            break;
                            }


                 }
                
           }
           else
           {
                Hp -= Player.moc;
                Console.WriteLine("kopiesz...");
            }

        }


       
     





      static  public void timer()
      {
            TimerCallback timerCallback = Kopanie;
            Timer timer = new Timer(timerCallback, null, 0, 1500);
            Console.ReadLine();
      }








    }



    
     

}  