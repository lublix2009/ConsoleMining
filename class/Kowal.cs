using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMining
{
    public class Kowal
    {
      public static void kowal()
        {

            while (true)
            {
                if(Player.Level >= 10)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("                      Kowal                      ");
                    Console.WriteLine("                                                 ");
                    Console.WriteLine("                                                 ");
                    Console.WriteLine("                                                 ");
                    Console.WriteLine("-------------------------------------------------");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry musisz mieć 10 poziom lub większy by tu wejść :(");
                    Thread.Sleep(5000);
                    Menu.MenuGłówne();

                }
            }

        }
    }
}
