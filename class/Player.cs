using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleMining
{
    public class Player
    {


        //gracz
       static public int Score { get; set; } = 0;
       static public int Monety { get; set; } = 0;
       static public int moc { get; set; } = 5;
       static  public string Login { get; set; } = "imie";
        static public string Hasło { get; set; } = "hasło";
       static public int HpGracza { get; set; } = 100;
        static public int Level { get; set; } = 0;
        static public string wybur { get; set; } = "1";
       static public int PunktyDoNastępnegoPozimomu { get; set; } = 50;
        public static int IlośćPrzedmiotów { get; set; } = 0;
        static public int nagrodapunkty = 10;

        //ilość bloków
        static public int ilośćbursztynu { get; set; } = 0;
        static public int ilośćwengiel { get; set; } = 0;
        static public int ilośćzelazo { get; set; } = 0;
        static public int ilośćzłoto { get; set; } = 0;


        //cena bloków do sprzedaży
       static public int CenaBursztunu { get; set; } = 1;
       static public int CenaWengla { get; set; } = 5;
       static  public int CenaZelaza { get; set; } = 15;
       static  public int CenaZłota { get; set; } = 50;
    }
}
