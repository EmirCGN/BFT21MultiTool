﻿using Figgle;
namespace ITBFTKlassenBibliothek

{
    public class ITMenue
    {
        public static void SubmenueAufruf()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> IT submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Bit und Byte Rechner");
                Console.WriteLine("\t2 - DPi Rechner");
                Console.WriteLine("\t3 - Speicherberechnung von Sounddateien und Videodateien");
                Console.WriteLine("\t4 - Binärer Rechner");
                Console.WriteLine("\texit - Beendung des Programmes\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        //Hier das Etechnikmenü aufrufen
                        break;

                    case "2":
                        Console.Clear();
                        feat14.dpi();
                        break;

                    case "3":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        break;

                    case "4":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        break;


                    case "exit":
                        Exit = true;
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);


        }
    }
}