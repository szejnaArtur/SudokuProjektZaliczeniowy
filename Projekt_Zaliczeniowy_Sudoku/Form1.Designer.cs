namespace Projekt_Zaliczeniowy_Sudoku
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.łatwaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trudnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podpowiedzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczPoleJakoSzareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozwiązanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opisProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H,
            this.I});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(33, 39);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.Height = 50;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(453, 453);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValidated);
            this.dataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView_Paint);
            // 
            // A
            // 
            this.A.FillWeight = 50F;
            this.A.Frozen = true;
            this.A.HeaderText = "A";
            this.A.MaxInputLength = 1;
            this.A.MinimumWidth = 50;
            this.A.Name = "A";
            this.A.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.A.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.A.Width = 50;
            // 
            // B
            // 
            this.B.FillWeight = 50F;
            this.B.Frozen = true;
            this.B.HeaderText = "B";
            this.B.MaxInputLength = 1;
            this.B.Name = "B";
            this.B.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.B.Width = 50;
            // 
            // C
            // 
            this.C.FillWeight = 50F;
            this.C.Frozen = true;
            this.C.HeaderText = "C";
            this.C.MaxInputLength = 1;
            this.C.Name = "C";
            this.C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.C.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C.Width = 50;
            // 
            // D
            // 
            this.D.FillWeight = 50F;
            this.D.Frozen = true;
            this.D.HeaderText = "D";
            this.D.MaxInputLength = 1;
            this.D.Name = "D";
            this.D.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D.Width = 50;
            // 
            // E
            // 
            this.E.FillWeight = 50F;
            this.E.Frozen = true;
            this.E.HeaderText = "E";
            this.E.MaxInputLength = 1;
            this.E.Name = "E";
            this.E.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.E.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.E.Width = 50;
            // 
            // F
            // 
            this.F.FillWeight = 50F;
            this.F.Frozen = true;
            this.F.HeaderText = "F";
            this.F.MaxInputLength = 1;
            this.F.Name = "F";
            this.F.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.F.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.F.Width = 50;
            // 
            // G
            // 
            this.G.FillWeight = 50F;
            this.G.Frozen = true;
            this.G.HeaderText = "G";
            this.G.MaxInputLength = 1;
            this.G.Name = "G";
            this.G.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.G.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.G.Width = 50;
            // 
            // H
            // 
            this.H.FillWeight = 50F;
            this.H.Frozen = true;
            this.H.HeaderText = "H";
            this.H.MaxInputLength = 1;
            this.H.Name = "H";
            this.H.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.H.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.H.Width = 50;
            // 
            // I
            // 
            this.I.FillWeight = 50F;
            this.I.Frozen = true;
            this.I.HeaderText = "I";
            this.I.MaxInputLength = 1;
            this.I.Name = "I";
            this.I.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.I.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.I.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pPlikToolStripMenuItem,
            this.analizaToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pPlikToolStripMenuItem
            // 
            this.pPlikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.wczytajToolStripMenuItem1,
            this.wyjdźToolStripMenuItem});
            this.pPlikToolStripMenuItem.Name = "pPlikToolStripMenuItem";
            this.pPlikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.pPlikToolStripMenuItem.Text = "Plik";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.łatwaToolStripMenuItem,
            this.średniaToolStripMenuItem,
            this.trudnaToolStripMenuItem});
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.nowaGraToolStripMenuItem.Text = "Nowa Gra";
            // 
            // łatwaToolStripMenuItem
            // 
            this.łatwaToolStripMenuItem.Name = "łatwaToolStripMenuItem";
            this.łatwaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.łatwaToolStripMenuItem.Text = "Łatwa";
            this.łatwaToolStripMenuItem.Click += new System.EventHandler(this.łatwaToolStripMenuItem_Click);
            // 
            // średniaToolStripMenuItem
            // 
            this.średniaToolStripMenuItem.Name = "średniaToolStripMenuItem";
            this.średniaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.średniaToolStripMenuItem.Text = "Średnia";
            this.średniaToolStripMenuItem.Click += new System.EventHandler(this.średniaToolStripMenuItem_Click);
            // 
            // trudnaToolStripMenuItem
            // 
            this.trudnaToolStripMenuItem.Name = "trudnaToolStripMenuItem";
            this.trudnaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.trudnaToolStripMenuItem.Text = "Trudna";
            this.trudnaToolStripMenuItem.Click += new System.EventHandler(this.trudnaToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.wczytajToolStripMenuItem.Text = "Zapisz";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem1
            // 
            this.wczytajToolStripMenuItem1.Name = "wczytajToolStripMenuItem1";
            this.wczytajToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.wczytajToolStripMenuItem1.Text = "Wczytaj";
            this.wczytajToolStripMenuItem1.Click += new System.EventHandler(this.wczytajToolStripMenuItem1_Click);
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // analizaToolStripMenuItem
            // 
            this.analizaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podpowiedzToolStripMenuItem,
            this.rozwiązanieToolStripMenuItem});
            this.analizaToolStripMenuItem.Name = "analizaToolStripMenuItem";
            this.analizaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.analizaToolStripMenuItem.Text = "Analiza";
            // 
            // podpowiedzToolStripMenuItem
            // 
            this.podpowiedzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaznaczPoleJakoSzareToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.podpowiedzToolStripMenuItem.Name = "podpowiedzToolStripMenuItem";
            this.podpowiedzToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.podpowiedzToolStripMenuItem.Text = "Podpowiedz";
            // 
            // zaznaczPoleJakoSzareToolStripMenuItem
            // 
            this.zaznaczPoleJakoSzareToolStripMenuItem.Name = "zaznaczPoleJakoSzareToolStripMenuItem";
            this.zaznaczPoleJakoSzareToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.zaznaczPoleJakoSzareToolStripMenuItem.Text = "Odkryj losowe pole ";
            this.zaznaczPoleJakoSzareToolStripMenuItem.Click += new System.EventHandler(this.zaznaczPoleJakoSzareToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.usuńToolStripMenuItem.Text = "Usuń błędy";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // rozwiązanieToolStripMenuItem
            // 
            this.rozwiązanieToolStripMenuItem.Name = "rozwiązanieToolStripMenuItem";
            this.rozwiązanieToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.rozwiązanieToolStripMenuItem.Text = "Rozwiązanie";
            this.rozwiązanieToolStripMenuItem.Click += new System.EventHandler(this.rozwiązanieToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem,
            this.opisProgramuToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.pomocToolStripMenuItem.Text = "Zasady";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // opisProgramuToolStripMenuItem
            // 
            this.opisProgramuToolStripMenuItem.Name = "opisProgramuToolStripMenuItem";
            this.opisProgramuToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.opisProgramuToolStripMenuItem.Text = "Autor";
            this.opisProgramuToolStripMenuItem.Click += new System.EventHandler(this.opisProgramuToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(522, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "2";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(522, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "3";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(522, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "4";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(522, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 22);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "5";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(522, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(41, 22);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "6";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(522, 179);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(41, 22);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "7";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(522, 207);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(41, 22);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "8";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.Location = new System.Drawing.Point(522, 235);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(41, 22);
            this.textBox8.TabIndex = 24;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "9";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox9.Location = new System.Drawing.Point(522, 263);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 22);
            this.textBox9.TabIndex = 26;
            this.textBox9.Text = "0";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 519);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podpowiedzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozwiązanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opisProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem łatwaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trudnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczPoleJakoSzareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
    }
}

