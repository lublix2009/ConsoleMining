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

        static public int nagrodaWengla = 4;
        static public int nagrodaZelaza = 2;
        static public int nagrodaZłota  = 1;



        static public void Kopanie()
        {
            while (true)
            {


                if (Hp <= 0)
                {


                    Random random = new Random();
                    int ruda = random.Next(1, 4);
                    switch (ruda)
                    {
                        case 1:
                            {
                                // wylosowano węgiel
                                Player.ilośćwengiel += Block.nagrodaWengla;
                                Player.Score += Block.nagrodapunkty;
                                Block.Hp += Block.DodawanieHpBlokowi;
                                Console.WriteLine("Gratulacje wykopałeś : " + Block.nagrodaWengla + " węgla!");
                                Block.WyjścieZKopania();
                                break;
                            }
                        case 2:
                            {
                                //wylosowano żelazo
                                Player.ilośćzelazo += Block.nagrodaZelaza;
                                Player.Score += Block.nagrodapunkty;
                                Block.Hp += Block.DodawanieHpBlokowi;
                                Console.WriteLine("Gratulacje wykopałeś : " + Block.nagrodaZelaza + " Żelaza!");
                                Block.WyjścieZKopania();
                                break;
                            }
                        case 3:
                            {
                                //wybrał złoto
                                Player.ilośćzłoto += Block.nagrodaZłota;
                                Player.Score += Block.nagrodapunkty;
                                Block.Hp += Block.DodawanieHpBlokowi;
                                Console.WriteLine("Gratulacje wykopałeś : " + Block.nagrodaZłota + " Złota!");
                                Block.WyjścieZKopania();
                                break;
                            }


                    }

                }
                else
                {
                    Console.Clear();
                    Hp -= Player.moc;
                    Console.WriteLine("Kopanie...");
                    Console.WriteLine(Block.Hp + "/"+ Block.DodawanieHpBlokowi);
                    Thread.Sleep(1500);
                }

            }


        }


            public static void WyjścieZKopania()
            {
                Console.WriteLine("Wpisz:");
                Console.WriteLine("1 - wyjdz");
                Console.WriteLine("2 - Kontynuj");
                string WyjdzZKopania = Console.ReadLine();
                switch (WyjdzZKopania)
                {
                    case "1":
                        {
                            Player.LevelUp();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Block.Kopanie();
                            break;
                        }
                }
            }
        }
    }
     















    



    
     

 