﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABFTKlassenBibliothek
{
    class Feature22
    {
        public static void flachenberechnung()
        {
            do
            {
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Flächenberechnung <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Willkommen in der Unterkategorie Flächen- und Umfangberechnung!\n" +
                    "Wählen sie eine Form aus, indem sie die zugehörige Zahl eingeben und Enter drücken.:\n" +
                    "1 - Quadrat\n" +
                    "2 - Rechteck\n" +
                    "3 - Parallelogramm\n" +
                    "4 - Trapez\n" +
                    "5 - Dreieck\n" +
                    "6 - Drachen\n" +
                    "7 - Raute\n" +
                    "8 - Drachenviereck\n" +
                    "9 - Kreis\n" +
                    "Tipp: mit der Eingabe des Wortes exit können sie das programm jederzeit verlassen.");
                string Smenu = Console.ReadLine();

                if (Smenu == "exit")
                {
                    Environment.Exit(0);
                }

                int menu = Convert.ToInt32(Smenu);
                if (menu == 1)
                {
                    Console.WriteLine("Geben sie die Länge oder die Breite ein und drücken sie anschließen ENTER.");
                    string one = Console.ReadLine();
                    if (one == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int oneQ = Convert.ToInt32(one);
                    Console.WriteLine($"Die Fläche beträgt{oneQ * oneQ}__²\n" +
                        $"Der Umfang beträgt {oneQ + oneQ}__²");
                }
                if (menu == 2)
                {
                    Console.WriteLine("Geben sie die Länge ein und drücken sie anschließend ENTER.");
                    string two = Console.ReadLine();
                    if (two == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int twoR = Convert.ToInt32(two);
                    Console.WriteLine("Geben sie die Breite ein.");
                    string Btwo = Console.ReadLine();
                    if (Btwo == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int BtwoR = Convert.ToInt32(Btwo);
                    Console.WriteLine($"Die Fläche beträgt: {twoR * BtwoR}__²\n" +
                        $"Der Umfang beträgt: {twoR + twoR + BtwoR + BtwoR}__");
                    if (twoR == BtwoR)
                    {
                        Console.WriteLine("HINWEIS: Sie haben ein Quadrat berechnet");
                    }
                }
                if (menu == 3)
                {
                    int a;
                    Console.WriteLine("Geben sie die Länge ein");
                    string three = Console.ReadLine();
                    if (three == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int threeP = Convert.ToInt32(three);
                    Console.WriteLine("Geben sie die Höhe ein");
                    string threeH = Console.ReadLine();
                    if (threeH == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int threeQH = Convert.ToInt32(threeH);
                    Console.WriteLine($"Ihre Fläche beträgt: {threeP * threeQH}__²");
                    Console.WriteLine("Wollen sie den Umfang berechnen [ja] oder das Programm beenden [exit]?");
                    string threeU = Console.ReadLine();
                    if (threeU == "ja")
                    {
                        Console.WriteLine("Geben sie die Breite ein.");
                        string threeUm = Console.ReadLine();
                        int threeUI = Convert.ToInt32(threeUm);
                        Console.WriteLine($"Der Umfang beträgt: {threeUI + threeUI + three + three}__");
                    }
                    if (threeU == "exit")
                    {
                        Environment.Exit(0);
                    }
                }
                if (menu == 4)
                {
                    string four = Console.ReadLine();
                    if (four == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int fourT = Convert.ToInt32(four);
                }
                if (menu == 5)
                {
                    string five = Console.ReadLine();
                    if (five == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int fiveD = Convert.ToInt32(five);
                }
                if (menu == 6)
                {
                    string six = Console.ReadLine();
                    if (six == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int sixD = Convert.ToInt32(six);
                }
                if (menu == 7)
                {
                    string seven = Console.ReadLine();
                    if (seven == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int sevenR = Convert.ToInt32(seven);
                }
                if (menu == 8)
                {
                    string eight = Console.ReadLine();
                    if (eight == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int eightD = Convert.ToInt32(eight);
                }
                if (menu == 9)
                {
                    string nine = Console.ReadLine();
                    if (nine == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int nineK = Convert.ToInt32(nine);
                }
                else if (menu < 1 || menu > 9)
                {
                    Console.WriteLine("Falsche Eingabe, bitte versuchen sie es nochmal");
                }





                Console.ReadLine();
            } while (true);


        }
    }
}
