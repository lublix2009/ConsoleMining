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
              Console.WriteLine(" Kowal      : 3                                               ");
              Console.WriteLine(" Ekwipunek  : 4                                               ");
              Console.WriteLine(" Profil     : 5                                               ");
              Console.WriteLine("Wpisz odpowiednią liczbę                                      ");
              Console.WriteLine("--------------------------------------------------------------");
              Player.wybur = Console.ReadLine();

            
                switch (Player.wybur)
                {
                    case "1"://kopanie
                    {
                          
                            Console.Clear();
                           
                            Kopanie.WybórRudy();
                            break;
                    }
                    case "2"://rynek
                    {

                            Rynek();
                            break;
                    }
                    case "3"://sklep
                    {

                            Kowal.kowal();
                           break;
                    }
                    case "4":
                    {
                            Menu.Ekwipunek();
                            break;
                    }
                    case "5":
                        {
                            Profil();
                            break;
                        }
                    case "LublixTV":
                        {
                            if(Player.tajnykod == true)
                            {
                                Player.moc += 100;
                                Player.Monety += 5000;
                                Player.tajnykod = false;
                                Console.WriteLine("Widać że oglądasz mó kanał, w nagrode dostaniesz dużo kasy");
                                Thread.Sleep(4000);
                            }
                            else
                            {
                                Console.WriteLine(" Bonus masz już odebrany. Drugi raz nie możesz odebrać.");
                                Thread.Sleep(4000);
                            }
                            break;
                        }
                    case "AdminLogin":
                        {
                            Console.WriteLine("Podaj Hasło");
                            string haslo = Console.ReadLine();
                            if(haslo == "krykro11")
                            {

                            }
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
            Console.WriteLine("Bursztyn: " + Player.RudyBursztynu                   );
            Console.WriteLine("Węgiel: " + Player.RudyWęgla                         );
            Console.WriteLine("Żelazo: " + Player.RudyŻelaza                        );
            Console.WriteLine("Złoto: " + Player.RudyZłota                          );
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


        public static void Rynek()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                        Rynek                       ");
            Console.WriteLine("Co chcesz zrobić?                                   ");
            Console.WriteLine(" Kupić     : 1                                      ");
            Console.WriteLine(" Sprzedać  : 2                                      ");
            Console.WriteLine("----------------------------------------------------");
            string Rynekwybur = Console.ReadLine();
            switch (Rynekwybur)
            {
                case "1":
                    {
                        Sklep.Kupowanie();
                        break;
                    }
                case "2":
                    {
                        Sell.Sprzedaj();
                        break;
                    } 
                    
            }
        }

        public static void Ekwipunek()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                      Ekwipunek                       ");
            Console.WriteLine(" Rudy Minerałów:                                      ");
            Console.WriteLine(" Ruda Bursztynu - " + Player.RudyBursztynu             );
            Console.WriteLine(" Ruda Węgla     - " + Player.RudyWęgla                 );
            Console.WriteLine(" Ruda Żelaza    - " + Player.RudyŻelaza                );
            Console.WriteLine(" Ruda Złota     - " + Player.RudyZłota                 );
            Console.WriteLine("                                                      ");
            Console.WriteLine(" Oszlifowane Minerały:"                                );
            Console.WriteLine(" Bursztyn       - " + Player.Bursztyn                  ); 
            Console.WriteLine(" Węgiel         - " + Player.Węgiel                    );
            Console.WriteLine(" Sztabka Żelaza - " + Player.Żelazo                    );
            Console.WriteLine(" Sztabka Złota  - " + Player.Złoto                     );
            Console.WriteLine("                                                      ");
            Console.WriteLine(" Kilofy :                                             ");
            Console.WriteLine(" Kilof Drewniany   - " + Player.KilofDrewniany         );
            Console.WriteLine(" Kilof Bursztynowy - " + Player.KilofBursztynowy       );
            Console.WriteLine(" Kilof Żelazny     - " + Player.KilofŻelazny           );
            Console.WriteLine(" Kilof Złoty       - " + Player.KilofZłoty             );
            Console.WriteLine("------------------------------------------------------");
            Console.ReadKey();
        }
        private void AdminPanel()
        {

        }
    }
}
