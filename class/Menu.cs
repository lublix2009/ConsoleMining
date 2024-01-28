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
        Player player = new();
        Block blok = new();
        
      public void PierwszeUruchomienie()
      {
            Console.WriteLine("Witaj jak masz na imię?");
            player.playername = Console.ReadLine();
            MenuWyboru();
      }

        public void MenuWyboru()
        {

            while(true)
            {
                Console.Clear();
              Console.WriteLine("Witaj to jest menu główne.");
              Console.WriteLine("By zacząć kopać wpisz: 1 ");
              Console.WriteLine("Jeśli chcesz sprzedać rudy wpisz: 2 ");
              Console.WriteLine("Jeśli chcesz kupić koparki wpisz: 3 ");
              Console.WriteLine("jeśli chcesz zobaczyć swój profil oraz statystyki wpisz: 4 ");
                player.wybur = Console.ReadLine();

            
            


                switch (player.wybur)
                {
                    case "1"://kopanie
                    {
                            blok.timer();
                            break;
                    }
                    case "2"://sprzedaj
                    {
                            Sprzedaj();
                            break;
                    }
                    case "3"://sklep
                    {
                            Sklep();
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
        public void Sklep()
        {

        }


        public void Sprzedaj()
        {
            while (true)
            {


                Console.Clear();

                Console.WriteLine("Hej to tu możesz sprzedać swoje rudy");
                Console.WriteLine();
                Console.WriteLine("cennik");
                Console.WriteLine("Węgiel - 5");
                Console.WriteLine("Żelazo - 20");
                Console.WriteLine("Złoto - 50");
                Console.WriteLine();
                Console.WriteLine("Obecnie w ekwipunku masz:");
                Console.WriteLine("Węgiel - " + player.ilośćwengiel);
                Console.WriteLine("Żelazo - " + player.ilośćzelazo);
                Console.WriteLine("Złoto - " + player.ilośćzłoto);
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
                        player.Monety += player.CenaWengla * player.ilośćwengiel;
                        player.ilośćwengiel = 0;
                        break;
                    }
                    case "2":
                    {
                            player.Monety += player.CenaZelaza * player.ilośćzelazo;
                            break;
                    }
                    case "3":
                    {
                            player.Monety += player.CenaZłota * player.ilośćzłoto;
                            break;
                    }
                    case "4":
                    {
                            MenuWyboru();
                            break;
                    }

                }

            }

         
        }


        public void Profil()
        {
            Console.WriteLine("Oto twój profil oraz statystyki:");
            Console.WriteLine("Nick - " + player.playername);
            Console.WriteLine("Masz Level : "+ player.Level);
            Console.WriteLine("masz punktów :"+ player.Score);

        }
    }
}
