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
        Player player = new Player();
      public void PierwszeUruchomienie()
        {
            Console.WriteLine("Witaj jak masz na imię?");
            player.playername = Console.ReadLine();
        }

        public void MenuWyboru()
        {
            
            switch (player.wybur)
            {
                case 1://kopanie
                {
                        break;
                }
                case 2://sprzedaj
                {
                        break;
                }
                case 3://sklep
                {
                        break;
                }
                
            }
        }


        public void sklep()
        {
          

        }
        public void sprzedaj()
        {
            int wybórsprzedaży;
            int CenaWengla = 5;
            int CenaZelaza = 20;
            int CenaZłota = 50;
            Console.WriteLine("Hej to tu możesz sprzedać swoje rudy");
            Console.WriteLine();
            Console.WriteLine("cennik");
            Console.WriteLine("Węgiel - 5");
            Console.WriteLine("Żelazo - 20");
            Console.WriteLine("Złoto - 50");
            Console.WriteLine();
            Console.WriteLine("A w ekwipunku masz:");
            Console.WriteLine("Węgiel - " + player.ilośćwengiel);
            Console.WriteLine("Żelazo - " + player.ilośćzelazo);
            Console.WriteLine("Złoto - " + player.ilośćzłoto);
            Console.WriteLine();
            Console.WriteLine("By sprzedać kliknij:");
            Console.WriteLine("1 - Węgiel");
            Console.WriteLine("2 - Żelazo");
            Console.WriteLine("3 - Złoto");
            


        }
    }
}
