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
                Console.WriteLine("Bursztyn - " + Player.ilośćbursztynu          );
                Console.WriteLine("Węgiel - " + Player.ilośćwengiel              );
                Console.WriteLine("Żelazo - " + Player.ilośćzelazo               );
                Console.WriteLine("Złoto - " + Player.ilośćzłoto                 );
                Console.WriteLine(                                               );
                Console.WriteLine("Monety - " + Player.Monety                    );
                Console.WriteLine(                                               );
                Console.WriteLine("By sprzedać wpisz:                           ");
                Console.WriteLine("1 - Bursztyn                                 ");
                Console.WriteLine("2 - Węgiel                                   ");
                Console.WriteLine("3 - Żelazo                                   ");
                Console.WriteLine("4 - Złoto                                    ");
                Console.WriteLine("5 - Wyjdz                                    ");
                Console.WriteLine("---------------------------------------------");
                string WyburRudyDoSprzedaży = Console.ReadLine();
                switch (WyburRudyDoSprzedaży)
                {
                    case "1":
                        {
                            Player.Monety += Player.CenaBursztunu * Player.ilośćbursztynu;
                            Player.ilośćbursztynu = 0;
                            break;
                        }
                    case "2":
                        {
                            Player.Monety += Player.CenaWengla * Player.ilośćwengiel;
                            Player.ilośćwengiel = 0;

                            break;
                        }
                    case "3":
                        {
                            Player.Monety += Player.CenaZelaza * Player.ilośćzelazo;
                            Player.ilośćzelazo = 0;
                            break;
                        }
                    case "4":
                        {
                            Player.Monety += Player.CenaZłota * Player.ilośćzłoto;
                            Player.ilośćzłoto = 0;
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
