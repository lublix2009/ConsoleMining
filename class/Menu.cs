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
            Console.WriteLine("Witaj jak masz na imię?");
            Player.playername = Console.ReadLine();
            MenuWyboru();
      }

      static  public void MenuWyboru()
        {

            while(true)
            {
                Console.Clear();
              Console.WriteLine("Witaj to jest menu główne.");
              Console.WriteLine("By zacząć kopać wpisz: 1 ");
              Console.WriteLine("Jeśli chcesz sprzedać rudy wpisz: 2 ");
              Console.WriteLine("Jeśli chcesz kupić koparki wpisz: 3 ");
              Console.WriteLine("jeśli chcesz zobaczyć swój profil oraz statystyki wpisz: 4 ");
                Player.wybur = Console.ReadLine();

            
                switch (Player.wybur)
                {
                    case "1"://kopanie
                    {
                            Console.Clear();
                            Block.Kopanie();
                            break;
                    }
                    case "2"://sprzedaj
                    {
                            Sprzedaj();
                            break;
                    }
                    case "3"://sklep
                    {
                            
                           break;
                    }
                    case "4":
                    {
                            Profil();
                            break;
                    }
                        

                }

            }

        }



        static public void Sprzedaj()
        {
            while (true)
            {


                Console.Clear();

                Console.WriteLine("Hej to tu możesz sprzedać swoje rudy");
                Console.WriteLine();
                Console.WriteLine("cennik");
                Console.WriteLine("Węgiel - 2");
                Console.WriteLine("Żelazo - 5");
                Console.WriteLine("Złoto - 15");
                Console.WriteLine();
                Console.WriteLine("Obecnie w ekwipunku masz:");
                Console.WriteLine("Węgiel - " + Player.ilośćwengiel);
                Console.WriteLine("Żelazo - " + Player.ilośćzelazo);
                Console.WriteLine("Złoto - " + Player.ilośćzłoto);
                Console.WriteLine();
                Console.WriteLine("By sprzedać wpisz:");
                Console.WriteLine("1 - Węgiel");
                Console.WriteLine("2 - Żelazo");
                Console.WriteLine("3 - Złoto");
                Console.WriteLine("4 - Wyjdz");
                string WyburRudyDoSprzedaży = Console.ReadLine();
                switch (WyburRudyDoSprzedaży)
                {
                    case "1":
                    {
                        Player.Monety += Player.CenaWengla * Player.ilośćwengiel;
                        Player.ilośćwengiel = 0;
                        
                        break;
                    }
                    case "2":
                    {
                            Player.Monety += Player.CenaZelaza * Player.ilośćzelazo;
                            Player.ilośćzelazo = 0;
                            break;
                    }
                    case "3":
                    {
                            Player.Monety += Player.CenaZłota * Player.ilośćzłoto;
                            Player.ilośćzłoto = 0;
                            break;
                    }
                    case "4":
                    {
                            Player.LevelUp();
                            break;
                    }

                }

            }

         
        }


        static public void Profil()
        {
            Console.Clear();
            Console.WriteLine("Oto twój profil oraz statystyki:");
            Console.WriteLine("Nick - " + Player.playername);
            Console.WriteLine("Masz Level: "+ Player.Level);
            Console.WriteLine("Level Rud: " + Block.Level);
            Console.WriteLine("twój wynik to: "+ Player.Score);
            Console.WriteLine();
            Console.WriteLine("Ekwipunek:");
            Console.WriteLine("Monety: " + Player.Monety);
            Console.WriteLine();
            Console.WriteLine("Rudy:");
            Console.WriteLine("Węgiel: " + Player.ilośćwengiel);
            Console.WriteLine("Żelazo: " + Player.ilośćzelazo);
            Console.WriteLine("Złoto: " + Player.ilośćzłoto);
            Console.ReadKey();

        }
    }
}
