using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMining
{
    public static class Sklep
    {
        public static void Kupowanie()
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("                      Sklep                     ");
                Console.WriteLine("Monety - " + Player.Monety                       );
                Console.WriteLine("Posiadasz "+ Player.IlośćPrzedmiotów + " kilofów");
                Console.WriteLine("By wybrać przedmiot wpisz:                      ");
                Console.WriteLine("1 - Kilof Drewniany   | Cena: 50   | Moc: 5     ");
                Console.WriteLine("2 - Kilof Bursztynowy | Cena: 100  | Moc: 10    ");
                Console.WriteLine("3 - Kilof Żelazny     | Cena: 200  | Moc: 20    ");
                Console.WriteLine("4 - Kilof Złoty       | Cena: 400  | Moc: 40    ");
                Console.WriteLine("5 - Wyjdz                                       ");
                Console.WriteLine("------------------------------------------------");
                string WybórItemu = Console.ReadLine();
                switch (WybórItemu)
                {
                    case "1":
                        {
                            if (Player.Monety >= 50)
                            {
                                Player.moc += 5;
                                Player.Monety -= 50;
                                Player.IlośćPrzedmiotów++;
                                Console.WriteLine("Gratulacje kupiłeś Drewniany Kilof.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Sklep.Kupowanie();
                            }
                            else
                            {
                                Console.WriteLine(" Błąd! Za mało masz Monet");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case "2":
                        {
                            if (Player.Monety >= 100)
                            {
                                Player.moc += 10;
                                Player.Monety -= 100;
                                Player.IlośćPrzedmiotów++;
                                Console.WriteLine("Gratulacje kupiłeś Bursztynowy Kilof.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Sklep.Kupowanie();
                            }
                            else
                            {
                                Console.WriteLine(" Błąd! Za mało masz Monet");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case "3":
                        {
                            if (Player.Monety >= 200)
                            {
                                Player.moc += 20;
                                Player.Monety -= 200;
                                Player.IlośćPrzedmiotów++;
                                Console.WriteLine("Gratulacje kupiłeś Żelazny Kilof.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Sklep.Kupowanie();
                            }
                            else
                            {
                                Console.WriteLine(" Błąd! Za mało masz Monet");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case "4":
                        {
                            if (Player.Monety >= 400)
                            {
                                Player.moc += 40;
                                Player.Monety -= 400;
                                Player.IlośćPrzedmiotów++;
                                Console.WriteLine("Gratulacje kupiłeś Złoty Kilof.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Sklep.Kupowanie();
                            }
                            else
                            {
                                Console.WriteLine(" Błąd! Za mało masz Monet");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case "5":
                        {
                            

                            Menu.MenuGłówne();
                            break;
                        }
                }


            }

        }
    }
}
