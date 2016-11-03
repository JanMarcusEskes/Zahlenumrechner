﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenumrechner
{
  class Program
  {

    static int HexToDez(string psHexZahl)
    {
      int liErgebnis = 0;
      int j = 0;
      int[] liZahl = new int[100];
      liZahl[0] = 0;
      for (int i = 0; i < psHexZahl.Length; i++)
      {
        if (psHexZahl[i] >= '0' && psHexZahl[i] <= '9')
        {
          j++;
          liZahl[j] = psHexZahl[i] - '0';
        }
        else if (psHexZahl[i] >= 'A' && psHexZahl[i] <= 'F')
        {
          j++;
          liZahl[j] = psHexZahl[i] - 'A' + 10;
        }
        else Console.WriteLine("Eingabe ungueltig\n");
      }

      //Umrechnung
      int liVerhältniss = 1;
      for (int i = j; i >= 0; i--)
      {
        liErgebnis += liZahl[i] * liVerhältniss;
        liVerhältniss = liVerhältniss * 16;
      }
      return liErgebnis;
    }

    static string DezToHex(int piDezZahl)
    {
      //Umrechnung
      int liRest;
      int liZwichenrechnung = 1;
      string lsAusgabe = "";
      while (liZwichenrechnung != 0)
      {
        liZwichenrechnung = piDezZahl / 16;
        liRest = piDezZahl % 16;
        if (9 >= liRest)
        {
          lsAusgabe = (char)('0' + liRest) + lsAusgabe;
        }
        else
        {
          liRest = liRest - 10;
          lsAusgabe = (char)('A' + liRest) + lsAusgabe;
        }
        piDezZahl = liZwichenrechnung;
      }
      return lsAusgabe;
    }

    static string DezToOkt(int piDezZahl)
    {
      //Umrechnung
      int liRest;
      int i = 0;
      int j = 0;
      int liZwichenrechnung = 1;
      int[] liErgebnis = new int[100];
      string lsAusgabe = "";
      for (i = 0; i < 100; i++)
      {
        liErgebnis[i] = 0;
      }
      while (liZwichenrechnung != 0)
      {
        liZwichenrechnung = piDezZahl / 8;
        liRest = piDezZahl % 8;
        if (7 >= liRest)
        {
          lsAusgabe = (char)('0' + liRest) + lsAusgabe;
        }
        piDezZahl = liZwichenrechnung;
      }
      return lsAusgabe;
    }

    static int OktToDez(int psOktZahl)
    {
      int liErgebnis = 0;
      int[] liZahl = new int[100];
      int i = 0;
      for (i = 0; i < 100; i++)
      {
        liZahl[i] = 0;
      }
      for (i = 0; i < 100; i++)
      {
        liZahl[i] = psOktZahl % 10;
        psOktZahl -= psOktZahl % 10;
        psOktZahl = psOktZahl / 10;

      }
      //Umrechnung
      int liVerhältniss = 1;
      for (i = 0; i < 100; i++)
      {
        liErgebnis += liZahl[i] * liVerhältniss;
        liVerhältniss = liVerhältniss * 8;

      }
      return liErgebnis;
    }

    static string DezToBin(int piDezZahl)
    {
      //Umrechnung
      int liRest;
      int i = 0;
      int j = 0;
      int liZwichenrechnung = 1;
      int[] liErgebnis = new int[100];
      string lsAusgabe = "";
      for (i = 0; i < 100; i++)
      {
        liErgebnis[i] = 0;
      }
      while (liZwichenrechnung != 0)
      {
        liZwichenrechnung = piDezZahl / 2;
        liRest = piDezZahl % 2;
        if (1 >= liRest)
        {
          lsAusgabe = (char)('0' + liRest) + lsAusgabe;
        }
        piDezZahl = liZwichenrechnung;
      }
      return lsAusgabe;
    }

    static int BinToDez(int psOktZahl)
    {
      int liErgebnis = 0;
      int[] liZahl = new int[100];
      int i = 0;
      for (i = 0; i < 100; i++)
      {
        liZahl[i] = 0;
      }
      for (i = 0; i < 100; i++)
      {
        liZahl[i] = psOktZahl % 10;
        psOktZahl -= psOktZahl % 10;
        psOktZahl = psOktZahl / 10;

      }
      //Umrechnung
      int liVerhältniss = 1;
      for (i = 0; i < 100; i++)
      {
        liErgebnis += liZahl[i] * liVerhältniss;
        liVerhältniss = liVerhältniss * 2;

      }
      return liErgebnis;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      while (true)
      {
        //Einlesen
        Console.Clear();
        Console.Title = "title Zahlen umrechner";
        Console.WriteLine("IN Welches Zahlensystem wollen Sie konvertieren?\n1. Hexadezimal\n2. Dezimal\n3. Oktal\n4. Binaer\nZum auswaehlen das gewuenschte System eingeben.\nZum beenden tippen Sie einfach 'exit' ein.\nEingabe: ");
        string lsMenu;
        lsMenu = Console.ReadLine();
        if (lsMenu == "exit")
        {
          return;
        }
        Console.Clear();
        Console.WriteLine("AUS welchem Zahlensystem soll konvertiert werden?\n1. Hexadezimal\n2. Dezimal\n3. Oktal\n4. Binaer\nZum auswaehlen das gewuenschte System eingeben.\nEingabe: ");
        string lsMenu0;
        lsMenu0 = Console.ReadLine();
        if (lsMenu == "dezimal")
        {
          if (lsMenu0 == "exit")
          {
            return;
          }
          if (lsMenu0 == "dezimal")
          {
            Console.Clear();
            Console.WriteLine("Das ist unnoetig!\n");
            Console.Read();
          }
          else if (lsMenu0 == "hexadezimal")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Dezimal um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            string lEingabe = "";
            lEingabe = Console.ReadLine();
            int lAusgabe = HexToDez(lEingabe);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();

          }
          else if (lsMenu0 == "oktal")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Dezimal um.\nGeben Sie nun die Zahle ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            int lAusgabe = OktToDez(lEingabe);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
          else if (lsMenu0 == "binaer")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Dezimal um.\nGeben Sie nun die Zahle ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            int lAusgabe = BinToDez(lEingabe);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
        }
        else if (lsMenu == "hexadezimal")
        {
          if (lsMenu0 == "exit")
          {
            return;
          }
          if (lsMenu0 == "hexadezimal")
          {
            Console.Clear();
            Console.WriteLine("Das ist unnoetig!\n");
            Console.ReadLine();
          }
          else if (lsMenu0 == "dezimal")
          {
            Console.ReadLine();
            Console.WriteLine("Sie wandeln in Hexadezimal um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            string lAusgabe = DezToHex(lEingabe);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
          else if (lsMenu0 == "oktal")
          {
            Console.ReadLine();
            Console.WriteLine("Sie wandeln in Hexadezimal um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            int lZwichenErgebnis = OktToDez(lEingabe);
            string lAusgabe = DezToHex(lZwichenErgebnis);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
          else if (lsMenu0 == "binaer")
          {
            Console.ReadLine();
            Console.WriteLine("Sie wandeln in Hexadezimal um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            int lZwichenErgebnis = BinToDez(lEingabe);
            string lAusgabe = DezToHex(lZwichenErgebnis);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
        }
        else if (lsMenu == "oktal")
        {
          if (lsMenu0 == "exit")
          {
            return;
          }
          if (lsMenu0 == "oktal")
          {
            Console.Clear();
            Console.WriteLine("Das ist unnoetig!\n");
            Console.ReadLine();
          }
          else if (lsMenu0 == "dezimal")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Oktal um.\nGeben Sie nun die Zahle ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            string lAusgabe = DezToOkt(lEingabe);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
          else if (lsMenu0 == "hexadezimal")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Oktal um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            string lEingabe = "";
            lEingabe = Console.ReadLine(); ;
            int lZwichenErgebnis = HexToDez(lEingabe);
            string lAusgabe = DezToOkt(lZwichenErgebnis);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
          else if (lsMenu0 == "binaer")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Oktal um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            int lZwichenErgebnis = BinToDez(lEingabe);
            string lAusgabe = DezToOkt(lZwichenErgebnis);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
        }
        else if (lsMenu == "binaer")
        {
          if (lsMenu0 == "exit")
          {
            return;
          }
          else if (lsMenu0 == "binaer")
          {
            Console.Clear();
            Console.WriteLine("Das ist unnoetig!\n");
            Console.ReadLine();
          }
          else if (lsMenu0 == "dezimal")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Binaer um.\nGeben Sie nun die Zahle ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            string lAusgabe = DezToBin(lEingabe);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
          else if (lsMenu0 == "hexadezimal")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Binaer um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            string lEingabe = "";
            lEingabe = Console.ReadLine();
            int lZwichenErgebnis = HexToDez(lEingabe);
            string lAusgabe = DezToBin(lZwichenErgebnis);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
          else if (lsMenu0 == "oktal")
          {
            Console.Clear();
            Console.WriteLine("Sie wandeln in Binaer um.\nGeben Sie nun die Zahl ein.\nZahl: ");
            int lEingabe = 0;
            int.TryParse(Console.ReadLine(), out lEingabe);
            int lZwichenErgebnis = OktToDez(lEingabe);
            string lAusgabe = DezToBin(lZwichenErgebnis);
            //Ausgabe
            Console.WriteLine("Ergebnis: " + lAusgabe);
            Console.WriteLine('\n');
            Console.ReadLine();
          }
        }
        else if (lsMenu0 == "exit")
        {
          return;
        }
        else if (lsMenu != "dezimal" && lsMenu != "hexadezimal" && lsMenu != "binaer" && lsMenu != "oktal" && lsMenu != "exit")
        {
          Console.ReadLine();
          Console.WriteLine("Das von Ihnen eingegebene Zahlensystem wird leider nicht unterstuetzt.\n");
          Console.ReadLine();
        }
        if (lsMenu0 != "dezimal" && lsMenu0 != "hexadezimal" && lsMenu0 != "binaer" && lsMenu0 != "oktal" && lsMenu0 != "exit")
        {
          Console.ReadLine();
          Console.WriteLine("Das von Ihnen eingegebene Zahlensystem wird leider nicht unterstuetzt.\n");
          Console.ReadLine();
        }
      }
    }
  }
}

