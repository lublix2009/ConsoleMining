using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMining
{

    public class Menu
    {
        
        
      
      static public void PierwszeUruchomienie()
      {
            Console.WriteLine("Wpisz swój Nick");
            Player.Login = Console.ReadLine();
            MenuGłówne();
      }

      static  public void MenuGłówne()
        {

            while(true)
            {
              Console.Clear();
              Console.WriteLine("--------------------------------------------------------------");
              Console.WriteLine("                         Menu Główne                          ");
              Console.WriteLine(" Kopalnia   : 1                                               ");
              Console.WriteLine(" Rynek      : 2                                               ");
              Console.WriteLine(" Sklep      : 3                                               ");
              Console.WriteLine(" Kowal      : 4                                               ");
              Console.WriteLine(" Profil     : 5                                               ");
              Console.WriteLine("--------------------------------------------------------------");
              Player.wybur = Console.ReadLine();

            
                switch (Player.wybur)
                {
                    case "1"://kopanie
                    {
                          
                            Console.Clear();
                            //Block.Kopanie();
                            Kopanie.WybórRudy();
                            break;
                    }
                    case "2"://sprzedaj
                    {
                            
                            Sell.Sprzedaj();
                            break;
                    }
                    case "3"://sklep
                    {
                            
                            Sklep.Kupowanie(); 
                           break;
                    }
                    case "4":
                    {
                            Kowal.kowal();
                            break;
                    }
                    case "5":
                        {
                            Profil();
                            break;
                        }
                        

                }

            }

        }




        static public void Profil()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                       Profil                       ");
            Console.WriteLine("Nick - " + Player.Login                              );
            Console.WriteLine("Level: "+ Player.Level                               );
            Console.WriteLine("Mocy Wydobywcza: " + Player.moc                      );
            Console.WriteLine("Wynik(punkty): "+ Player.Score                       );
            Console.WriteLine(                                                      );
            Console.WriteLine("Ekwipunek:                                          ");
            Console.WriteLine("Monety: " + Player.Monety                            );
            Console.WriteLine(                                                      );
            Console.WriteLine("Rudy:                                               ");
            Console.WriteLine("Bursztyn: " + Player.ilośćbursztynu                  );
            Console.WriteLine("Węgiel: " + Player.ilośćwengiel                      );
            Console.WriteLine("Żelazo: " + Player.ilośćzelazo                       );
            Console.WriteLine("Złoto: " + Player.ilośćzłoto                         );
            Console.WriteLine("----------------------------------------------------");
            Console.ReadKey();

        }


        public static void LevelUp()
        {
            if (Player.PunktyDoNastępnegoPozimomu <= Player.Score)
            {

                Console.Clear();
                Player.Level++;
                Player.PunktyDoNastępnegoPozimomu *=  2;
                Player.nagrodapunkty *=  2;
                Console.WriteLine("Gratulacje osiągnołeś Poziom " + Player.Level);
                Thread.Sleep(3000);
                Menu.MenuGłówne();


            }
            else
            {
                Menu.MenuGłówne();

            }
        }
    }
}
