using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Projekt_Zaliczeniowy_Sudoku
{
    public enum PoziomyGry
    {
        LATWY,
        SREDNI,
        TRUDNY
    }

    class Sudoku
    {
        #region STALE
        private int[] _PozycjaWierszaGlownego = { 0, 0, 0, 3, 3, 3, 6, 6, 6 };
        private int[] _PozycjaKolumnyGlownej = { 0, 3, 6, 0, 3, 6, 0, 3, 6 };
        #endregion


        public int[,] sudoku_poczatkowe = {{7,9,2,3,5,1,8,4,6},
									       {4,6,8,9,2,7,5,1,3},
									       {1,3,5,6,8,4,7,9,2},
									       {6,2,1,5,7,9,4,3,8},
									       {5,8,3,2,4,6,1,7,9},
									       {9,7,4,8,1,3,2,6,5},
								 	       {8,1,6,4,9,2,3,5,7},
									       {3,5,7,1,6,8,9,2,4},
									       {2,4,9,7,3,5,6,8,1}};

        public int[,] sudokuPustePola = new int[9, 9];
        public bool[,] tabelaSzarePola = new bool[9, 9];



        #region Funkcje - Tasowanie startowego sudoku
        private void zamianaWielkichKolumn() //przesuwa wielką kulumne w lewo
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int tymczasowa = sudoku_poczatkowe[i, 0];
                    for (int k = 0; k < 8; k++)
                    {
                        sudoku_poczatkowe[i, k] = sudoku_poczatkowe[i, k + 1];
                    }
                    sudoku_poczatkowe[i, 8] = tymczasowa;
                }
            }
        }

        private void zamianaWielkichWierszy() //przesuwa wielki wiersz w gore
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int tymczasowa = sudoku_poczatkowe[0, i];
                    for (int k = 0; k < 8; k++)
                    {
                        sudoku_poczatkowe[k, i] = sudoku_poczatkowe[k + 1, i];
                    }
                    sudoku_poczatkowe[8, i] = tymczasowa;
                }
            }
        }

        private void zamianaMalychKolumn(int kolumna)
        {
            if (kolumna >= 0 && kolumna < 3)
            {
                kolumna = kolumna * 3;
                for (int i = 0; i < 9; i++){
                    int tymczasowa = sudoku_poczatkowe[i, kolumna];
                    for (int k = 0; k < 2; k++)
                    {
                        sudoku_poczatkowe[i, kolumna + k] = sudoku_poczatkowe[i, kolumna + k + 1];
                    }
                    sudoku_poczatkowe[i, kolumna + 2] = tymczasowa;
                }
            }
        }

        private void zamianaMalychWierszy(int wiersz)
        {
            if (wiersz >= 0 && wiersz < 3)
            {
                wiersz = wiersz * 3;
                for (int i = 0; i < 9; i++)
                {
                    int tymczasowa = sudoku_poczatkowe[wiersz, i];
                    for (int k = 0; k < 2; k++)
                    {
                        sudoku_poczatkowe[wiersz + k, i] = sudoku_poczatkowe[wiersz + k + 1, i];
                    }
                    sudoku_poczatkowe[wiersz + 2, i] = tymczasowa;
                }
            }
        }

        public void tasowanieSudoku()
        {
            Random rand = new Random();
            int losowaLiczba = rand.Next(50, 200);
            for (int i = 0; i < losowaLiczba; i++)
            {
                if (rand.Next(0, 2) == 1)
                    zamianaWielkichKolumn();
                if (rand.Next(0, 2) == 1)
                    zamianaWielkichWierszy();
                if (rand.Next(0, 2) == 1)
                    zamianaMalychKolumn(rand.Next(0, 3));
                if (rand.Next(0, 2) == 1)
                    zamianaMalychWierszy(rand.Next(0, 3));
            }
        }
        #endregion

        #region Funkcje - Sprawdzanie poprawnosci

        private void ZapiszLiczbeWTablicy(int liczba, int wiersz, int kolumna)
        {
            if (liczba >= 1 && liczba <= 9)
            {
                sudokuPustePola[wiersz, kolumna] = liczba;
            }
            else sudokuPustePola[wiersz, kolumna] = 0;
        }

        public void sprawdzPoprawnoscIzapisDanych(DataGridView dataGridView)
        {
            int wiersz = dataGridView.CurrentCell.RowIndex;
            int kolumna = dataGridView.CurrentCell.ColumnIndex;

            if(!tabelaSzarePola[wiersz, kolumna])
            {
                int liczba;

                if (dataGridView.CurrentCell.Value != null && dataGridView.CurrentCell.Value.ToString() != "" && char.IsNumber(dataGridView.CurrentCell.Value.ToString(), 0) && Convert.ToInt16(dataGridView.CurrentCell.Value) != 0)
                {
                    liczba = Convert.ToInt16(dataGridView.CurrentCell.Value);
                    ZapiszLiczbeWTablicy(liczba, wiersz, kolumna);
                }
                else
                {
                    liczba = 0;
                    ZapiszLiczbeWTablicy(liczba, wiersz, kolumna);
                    dataGridView.CurrentCell.Value = null;
                    dataGridView.CurrentCell.Style.BackColor = Color.White;
                }

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!tabelaSzarePola[i, j])
                        {
                            dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;

                            if (Convert.ToInt16(dataGridView.Rows[i].Cells[j].Value) != 0)
                            {
                                for (int k = 0; k < 9; k++)
                                {
                                    //Sprawdzenie wiersza i kolumny
                                    if (sudokuPustePola[i, j] == sudokuPustePola[i, k] && j != k)
                                    {
                                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                    }
                                    
                                    if (sudokuPustePola[i, j] == sudokuPustePola[k, j] && i != k)
                                    {
                                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                    }
                                }

                                //sprawdzenie kwadratu
                                int indeks_wiersza = i - (i % 3);
                                int indeks_kolumny = j - (j % 3);

                                for (int x = indeks_wiersza; x < indeks_wiersza + 3; x++)
                                {
                                    for (int y = indeks_kolumny; y < indeks_kolumny + 3; y++)
                                    {
                                        if (sudokuPustePola[x, y] == sudokuPustePola[i, j] && x != i && y != j)
                                        {
                                            dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Generowanie gry i tablic z nią związanych
        public void GenerowanieGry(PoziomyGry poziom)
        {
            int minPozycji, maxPozycji, niePusteKwadraty;

            switch (poziom)
            {
                case PoziomyGry.LATWY:
                    minPozycji = 4;
                    maxPozycji = 6;
                    niePusteKwadraty = 8;
                    OdkrytePola(minPozycji, maxPozycji, niePusteKwadraty);
                    break;
                case PoziomyGry.SREDNI:
                    minPozycji = 3;
                    maxPozycji = 5;
                    niePusteKwadraty = 7;
                    OdkrytePola(minPozycji, maxPozycji, niePusteKwadraty);
                    break;
                case PoziomyGry.TRUDNY:
                    minPozycji = 3;
                    maxPozycji = 5;
                    niePusteKwadraty = 6;
                    OdkrytePola(minPozycji, maxPozycji, niePusteKwadraty);
                    break;
                default:
                    OdkrytePola(3, 6, 7);
                    break;
            }
        }

        private void OdkrytePola(int minPozycji, int maxPozycji, int niePusteKwadraty)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudokuPustePola[i, j] = 0; 
                    tabelaSzarePola[i, j] = false;
                }
            }

            Random rand = new Random();
            int[] pozycjaX = { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
            int[] pozycjaY = { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
            int[] OdkryteKwadrat = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int iloscKwadatow = 0;

            while (iloscKwadatow < niePusteKwadraty)
            {
                int i = rand.Next(0, 9);
                if (OdkryteKwadrat[i] == 0)
                {
                    OdkryteKwadrat[i]=1;
                    iloscKwadatow++;

                    int ileOdkrytychPol = rand.Next(minPozycji,maxPozycji);
                    int odkrytePolaWKwadracie = 0;

                    while (odkrytePolaWKwadracie <= ileOdkrytychPol)
                    {
                        int nowaPozycja = rand.Next(0,9);
                        int x = _PozycjaWierszaGlownego[i] + pozycjaX[nowaPozycja];
                        nowaPozycja = rand.Next(0, 9);
                        int y = _PozycjaKolumnyGlownej[i] + pozycjaX[nowaPozycja];

                        if (tabelaSzarePola[x, y] == false)
                        {
                            tabelaSzarePola[x, y] = true;
                            sudokuPustePola[x, y] = sudoku_poczatkowe[x, y];
                            odkrytePolaWKwadracie++;
                        }
                    }
                }
            }
        }
        #endregion

        #region sprawdzanie czy sudoku zostało poprawnie rozwiązane
        public bool sprawdzCzySudokuZostałoRowziazane(DataGridView dataGridView)
        {
            for (int i = 0; i < 9; i++)
            {
                int suma = 0;
                for (int j = 0; j < 9; j++)
                {
                    suma += Convert.ToInt16(dataGridView.Rows[i].Cells[j].Value);
                }
                if (suma != 45) return false;

                suma = 0;
            }
                return true;
        }
        #endregion

        #region Analiza
        public void rozwiazSudoku(DataGridView dataGridView)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!tabelaSzarePola[i, j])
                    {
                        ZapiszLiczbeWTablicy(sudoku_poczatkowe[i, j], i, j);
                        dataGridView.Rows[i].Cells[j].Value = sudoku_poczatkowe[i, j];
                    }
                }
            }
        }

        public void podopwiedz_odkryjPole(DataGridView dataGridView)
        {
            Random rand = new Random();
            int wiersz, kolumna;

            while (true)
            {
                wiersz = rand.Next(0, 9);
                kolumna = rand.Next(0, 9);

                if (!tabelaSzarePola[wiersz, kolumna])
                {
                    tabelaSzarePola[wiersz, kolumna] = true;
                    ZapiszLiczbeWTablicy(sudoku_poczatkowe[wiersz, kolumna], wiersz, kolumna);
                    dataGridView.Rows[wiersz].Cells[kolumna].Value = sudoku_poczatkowe[wiersz, kolumna];
                    dataGridView.Rows[wiersz].Cells[kolumna].Style.BackColor = Color.LightGray;
                    dataGridView.Rows[wiersz].Cells[kolumna].ReadOnly = true;
                    break;
                }
            }
        }

        public void podpowiedz_usunBledy(DataGridView dataGridView)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!tabelaSzarePola[i, j] && sudokuPustePola[i, j] != sudoku_poczatkowe[i, j])
                    {
                        sudokuPustePola[i, j] = 0;
                        dataGridView.Rows[i].Cells[j].Value = null;
                    }
                }
            }
        }
        #endregion
    }
}
