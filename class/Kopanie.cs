using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMining
{
    public class Kopanie
    {
        public static void WybórRudy()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("                        Kopalnia                        ");
            Console.WriteLine("Wpisz Liczbe by zacząć Kopać wybraną rudę               ");
            Console.WriteLine("Wpisz 1 - Ruda Bursztynu |Hp: 50                        ");
            Console.WriteLine("Wpisz 2 - Ruda Węgla     |Hp: 100                       ");
            Console.WriteLine("Wpisz 3 - Ruda Zelaza    |Hp: 200                       ");
            Console.WriteLine("Wpisz 4 - Ruda Złota     |Hp: 500                       ");
            Console.WriteLine("Wpisz 5 - Wyjdz                                         ");
            Console.WriteLine("--------------------------------------------------------");
            string WybieranieRudy = Console.ReadLine();
            switch (WybieranieRudy)
            {
                case "1"://bursztyn
                {
                        Random random = new Random();
                        int HpBursztynu = 50;
                        int DodawanieHpBursztynowi = 50;
                        Console.WriteLine("Ile razy chcesz Wykopać?");
                        string IlośćPowturzeńString = Console.ReadLine();
                        int IlośćPowturzeńInt = 0;


                        if (int.TryParse(IlośćPowturzeńString, out IlośćPowturzeńInt))
                        {
                            while (IlośćPowturzeńInt > 0)
                            {

                                if (HpBursztynu <= 0)
                                {
                                    int nagrodaBursztynu = random.Next(1, 31);
                                    Console.Clear();
                                    IlośćPowturzeńInt -= 1;
                                    Player.RudyBursztynu += nagrodaBursztynu;
                                    Player.Score += Player.nagrodapunkty;
                                    HpBursztynu = DodawanieHpBursztynowi;
                                    Console.WriteLine("Gratulacje wykopałeś : " + nagrodaBursztynu + " Bursztynu");
                                    Thread.Sleep(2000);

                                }
                                else
                                {

                                    Console.Clear();
                                    HpBursztynu -= Player.moc;
                                    Console.WriteLine("Kopanie...");
                                    Console.WriteLine(HpBursztynu + "/" + DodawanieHpBursztynowi);
                                    Thread.Sleep(1500);

                                }

                            }
                            Kopanie.WybórRudy();


                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowe dane. Wprowadź liczbę całkowitą.");
                            Kopanie.WybórRudy();
                        }
                        break;
                }

                case "2": //węgiel
                {
                        Random random = new Random();
                        int HpWengla = 100;
                        int DodawanieHpWenglowi = 100;
                        Console.WriteLine("Ile razy chcesz Wykopać?");
                        string IlośćPowturzeńString = Console.ReadLine();
                        int IlośćPowturzeńInt = 0;
                       

                        if (int.TryParse(IlośćPowturzeńString, out IlośćPowturzeńInt))
                        {
                            while( IlośćPowturzeńInt > 0)
                            {
                                
                                if(HpWengla <= 0)
                                {
                                    int nagrodaWengla = random.Next(1,11);
                                    Console.Clear();
                                    IlośćPowturzeńInt -= 1;
                                    Player.RudyWęgla += nagrodaWengla;
                                    Player.Score += Player.nagrodapunkty;
                                    HpWengla = DodawanieHpWenglowi;
                                    Console.WriteLine("Gratulacje wykopałeś : " + nagrodaWengla + " węgla!");
                                    Thread.Sleep(2000);

                                }
                                else
                                {

                                    Console.Clear();
                                    HpWengla -= Player.moc;
                                    Console.WriteLine("Kopanie...");
                                    Console.WriteLine(HpWengla + "/" + DodawanieHpWenglowi);
                                    Thread.Sleep(1500);

                                }

                            }
                            Kopanie.WybórRudy();

                            
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowe dane. Wprowadź liczbę całkowitą.");
                            Kopanie.WybórRudy();
                        }

                        break;
                }
                case "3"://zelazo
                {
                        Random random = new Random();
                        int HpZelaza = 200;
                        int DodawanieHpzelazowi = 200;
                        Console.WriteLine("Ile razy chcesz Wykopać?");
                        string IlośćPowturzeńString = Console.ReadLine();
                        int IlośćPowturzeńInt = 0;


                        if (int.TryParse(IlośćPowturzeńString, out IlośćPowturzeńInt))
                        {
                            while (IlośćPowturzeńInt > 0)
                            {

                                if (HpZelaza <= 0)
                                {
                                    int nagrodaZelaza = random.Next(1, 6);
                                    Console.Clear();
                                    IlośćPowturzeńInt -= 1;
                                    Player.RudyŻelaza += nagrodaZelaza;
                                    Player.Score += Player.nagrodapunkty;
                                    HpZelaza = DodawanieHpzelazowi;
                                    Console.WriteLine("Gratulacje wykopałeś : " + nagrodaZelaza + " Żelaza!");
                                    Thread.Sleep(2000);

                                }
                                else
                                {

                                    Console.Clear();
                                    HpZelaza -= Player.moc;
                                    Console.WriteLine("Kopanie...");
                                    Console.WriteLine(HpZelaza + "/" + DodawanieHpzelazowi);
                                    Thread.Sleep(1500);

                                }

                            }
                            Kopanie.WybórRudy();


                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowe dane. Wprowadź liczbę całkowitą.");
                            Kopanie.WybórRudy();
                        }

                        break;
                }
                case "4"://złoto
                    {
                        Random random = new Random();
                        int HpZłota = 500;
                        int DodawanieHpZłota = 500;
                        Console.WriteLine("Ile razy chcesz Wykopać?");
                        string IlośćPowturzeńString = Console.ReadLine();
                        int IlośćPowturzeńInt = 0;


                        if (int.TryParse(IlośćPowturzeńString, out IlośćPowturzeńInt))
                        {
                            while (IlośćPowturzeńInt > 0)
                            {

                                if (HpZłota <= 0)
                                {
                                    
                                    int nagrodaZłota = random.Next(1, 5);
                                    Console.Clear();
                                    IlośćPowturzeńInt -= 1;
                                    Player.RudyZłota += nagrodaZłota;
                                    Player.Score += Player.nagrodapunkty;
                                    HpZłota = DodawanieHpZłota;
                                    Console.WriteLine("Gratulacje wykopałeś : " + nagrodaZłota + " Złota!");
                                    Thread.Sleep(2000);

                                }
                                else
                                {

                                    Console.Clear();
                                    HpZłota -= Player.moc;
                                    Console.WriteLine("Kopanie...");
                                    Console.WriteLine(HpZłota + "/" + DodawanieHpZłota);
                                    Thread.Sleep(1500);

                                }

                            }
                            Kopanie.WybórRudy();


                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowe dane. Wprowadź liczbę całkowitą.");
                            Kopanie.WybórRudy();
                        }

                        break;
                    }
                case "5": //Wyjście
                    {
                        Menu.MenuGłówne();
                        break;
                    }
            }




        }
      


    }
         


}
