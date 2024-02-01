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
                Console.WriteLine("To tu zwiększysz swoją moc kopania kupując swoje koparki i kilofy");
                Console.WriteLine("Tym więcej masz koparek i kilofów tym większa moc!");
                Console.WriteLine();
                Console.WriteLine("Monety - " + Player.Monety);
                Console.WriteLine("Posiadasz " + Player.IlośćPrzedmiotów + " Koparek i kilofów");
                Console.WriteLine("By wybrać przedmiot wpisz:");
                Console.WriteLine("1 - Kilof Drewniany | Cena: 5   | Moc: 2");
                Console.WriteLine("2 - Kilof Żelazny   | Cena: 15  | Moc: 5");
                Console.WriteLine("3 - Kilof Złoty     | Cena: 30  | Moc: 10");
                Console.WriteLine("4 - Wyjdz");
                string WybórItemu = Console.ReadLine();
                switch (WybórItemu)
                {
                    case "1":
                        {
                            if (Player.Monety >= 5)
                            {
                                Player.moc += 2;
                                Player.Monety -= 5;
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
                            if (Player.Monety >= 15)
                            {
                                Player.moc += 5;
                                Player.Monety -= 15;
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
                    case "3":
                        {
                            if (Player.Monety >= 30)
                            {
                                Player.moc += 10;
                                Player.Monety -= 30;
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
                    case "4":
                        {
                            Menu.MenuWyboru();
                            break;
                        }
                }


            }

        }
    }
}
