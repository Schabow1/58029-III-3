
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _58029_III_3
{
    public partial class SC_58029_Form : Form
    {
        public static SC_58029_Form sc_58029_Form;
        SC_58029_Controlls sc_58029_Ctrl = new SC_58029_Controlls();
        public SC_58029_Form()
        {
            InitializeComponent();

            SC_58029_LoadControlls();
        }

        private void SC_58029_LoadControlls()
        {
            sc_58029_Form = this;
            this.Width = (int)(300);
            this.Height = (int)(500);

            Font sc_58029_Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            string SC_58029_Text;

            Button sc_58029_BtAutoGenerate = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_RowKwad", 12, 25, 255, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "RÓWNANIE KWADRATOWE");
            sc_58029_BtAutoGenerate.Click += new EventHandler(SC_58029_RowKwad_Click);
            sc_58029_BtAutoGenerate.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_BtAutoGenerate.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            sc_58029_Form.Controls.Add(sc_58029_BtAutoGenerate);

            Button sc_58029_BtManualGenerate = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_KompLZW", 12, 90, 255, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "KOMPRESJA LZW");
            sc_58029_BtManualGenerate.Click += new EventHandler(sc_58029_KompLZW_Click);
            sc_58029_BtManualGenerate.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_BtManualGenerate.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            sc_58029_Form.Controls.Add(sc_58029_BtManualGenerate);

            Button sc_58029_Clear = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Sort", 12, 155, 255, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "SORTOWANIE");
            sc_58029_Clear.Click += new EventHandler(SC_58029_Sort_Click);
            sc_58029_Clear.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Clear.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            sc_58029_Form.Controls.Add(sc_58029_Clear);

            Button sc_58029_Exit = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Exit", 12, 390, 255, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "EXIT");
            sc_58029_Exit.Click += new EventHandler(sc_58029_Exit_Click);
            sc_58029_Exit.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Exit.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            sc_58029_Form.Controls.Add(sc_58029_Exit);
        }

        private void SC_58029_Sort_Click(object sender, EventArgs e)
        {
            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();
            sc_58029_Form = this;
            this.Width = (int)(980);
            this.Height = (int)(500);

            Font sc_58029_Font = new Font("Arial", 11, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_TextBoxColor = Color.AntiqueWhite;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            string SC_58029_Text;
            Point sc_58029_Location = new Point();

            GroupBox SC_58029_Gb002 = sc_58029_Ctrl.SC_58029_Create_GroupBox(10, 5, 485, 450, "", "SC_58029_GbParameters", sc_58029_BackColor);
            sc_58029_Form.Controls.Add(SC_58029_Gb002);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 20;
            Label sc_58029_DaneLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 25, "Wprowadź pięć cyfr do posortowania:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneLabel);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneA = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneA", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "A:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneA);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_A = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_A", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_HeightBox.Leave += new EventHandler(SC_58029_ValueProtectorHeight);
            SC_58029_Gb002.Controls.Add(sc_58029_A);

            sc_58029_Location.X = 80;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneB = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneB", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "B:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneB);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_B = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_B", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_WidthBox.Leave += new EventHandler(SC_58029_ValueProtectorWidth);
            SC_58029_Gb002.Controls.Add(sc_58029_B);

            sc_58029_Location.X = 155;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneC = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneC", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "C:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneC);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_C = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_C", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_HeightBox.Leave += new EventHandler(SC_58029_ValueProtectorHeight);
            SC_58029_Gb002.Controls.Add(sc_58029_C);

            sc_58029_Location.X = 230;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneD = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneD", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "D:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneD);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_D = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_D", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_HeightBox.Leave += new EventHandler(SC_58029_ValueProtectorHeight);
            SC_58029_Gb002.Controls.Add(sc_58029_D);

            sc_58029_Location.X = 305;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneE = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneE", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "E:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneE);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_E = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_E", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_HeightBox.Leave += new EventHandler(SC_58029_ValueProtectorHeight);
            SC_58029_Gb002.Controls.Add(sc_58029_E);

            Button sc_58029_Sortuj = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Sortuj", 385, 75, 65, 25, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Sortuj");
            sc_58029_Sortuj.Click += new EventHandler(sc_58029_Sortuj_Click);
            sc_58029_Sortuj.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Sortuj.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Sortuj);

            Button sc_58029_Exit = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Exit", 375, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "EXIT");
            sc_58029_Exit.Click += new EventHandler(sc_58029_Exit_Click);
            sc_58029_Exit.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Exit.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Exit);

            Button sc_58029_Wstecz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Wstecz", 10, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "WSTECZ");
            sc_58029_Wstecz.Click += new EventHandler(sc_58029_Wstecz_Click);
            sc_58029_Wstecz.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Wstecz.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Wstecz);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 150;
            Label sc_58029_Wynik = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_WynikLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 100, "");
            SC_58029_Gb002.Controls.Add(sc_58029_Wynik);

            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(505, 5, 450, 450, "", "SC_58029_GbDemo", sc_58029_BackColor);
            sc_58029_Form.Controls.Add(SC_58029_Gb001);
        }

        private void sc_58029_Sortuj_Click(object sender, EventArgs y)
        {

            
            Control sc_58029_FindA = this.Controls.Find("SC_58029_A", true)[0];
            Control sc_58029_FindB = this.Controls.Find("SC_58029_B", true)[0];
            Control sc_58029_FindC = this.Controls.Find("SC_58029_C", true)[0];
            Control sc_58029_FindD = this.Controls.Find("SC_58029_D", true)[0];
            Control sc_58029_FindE = this.Controls.Find("SC_58029_E", true)[0];
            Label sc_58029_FindWynik = (Label)this.Controls.Find("SC_58029_WynikLabel", true)[0];
            GroupBox FindWykres = (GroupBox)this.Controls.Find("SC_58029_GbDemo", true)[0];
            int a, b, c, d, e;
            a = Int32.Parse(sc_58029_FindA.Text);
            b = Int32.Parse(sc_58029_FindB.Text);
            c = Int32.Parse(sc_58029_FindC.Text);
            d = Int32.Parse(sc_58029_FindD.Text);
            e = Int32.Parse(sc_58029_FindE.Text);


           


            int[] sc_58029_Tablica = { a, b, c, d, e };
            BubbleSort.Sort(ref sc_58029_Tablica);         

            sc_58029_FindWynik.Text = $"Posortowane liczby: \n { string.Join(", ", sc_58029_Tablica)}";

        }

        private void sc_58029_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sc_58029_KompLZW_Click(object sender, EventArgs e)
        {
            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();
            sc_58029_Form = this;
            this.Width = (int)(980);
            this.Height = (int)(500);

            Font sc_58029_Font = new Font("Arial", 11, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_TextBoxColor = Color.AntiqueWhite;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            string SC_58029_Text;
            Point sc_58029_Location = new Point();

            GroupBox SC_58029_Gb002 = sc_58029_Ctrl.SC_58029_Create_GroupBox(10, 5, 485, 450, "", "SC_58029_GbParameters", sc_58029_BackColor);
            sc_58029_Form.Controls.Add(SC_58029_Gb002);

            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(505, 5, 450, 450, "", "SC_58029_GbKod", sc_58029_BackColor);
            sc_58029_Form.Controls.Add(SC_58029_Gb001);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 20;
            Label sc_58029_DaneLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 25, "Wprowadź ciąg znaków do kompresji:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneLabel);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 50;
            TextBox sc_58029_A = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_Ciag", sc_58029_Location, 470, 60, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            SC_58029_Gb002.Controls.Add(sc_58029_A);
            sc_58029_A.Multiline = true;

            Button sc_58029_Komp = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Komp", 185, 120, 95, 25, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Kompresja");
            sc_58029_Komp.Click += new EventHandler(sc_58029_Kompresja_Click);
            sc_58029_Komp.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Komp.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Komp);


            Button sc_58029_Exit = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Exit", 375, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "EXIT");
            sc_58029_Exit.Click += new EventHandler(sc_58029_Exit_Click);
            sc_58029_Exit.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Exit.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Exit);

            Button sc_58029_Wstecz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Wstecz", 10, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "WSTECZ");
            sc_58029_Wstecz.Click += new EventHandler(sc_58029_Wstecz_Click);
            sc_58029_Wstecz.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Wstecz.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Wstecz);
        }
    

    private void sc_58029_Kompresja_Click(object sender, EventArgs e)
        {
            Font sc_58029_Font = new Font("Arial", 11, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_TextBoxColor = Color.AntiqueWhite;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            string SC_58029_Text;
            Point sc_58029_Location = new Point();

            GroupBox SC_58029_Gb002 = (GroupBox)this.Controls.Find("SC_58029_GbParameters", true)[0];
            GroupBox SC_58029_Gb001 = (GroupBox)this.Controls.Find("SC_58029_GbKod", true)[0];
            TextBox SC_58029_Ciag = (TextBox)this.Controls.Find("SC_58029_Ciag", true)[0];
            Button SC_58029_Kom = (Button)this.Controls.Find("SC_58029_Komp", true)[0];
            SC_58029_Kom.Visible = false;

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 170;
            Label sc_58029_DaneLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 250, 25, "Wynik dekompresji:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneLabel);


            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 10;
            Label sc_58029_Kod = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_Kod", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 25, "");
            SC_58029_Gb001.Controls.Add(sc_58029_Kod);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 200;
            TextBox sc_58029_Dekom = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_Dekom", sc_58029_Location, 470, 60, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            SC_58029_Gb002.Controls.Add(sc_58029_Dekom);
            sc_58029_Dekom.Multiline = true;
            sc_58029_Dekom.ReadOnly = true;

            Button sc_58029_Reset = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Reset", 190, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Reset");
            sc_58029_Reset.Click += new EventHandler(sc_58029_KompLZW_Click);
            sc_58029_Reset.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Reset.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Reset);

            List<int> compressed = Kompresja.LZW(SC_58029_Ciag.Text);
            sc_58029_Kod.Text = (string.Join(", ", compressed));
            string decompressed = Dekompresja.LZW(compressed);
            sc_58029_Dekom.Text =(decompressed);
        }

        void SC_58029_BtDefault_MouseLeave(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            SC_58029_ChangeColor(sc_58029_Sender, 2);
        }

        void SC_58029_BtColor_MouseHover(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            SC_58029_ChangeColor(sc_58029_Sender, 1);
        }

        void SC_58029_ChangeColor(object sc_58029_Sender, int sc_58029_Mode)
        {
            Button sc_58029_Button = sc_58029_Sender as Button;
            switch (sc_58029_Mode)
            {
                case 1:
                    sc_58029_Button.BackColor = Color.Orange;
                    break;
                case 2:
                    sc_58029_Button.BackColor = Color.FromKnownColor(KnownColor.Control);
                    break;
            }
        }

        private void SC_58029_RowKwad_Click(object sender, EventArgs e)
        {
            
            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();
            sc_58029_Form = this;
            this.Width = (int)(980);
            this.Height = (int)(500);

            Font sc_58029_Font = new Font("Arial", 11, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_TextBoxColor = Color.AntiqueWhite;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            string SC_58029_Text;
            Point sc_58029_Location = new Point();

            GroupBox SC_58029_Gb002 = sc_58029_Ctrl.SC_58029_Create_GroupBox(10, 5, 485, 450, "", "SC_58029_GbParameters", sc_58029_BackColor);  
            sc_58029_Form.Controls.Add(SC_58029_Gb002);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 20;
            Label sc_58029_DaneLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 25, "Wprowadź rządne parametry równania kwadratowego:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneLabel);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneA = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneA", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "A:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneA);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_A = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_A", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_HeightBox.Leave += new EventHandler(SC_58029_ValueProtectorHeight);

            SC_58029_Gb002.Controls.Add(sc_58029_A);

            sc_58029_Location.X = 80;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneB = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneB", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "B:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneB);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_B = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_B", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_WidthBox.Leave += new EventHandler(SC_58029_ValueProtectorWidth);
            SC_58029_Gb002.Controls.Add(sc_58029_B);

            sc_58029_Location.X = 155;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneC = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneC", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "C:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneC);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_C = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_C", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            //sc_58029_HeightBox.Leave += new EventHandler(SC_58029_ValueProtectorHeight);
            SC_58029_Gb002.Controls.Add(sc_58029_C);

            Button sc_58029_Oblicz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Oblicz", 240, 75, 65, 25, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Oblicz");
            sc_58029_Oblicz.Click += new EventHandler(sc_58029_Oblicz_Click);
            sc_58029_Oblicz.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Oblicz.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Oblicz);

            Button sc_58029_Exit = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Exit", 375, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "EXIT");
            sc_58029_Exit.Click += new EventHandler(sc_58029_Exit_Click);
            sc_58029_Exit.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Exit.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Exit);

            Button sc_58029_Wstecz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Wstecz", 10, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "WSTECZ");
            sc_58029_Wstecz.Click += new EventHandler(sc_58029_Wstecz_Click);
            sc_58029_Wstecz.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Wstecz.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Wstecz);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 150;
            Label sc_58029_Wynik = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_WynikLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 100, "");
            SC_58029_Gb002.Controls.Add(sc_58029_Wynik);

            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(505, 5, 450, 450, "", "SC_58029_GbWykres", sc_58029_BackColor = Color.Black);
            sc_58029_Form.Controls.Add(SC_58029_Gb001);
        }

        private void sc_58029_Oblicz_Click(object sender, EventArgs e)
        {
            double sc_58029_A, sc_58029_B, sc_58029_C, sc_58029_D, sc_58029_X1, sc_58029_X2, sc_58029_X, sc_58029_Y;
            Control sc_58029_FindA = this.Controls.Find("SC_58029_A", true)[0];
            Control sc_58029_FindB = this.Controls.Find("SC_58029_B", true)[0];
            Control sc_58029_FindC = this.Controls.Find("SC_58029_C", true)[0];
            Label sc_58029_FindWynik = (Label)this.Controls.Find("SC_58029_WynikLabel", true)[0];
            GroupBox sc_58029_FindWykres = (GroupBox)this.Controls.Find("SC_58029_GbWykres", true)[0];

            sc_58029_A = Double.Parse(sc_58029_FindA.Text);
            sc_58029_B = Double.Parse(sc_58029_FindB.Text);
            sc_58029_C = Double.Parse(sc_58029_FindC.Text);
              

            sc_58029_D = sc_58029_B * sc_58029_B - 4 * sc_58029_A * sc_58029_C;
            if (sc_58029_D < 0)
            {
                sc_58029_FindWynik.Text ="Dla parametrów a = " + sc_58029_A + ", b = " + sc_58029_B + ", c = " + sc_58029_C + ", \n" +
                "Delta wynosi " + sc_58029_D + ", natomiast każda ujemna delta nie posiada rozwiązań.";
            }
            else
            {
                if (sc_58029_D == 0)
                {
                    sc_58029_X1 = -sc_58029_B / (2 * sc_58029_A);
                    sc_58029_FindWynik.Text = "Dla parametrów a = " + sc_58029_A + ", b = " + sc_58029_B + ", c = " + sc_58029_C + ", \n" +
                    "Delta jest równa " + sc_58029_D + ", dlatego posiada jedno rozwiązanie x = " + sc_58029_X1;
                }
                else
                {
                    sc_58029_X1 = (-sc_58029_B - Math.Sqrt(sc_58029_D)) / (2 * sc_58029_A);
                    sc_58029_X2 = (-sc_58029_B + Math.Sqrt(sc_58029_D)) / (2 * sc_58029_A);
                    sc_58029_FindWynik.Text = "Dla parametrów a = " + sc_58029_A + ", b = " + sc_58029_B + ", c = " + sc_58029_C + ", \n"+
                    "Delta wynosi pierwiastek z: " + sc_58029_D + " = " + Math.Sqrt(sc_58029_D) + ", oraz posiada dwa rozwiązania (x1 = " + sc_58029_X1 + "), (x2 = " + sc_58029_X2 + ").";
                }
            }
            Bitmap sc_58029_P = new Bitmap(1, 1);
            sc_58029_P.SetPixel(0, 0, Color.White);
            Graphics sc_58029_G = sc_58029_FindWykres.CreateGraphics();
            int test_x = sc_58029_FindWykres.Width / 2;
            int test_y = sc_58029_FindWykres.Height / 2;
            for (double i = 0; i <= 600; i += 0.002)
            {
                sc_58029_X = i;
                sc_58029_Y = (sc_58029_A * (sc_58029_X * sc_58029_X)) + ((sc_58029_B * sc_58029_X) + sc_58029_C);
                sc_58029_G.DrawImageUnscaled(sc_58029_P, test_x + (int)sc_58029_X, test_y - (int)sc_58029_Y);
                sc_58029_G.DrawImageUnscaled(sc_58029_P, test_x - (int)sc_58029_X, test_y - (int)sc_58029_Y);
                if (sc_58029_Y >= test_y)
                    break; 
            }
            sc_58029_G.Dispose();
        }


        private void sc_58029_Wstecz_Click(object sender, EventArgs e)
        {
            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();

            SC_58029_LoadControlls();

        }
    }
}
