using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMining
{
    public static class Sklep
    {
        public static void WybórItemu()
        {
            Console.WriteLine("To tu zwiększysz swoją moc kopania kupując swoje koparki i kilofy");
            Console.WriteLine("Tym więcej masz koparek i kilofów tym większa moc!");
            Console.WriteLine("Monety - " +Player.Monety);
            Console.WriteLine("Posiadasz" + Player.IlośćPrzedmiotów + " Koparek i kilofów");
            Console.WriteLine("By wybrać przedmiot wpisz:");
            Console.WriteLine("1 - Kilof Drewniany | Cena: 5 Monet | Moc: 2");
        }
    }
}
