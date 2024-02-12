using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMining
{
    public class Sell
    {
        static public void Sprzedaj()
        {
            while (true)
            {


                Console.Clear();

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("                    Rynek                    ");
                Console.WriteLine("Cennik                                       ");
                Console.WriteLine("Bursztyn - " + Player.CenaBursztunu           );
                Console.WriteLine("Węgiel - " + Player.CenaWengla                );
                Console.WriteLine("Żelazo - " + Player.CenaZelaza                );
                Console.WriteLine("Złoto - " + Player.CenaZłota                  );
                Console.WriteLine(                                               );
                Console.WriteLine("Na sprzedasz masz:                           ");
                Console.WriteLine("Bursztyn - " + Player.RudyBursztynu           );
                Console.WriteLine("Węgiel - " + Player.RudyWęgla                 );
                Console.WriteLine("Żelazo - " + Player.RudyŻelaza                );
                Console.WriteLine("Złoto - " + Player.RudyZłota                  );
                Console.WriteLine(                                               );
                Console.WriteLine("Monety - " + Player.Monety                    );
                Console.WriteLine(                                               );
                Console.WriteLine("By sprzedać wpisz:                           ");
                Console.WriteLine("1 - Ruda Bursztynu                           ");
                Console.WriteLine("2 - Ruda Węgla                               ");
                Console.WriteLine("3 - Ruda Żelaza                              ");
                Console.WriteLine("4 - Ruda Złota                               ");
                Console.WriteLine("5 - Wyjdz                                    ");
                Console.WriteLine("---------------------------------------------");
                string WyburRudyDoSprzedaży = Console.ReadLine();
                switch (WyburRudyDoSprzedaży)
                {
                    case "1":
                        {
                            Player.Monety += Player.CenaBursztunu * Player.RudyBursztynu;
                            Player.RudyBursztynu = 0;
                            break;
                        }
                    case "2":
                        {
                            Player.Monety += Player.CenaWengla * Player.RudyWęgla;
                            Player.RudyWęgla = 0;

                            break;
                        }
                    case "3":
                        {
                            Player.Monety += Player.CenaZelaza * Player.RudyŻelaza;
                            Player.RudyŻelaza = 0;
                            break;
                        }
                    case "4":
                        {
                            Player.Monety += Player.CenaZłota * Player.RudyZłota;
                            Player.RudyZłota = 0;
                            break;
                        }
                    case "5":
                        {
                            Menu.LevelUp();
                            break;
                        }

                }

            }


        }

    }
}
