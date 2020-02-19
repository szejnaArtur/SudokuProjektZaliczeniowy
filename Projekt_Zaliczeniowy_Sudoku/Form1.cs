using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaliczeniowy_Sudoku
{

    public partial class Form1 : Form
    {
        #region Stałe
        private const int SZEROKOSC_KOLUMNY = 50;
        private const int WYSOKOSC_WIERSZA = 50;

        private const int MAX_WIERSZY = 9;
        private const int MAX_KOLUMN = 9;
        #endregion constants

        Sudoku sudoku = new Sudoku();

        public Form1()
        {
            InitializeComponent();
            Inicializacja_DataGridView();
        }

        private void Inicializacja_DataGridView()
        {  

        }

        #region Rysowanie Kontur
        private void dataGridView_Paint(object sender, PaintEventArgs e)  //Tworzy pogrubione linie w tabelce
        {
            Point currentPoint = new Point(0, 0);
            Size size = new Size(SZEROKOSC_KOLUMNY * 3, WYSOKOSC_WIERSZA * 3);
            Pen myPen = new Pen(Color.Black, 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    currentPoint.X = i * SZEROKOSC_KOLUMNY * 3;
                    currentPoint.Y = j * SZEROKOSC_KOLUMNY * 3;
                    Rectangle rect = new Rectangle(currentPoint, size);         
                    e.Graphics.DrawRectangle(myPen, rect);                      
                }
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.RowCount = MAX_WIERSZY;

            sudoku.tasowanieSudoku();
            sudoku.GenerowanieGry(PoziomyGry.SREDNI);
            wypelnijsudoku();
        }

        #region wypełnianie tabeli sudoku
        void wypelnijsudoku()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    DataGridViewCell cell = dataGridView.Rows[i].Cells[j];

                    //Czyszczenie tabeli przed grą
                    dataGridView.Rows[i].Cells[j].ReadOnly = false;
                    dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                    cell.Value = null;

                    //Wypełnianie tabeli liczbami
                    if (sudoku.sudokuPustePola[i, j] != 0)
                    {
                        cell.Value = sudoku.sudokuPustePola[i, j];
                        if (sudoku.tabelaSzarePola[i, j])
                        {
                            dataGridView.Rows[i].Cells[j].ReadOnly = true;
                            dataGridView.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                        }
                    }

                    dataGridView.CurrentCell = cell;
                    dataGridView.BeginEdit(true);
                }
            }
        }
        #endregion

        #region Po wpisaniu
        private void dataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            sudoku.sprawdzPoprawnoscIzapisDanych(dataGridView);
            if (sudoku.sprawdzCzySudokuZostałoRowziazane(dataGridView))
            {
                DialogResult dialogResult = MessageBox.Show("Barwo! Wygrałeś czy chcsz rozpocząć kolejną grę?", "Brawo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    średniaToolStripMenuItem_Click(sudoku, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            iloscLiczb();
        }
        #endregion

        #region rozpocznij gre
        private void łatwaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.tasowanieSudoku();
            sudoku.GenerowanieGry(PoziomyGry.LATWY);
            wypelnijsudoku();
        }

        private void średniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.tasowanieSudoku();
            sudoku.GenerowanieGry(PoziomyGry.SREDNI);
            wypelnijsudoku();
        }

        private void trudnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.tasowanieSudoku();
            sudoku.GenerowanieGry(PoziomyGry.TRUDNY);
            wypelnijsudoku();
        }
        #endregion

        #region O programie
        private void opisProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNIWERSYTET KAZIMIERZA WIELKIEGO\nWYDZIAŁ MATEMATYKI, FIZYKI I TECHNIKI\n\n Program został wykonany w Instytucie Mechaniki i Informatyki Stosowanej przez Artura Szejna w ramach przedmiotu \"Techniki programowania i komunikacja człowiek komputer\"", "Autor");
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zasady gry Sudoku są bardzo proste. Kwadratowy diagram gry podzielony jest na 9 identycznych kwadratów. Każdy z nich jest podzielony na 9 kolejnych. Zadaniem gracza jest wypełnienie wszystkich 81 kwadratów, na które podzielony jest diagram cyframi od 1 do 9. W każdym rzędzie i każdej kolumnie dana cyfra może wystapić jedynie raz. Podobnie w każdym z 9 większych kwadratów - cyfry nie mogą się w nich powtarzać.", "Zasady");
        }
        #endregion

        #region Analiza
        private void rozwiązanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.rozwiazSudoku(dataGridView);
            sudoku.sprawdzPoprawnoscIzapisDanych(dataGridView);
            iloscLiczb();
        }

        private void zaznaczPoleJakoSzareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.podopwiedz_odkryjPole(dataGridView);
            if (sudoku.sprawdzCzySudokuZostałoRowziazane(dataGridView))
            {
                DialogResult dialogResult = MessageBox.Show("Barwo! Wygrałeś czy chcsz rozpocząć kolejną grę?", "Brawo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    średniaToolStripMenuItem_Click(sudoku, e);
                }
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.podpowiedz_usunBledy(dataGridView);
            sudoku.sprawdzPoprawnoscIzapisDanych(dataGridView);
            iloscLiczb();
        }
        #endregion

        #region zamykanie
        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać obecny stan gry przed wyjściem ?", "Zamknij", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ZapiszWczytaj zapisz = new ZapiszWczytaj();
                zapisz.wyczyscPlik();
                zapisz.zapis(sudoku.sudoku_poczatkowe, "sudokuRozwiazane");
                zapisz.zapis(sudoku.sudokuPustePola, "sudokuPustePola");
                zapisz.zapis(sudoku.tabelaSzarePola, "sudokuPolaZablokowane");
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        #endregion

        #region zapisz wczytaj
        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszWczytaj zapisz = new ZapiszWczytaj();
            zapisz.wyczyscPlik();
            zapisz.zapis(sudoku.sudoku_poczatkowe, "sudokuRozwiazane");
            zapisz.zapis(sudoku.sudokuPustePola, "sudokuPustePola");
            zapisz.zapis(sudoku.tabelaSzarePola, "sudokuPolaZablokowane");
        }

        private void wczytajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZapiszWczytaj odczytaj = new ZapiszWczytaj();
            odczytaj.wczytaj(sudoku.sudoku_poczatkowe, "sudokuRozwiazane");
            odczytaj.wczytaj(sudoku.sudokuPustePola, "sudokuPustePola");
            odczytaj.wczytaj(sudoku.tabelaSzarePola, "sudokuPolaZablokowane");
            wypelnijsudoku();
        }
        #endregion

        public void iloscLiczb()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = "0"; 

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku.sudokuPustePola[i, j] != 0)
                    {
                        int liczba = Convert.ToInt16(sudoku.sudokuPustePola[i, j]);

                        switch (liczba)
                        {
                            case 1:
                                {
                                    textBox1.Text = (Convert.ToInt16(textBox1.Text) + 1).ToString();
                                    break;
                                }
                            case 2:
                                {
                                    textBox2.Text = (Convert.ToInt16(textBox2.Text) + 1).ToString();
                                    break;
                                }
                            case 3:
                                {
                                    textBox3.Text = (Convert.ToInt16(textBox3.Text) + 1).ToString();
                                    break;
                                }
                            case 4:
                                {
                                    textBox4.Text = (Convert.ToInt16(textBox4.Text) + 1).ToString();
                                    break;
                                }
                            case 5:
                                {
                                    textBox5.Text = (Convert.ToInt16(textBox5.Text) + 1).ToString();
                                    break;
                                }
                            case 6:
                                {
                                    textBox6.Text = (Convert.ToInt16(textBox6.Text) + 1).ToString();
                                    break;
                                }
                            case 7:
                                {
                                    textBox7.Text = (Convert.ToInt16(textBox7.Text) + 1).ToString();
                                    break;
                                }
                            case 8:
                                {
                                    textBox8.Text = (Convert.ToInt16(textBox8.Text) + 1).ToString();
                                    break;
                                }
                            case 9:
                                {
                                    textBox9.Text = (Convert.ToInt16(textBox9.Text) + 1).ToString();
                                    break;
                                }
                        }
                    }
                }
            }
        }
    }
}
