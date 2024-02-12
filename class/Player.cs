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
       static public int Score = 0;
       static public int Monety = 0;
       static public int moc = 5;
       static  public string Login = "imie";
       static public string Hasło = "hasło";
       static public int HpGracza = 100;
       static public int Level = 0;
       static public string wybur = "1";
       static public int PunktyDoNastępnegoPozimomu = 50;
       public static int IlośćPrzedmiotów = 0;
       static public int nagrodapunkty = 10;
        static public bool tajnykod = true;

        //ilość Rud
        static public int RudyBursztynu = 0;
        static public int RudyWęgla = 0;
        static public int RudyŻelaza = 0;
        static public int RudyZłota = 0;
        //ilość zasobów
        static public int Bursztyn = 0;
        static public int Węgiel = 0;
        static public int Żelazo = 0;
        static public int Złoto  = 0;
        //kilofy
        static public int KilofDrewniany;
        static public int KilofBursztynowy;
        static public int KilofŻelazny;
        static public int KilofZłoty;



        //cena bloków do sprzedaży
       static public int CenaBursztunu { get; set; } = 1;
       static public int CenaWengla { get; set; } = 5;
       static  public int CenaZelaza { get; set; } = 15;
       static  public int CenaZłota { get; set; } = 50;
    }
}
