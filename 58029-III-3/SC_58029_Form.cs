
using System;

using System.Drawing;
using System.Linq;

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

            Button sc_58029_Oblicz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Sortuj", 385, 75, 65, 25, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Sortuj");
            sc_58029_Oblicz.Click += new EventHandler(sc_58029_Sortuj_Click);
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
            int x = 0;
            int n = sc_58029_Tablica.Length;
            do
            {
                x++;
                for (int i = 0; i < n - 1; i++)
                {
                    if (sc_58029_Tablica[i] > sc_58029_Tablica[i + 1])
                    {
                        int temp = sc_58029_Tablica[i];
                        sc_58029_Tablica[i] = sc_58029_Tablica[i + 1];
                        sc_58029_Tablica[i + 1] = temp;
                    }
                }
                n--;
            }
            while (n > 1);

            sc_58029_FindWynik.Text = $"Posortowane liczby: \n { string.Join(", ", sc_58029_Tablica)}";

        }

        private void sc_58029_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sc_58029_KompLZW_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            double a, b, c, d, x1, x2, x, y;
            Control sc_58029_FindA = this.Controls.Find("SC_58029_A", true)[0];
            Control sc_58029_FindB = this.Controls.Find("SC_58029_B", true)[0];
            Control sc_58029_FindC = this.Controls.Find("SC_58029_C", true)[0];
            Label sc_58029_FindWynik = (Label)this.Controls.Find("SC_58029_WynikLabel", true)[0];
            GroupBox FindWykres = (GroupBox)this.Controls.Find("SC_58029_GbWykres", true)[0];

            a = Double.Parse(sc_58029_FindA.Text);
            b = Double.Parse(sc_58029_FindB.Text);
            c = Double.Parse(sc_58029_FindC.Text);
          
            
           

            d = b * b - 4 * a * c;
            if (d < 0)
            {
                sc_58029_FindWynik.Text ="Dla parametrów a = " + a + ", b = " + b + ", c = " + c + ", \n" +
                "Delta wynosi " + d + ", natomiast każda ujemna delta nie posiada rozwiązań.";
            }
            else
            {
                if (d == 0)
                {
                    x1 = -b / (2 * a);
                    sc_58029_FindWynik.Text = "Dla parametrów a = " + a + ", b = " + b + ", c = " + c + ", \n" +
                    "Delta jest równa " + d + ", dlatego posiada jedno rozwiązanie x = " + x1;
                }
                else
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    sc_58029_FindWynik.Text = "Dla parametrów a = " + a + ", b = " + b + ", c = " + c + ", \n"+
                    "Delta wynosi pierwiastek z: " + d + " = " + Math.Sqrt(d) + ", oraz posiada dwa rozwiązania (x1 = " + x1 + "), (x2 = " + x2 + ").";
                }
            }
            Bitmap pen = new Bitmap(1, 1);
            pen.SetPixel(0, 0, Color.White);
            Graphics g = FindWykres.CreateGraphics();
            int test_x = FindWykres.Width / 2;
            int test_y = FindWykres.Height / 2;
            for (double i = 0; i <= 600; i += 0.002)
            {
                x = i;
                y = (a * (x * x)) + ((b * x) + c);
                g.DrawImageUnscaled(pen, test_x + (int)x, test_y - (int)y);
                g.DrawImageUnscaled(pen, test_x - (int)x, test_y - (int)y);
                if (y >= test_y)
                    break; 
            }
            g.Dispose();
        }


        private void sc_58029_Wstecz_Click(object sender, EventArgs e)
        {
            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();

            SC_58029_LoadControlls();

        }
    }
}
