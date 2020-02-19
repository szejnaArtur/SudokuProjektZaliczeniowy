using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Projekt_Zaliczeniowy_Sudoku
{
    class ZapiszWczytaj
    {
        const string nazwa_pliku = "Sudoku.xml";

        public void wyczyscPlik()
        {
            if (File.Exists(nazwa_pliku))
            {
                XDocument xml = XDocument.Load(@nazwa_pliku);
                XElement root = xml.Root;
                root.RemoveAll();
                root.Save(@nazwa_pliku);
            }
        }

        #region zapis
        public void zapis(int[,] tablica, string nazwaTablicy)
        {
            if (!File.Exists(nazwa_pliku))
            {
                XDocument documentXML = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Sudoku"));
                documentXML.Save(@nazwa_pliku);
            }

            XDocument xml = XDocument.Load(@nazwa_pliku);
            XElement root = xml.Root;
            root.Add(new XElement("Gra",
                new XAttribute("nazwa", nazwaTablicy)));

            var query = from a in xml.Root.Elements("Gra")
                        where a.Attribute("nazwa").Value == nazwaTablicy
                        select a;

            foreach (var item in query)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        item.Add(new XElement("Pole",
                            new XAttribute("wiersz", i + 1),
                            new XAttribute("Kolumna", j + 1),
                            tablica[i, j]));
                    }
                }
            }
            root.Save(@nazwa_pliku);
        }

        public void zapis(bool[,] tablica, string nazwaTablicy)
        {
            if (!File.Exists(nazwa_pliku))
            {
                XDocument documentXML = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Sudoku"));
                documentXML.Save(@nazwa_pliku);
            }

            XDocument xml = XDocument.Load(@nazwa_pliku);
            XElement root = xml.Root;
            root.Add(new XElement("Gra",
                new XAttribute("nazwa", nazwaTablicy)));

            var query = from a in xml.Root.Elements("Gra")
                        where a.Attribute("nazwa").Value == nazwaTablicy
                        select a;

            foreach (var item in query)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        item.Add(new XElement("Pole",
                            new XAttribute("wiersz", i + 1),
                            new XAttribute("Kolumna", j + 1),
                            tablica[i, j]));
                    }
                }
            }
            root.Save(@nazwa_pliku);
        }
        #endregion

        #region wczytywanie
        public void wczytaj(int[,] tablica, string nazwaTablicy)
        {
            XDocument xml = XDocument.Load(@nazwa_pliku);

            var query = from a in xml.Root.Elements("Gra")
                        where a.Attribute("nazwa").Value == nazwaTablicy
                        select a;
            
            foreach (var slowo in query.Elements("Pole"))
            {
                tablica[Convert.ToInt16(slowo.Attribute("wiersz").Value) - 1, Convert.ToInt16(slowo.Attribute("Kolumna").Value) - 1] = Convert.ToInt16(slowo.Value);
            }
        }

        public void wczytaj(bool[,] tablica, string nazwaTablicy)
        {
            XDocument xml = XDocument.Load(@nazwa_pliku);

            var query = from a in xml.Root.Elements("Gra")
                        where a.Attribute("nazwa").Value == nazwaTablicy
                        select a;

            foreach (var slowo in query.Elements("Pole"))
            {
                tablica[Convert.ToInt16(slowo.Attribute("wiersz").Value) - 1, Convert.ToInt16(slowo.Attribute("Kolumna").Value) - 1] = Convert.ToBoolean(slowo.Value);
            }
        }
        #endregion
    }
}
