using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMining
{
    public class Player
    {


        //gracz
       static public int Score { get; set; } = 0;
       static public int Monety { get; set; } = 0;
       static public int moc { get; set; } = 10;
       static  public string playername { get; set; } = "imie";
       static  public int HpGracza { get; set; }
       static public int Level { get; set; }
       static public string wybur { get; set; }
        //ilość bloków
       static  public int ilośćwengiel { get; set; } = 10;
       static  public int ilośćzelazo { get; set; } = 10;
       static public int ilośćzłoto { get; set; } = 10;

        //cena bloków do sprzedaży
       static public int CenaWengla { get; set; } = 5;
      static  public int CenaZelaza { get; set; } = 20;
      static  public int CenaZłota { get; set; } = 50;

        //kryptowaluty
       // public double BTC { get; set; }
       // public double ETH { get; set; }




    }
}
