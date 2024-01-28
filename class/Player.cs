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
        public int Score { get; set; } = 0;
        public int Monety { get; set; } = 0;
        public int moc { get; set; } = 10;
        public string playername { get; set; } = "imie";
        public int HpGracza { get; set; }
        public int Level { get; set; }
        public string wybur { get; set; }
        //ilość bloków
        public int ilośćwengiel { get; set; } = 10;
        public int ilośćzelazo { get; set; } = 10;
        public int ilośćzłoto { get; set; } = 10;

        //cena bloków do sprzedaży
        public int CenaWengla { get; set; } = 5;
        public int CenaZelaza { get; set; } = 20;
        public int CenaZłota { get; set; } = 50;

        //kryptowaluty
        public double BTC { get; set; }
        public double ETH { get; set; }




    }
}
