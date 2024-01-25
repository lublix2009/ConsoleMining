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
             
        }
    }
}
