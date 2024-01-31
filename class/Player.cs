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
        static public int PunktyDoNastępnegoPozimomu { get; set; } = 50;
        public static int IlośćPrzedmiotów { get; set; }

        //ilość bloków
       static  public int ilośćwengiel { get; set; } 
       static  public int ilośćzelazo { get; set; } 
       static public int ilośćzłoto { get; set; } 

        //cena bloków do sprzedaży
       static public int CenaWengla { get; set; } = 2;
      static  public int CenaZelaza { get; set; } = 5;
      static  public int CenaZłota { get; set; } = 15;

        //kryptowaluty
       // public double BTC { get; set; }
       // public double ETH { get; set; }
        public static void LevelUp()
        {
          if(PunktyDoNastępnegoPozimomu <= Score)
          {
                Console.Clear();
                Level++;
                PunktyDoNastępnegoPozimomu = PunktyDoNastępnegoPozimomu * 2;
                Block.nagrodapunkty = Block.nagrodapunkty * 2;
                Console.WriteLine("Gratulacje osiągnołeś Poziom " +Level);
                Thread.Sleep(3000);
                Menu.MenuWyboru();
          }
          else
          {
                Menu.MenuWyboru();

          }
        }




    }
}
