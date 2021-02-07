using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankoveUctyPrevod
{
    class Program
    {
        static void Main(string[] args)
        {
            double MojIban = 100;
            double Iban1 = 100;
            double Iban2 = 200;
            int vstup;
            Console.WriteLine($"vas aktualny stav na ucte je {MojIban} $");
            do
            {
                
                Console.WriteLine("na ktory ucet chcete zaslat dolace >1< pre Iban1 alebo >2< pre  Iban2");               
                vstup = Int32.Parse(Console.ReadLine());
                if (vstup > 2 | vstup < 1)
                {
                    Console.WriteLine("nespravna moznost skuste to znova");
                }
            }
            while (vstup != 1 && vstup != 2);
            {  
                while (vstup!=3) {
                    Console.WriteLine($"zvolili ste platbu na Iban{vstup} kolko chcete odoslat dolacov.. >1< 10$ , >2< 20$ ");
                    if (vstup == 1)
                    {                     
                        int vstup1 = Int32.Parse(Console.ReadLine());
                        if (vstup1 == 1)
                        {
                            OdoslatDesat(ref Iban1, ref MojIban);                          
                        }
                        else if (vstup1 == 2)
                        {
                            OdoslatDvadsat(ref Iban1, ref MojIban);                        
                        }
                        else
                        {
                            Console.WriteLine("nespravna moznost");
                        }
                    }
                    if (vstup == 2)
                    {                      
                        int vstup1 = Int32.Parse(Console.ReadLine());
                        if (vstup1 == 1)
                        {
                            OdoslatDesat(ref Iban2, ref MojIban);
                        }
                        else if (vstup1 == 2)
                        {
                            OdoslatDvadsat(ref Iban2, ref MojIban);
                        }
                        else
                        {
                            Console.WriteLine("nespravna moznost");
                        }
                    }
                    Console.WriteLine("zelate si pokracovat?");
                    Console.WriteLine(">1< Poslat dalsie dolace na Iban1, >2< Poslat dalsie dolace na Iban2");
                    Console.WriteLine(">3< koniec IB");
                    vstup = Int32.Parse(Console.ReadLine());
                    //tu by mohla byt este podmienka ak uzivatel zada ine cislo ako 1,2 alebo 3 tak program vypise nespravnu moznost a skonci alebo ho vyzve znova.
                }
            }
            Console.WriteLine($"Na ucte Iban1 je novy zostatok: {Iban1} $");
            Console.WriteLine($"Na ucte Iban2 je novy zostatok: {Iban2} $");
            Console.WriteLine($"Vas novy zostatok na ucte je: {MojIban} $");
            Console.ReadLine();
        }


       public static void OdoslatDesat(ref double trans, ref double trans1)
        {
            trans += 10;
            trans1 -= 10;
            Console.WriteLine($"z uctu vam odislo 10 dolacov novy zostatok je: {trans1}");

        }
        public static void OdoslatDvadsat(ref double trans, ref double trans1)
        {
            trans += 20;
            trans1 -= 20;
            Console.WriteLine($"z uctu vam odislo 20 dolacov novy zostatok je: {trans1}");

        }
    }
}
