
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58029_III_3
{
   
    public partial class SC_58029_Form : Form
    {
        Font sc_58029_Font = new Font("Arial", 11, FontStyle.Bold);
        Color sc_58029_ForeColor = Color.Black;
        Color sc_58029_TextBoxColor = Color.AntiqueWhite;
        Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
        Color sc_58029_BackColorW = Color.Black;
        string SC_58029_Text;
        Point sc_58029_Location = new Point();

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
        #region sortowanie
        private void SC_58029_Sort_Click(object sc_58029_Sender, EventArgs sc_58029_Y)
        {
            sc_58029_UstawOkno();


            GroupBox SC_58029_Gb002 = (GroupBox)this.Controls.Find("SC_58029_GbParameters", true)[0];

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
            sc_58029_A.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            SC_58029_Gb002.Controls.Add(sc_58029_A);

            sc_58029_Location.X = 80;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneB = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneB", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "B:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneB);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_B = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_B", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_B.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            SC_58029_Gb002.Controls.Add(sc_58029_B);

            sc_58029_Location.X = 155;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneC = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneC", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "C:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneC);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_C = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_C", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_C.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            SC_58029_Gb002.Controls.Add(sc_58029_C);

            sc_58029_Location.X = 230;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneD = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneD", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "D:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneD);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_D = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_D", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_D.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            SC_58029_Gb002.Controls.Add(sc_58029_D);

            sc_58029_Location.X = 305;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneE = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneE", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "E:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneE);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_E = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_E", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_E.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            SC_58029_Gb002.Controls.Add(sc_58029_E);

            Button sc_58029_Sortuj = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Sortuj", 385, 75, 65, 25, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Sortuj");
            sc_58029_Sortuj.Click += new EventHandler(sc_58029_Sortuj_Click);
            sc_58029_Sortuj.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Sortuj.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Sortuj);
         

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 150;
            Label sc_58029_Wynik = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_WynikLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 100, "");
            SC_58029_Gb002.Controls.Add(sc_58029_Wynik);

            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(505, 5, 450, 450, "", "SC_58029_GbDemo", sc_58029_BackColor);
            sc_58029_Form.Controls.Add(SC_58029_Gb001);
            Button sc_58029_Demo = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Demo", 190, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "DEMO");
            sc_58029_Demo.Click += new EventHandler(sc_58029_Demo_Click);
            sc_58029_Demo.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Demo.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Demo);



            
        }

        public void sc_58029_Demo_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {



            Color sc_58029_BackColorDemo = Color.Green;
            Color sc_58029_ForeColorDemo = Color.Yellow;
            GroupBox SC_58029_Gb001 = (GroupBox)this.Controls.Find("SC_58029_GbDemo", true)[0];

            if (SC_58029_Gb001.Controls.Count > 0)
                SC_58029_Gb001.Controls.Clear();

            sc_58029_Location.X = 70;
            sc_58029_Location.Y = 200;
            Label sc_58029_Dane1 = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_Dane1", sc_58029_Location, sc_58029_Font, sc_58029_BackColorDemo, sc_58029_ForeColorDemo, 25, 25, "27");
            SC_58029_Gb001.Controls.Add(sc_58029_Dane1);



            sc_58029_Location.X = 125;
            sc_58029_Location.Y = 200;
            Label sc_58029_Dane2 = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_Dane2", sc_58029_Location, sc_58029_Font, sc_58029_BackColorDemo, sc_58029_ForeColorDemo, 25, 25, "12");
            SC_58029_Gb001.Controls.Add(sc_58029_Dane2);



            sc_58029_Location.X = 180;
            sc_58029_Location.Y = 200;
            Label sc_58029_Dane3 = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_Dane3", sc_58029_Location, sc_58029_Font, sc_58029_BackColorDemo, sc_58029_ForeColorDemo, 25, 25, " 2");
            SC_58029_Gb001.Controls.Add(sc_58029_Dane3);


            sc_58029_Location.X = 235;
            sc_58029_Location.Y = 200;
            Label sc_58029_Dane4 = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_Dane4", sc_58029_Location, sc_58029_Font, sc_58029_BackColorDemo, sc_58029_ForeColorDemo, 25, 25, "33");
            SC_58029_Gb001.Controls.Add(sc_58029_Dane4);


            sc_58029_Location.X = 290;
            sc_58029_Location.Y = 200;
            Label sc_58029_Dane5 = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_Dane5", sc_58029_Location, sc_58029_Font, sc_58029_BackColorDemo, sc_58029_ForeColorDemo, 25, 25, "10");
            SC_58029_Gb001.Controls.Add(sc_58029_Dane5);


            Task.Delay(1500).Wait();

            int x1 = sc_58029_Dane1.Location.X;
            int y1 = sc_58029_Dane1.Location.Y;
            int x2= sc_58029_Dane2.Location.X;
            int y2 = sc_58029_Dane2.Location.Y;
            int x3 = sc_58029_Dane3.Location.X;
            int y3 = sc_58029_Dane3.Location.Y;
            int x4 = sc_58029_Dane4.Location.X;
            int y4 = sc_58029_Dane4.Location.Y;
            int x5 = sc_58029_Dane5.Location.X;
            int y5 = sc_58029_Dane5.Location.Y;


            for (double i = 0; i <= 30; i += 0.2)
            {

                Task.Delay(1).Wait();
                sc_58029_Dane2.Location = new Point((int)(x2 - i), (int)(y2 + i));
                sc_58029_Dane1.Location = new Point((int)(x1 + i), (int)(y1 - i));

            }
            x2 = sc_58029_Dane2.Location.X;
            y2 = sc_58029_Dane2.Location.Y;
            x1 = sc_58029_Dane1.Location.X;
            y1 = sc_58029_Dane1.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {
                Task.Delay(1).Wait();
                sc_58029_Dane2.Location = new Point((int)(x2 - i), (int)(y2 - i));
                sc_58029_Dane1.Location = new Point((int)(x1 + i), (int)(y1 + i));

            }
            x1 = sc_58029_Dane1.Location.X;
            y1 = sc_58029_Dane1.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {

                Task.Delay(1).Wait();
                sc_58029_Dane3.Location = new Point((int)(x3 - i), (int)(y3 + i));
                sc_58029_Dane1.Location = new Point((int)(x1 + i), (int)(y1 - i));

            }
            
            x1 = sc_58029_Dane1.Location.X;
            y1 = sc_58029_Dane1.Location.Y;
            x3 = sc_58029_Dane3.Location.X;
            y3 = sc_58029_Dane3.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {
                Task.Delay(1).Wait();
                sc_58029_Dane3.Location = new Point((int)(x3 - i), (int)(y3 - i));
                sc_58029_Dane1.Location = new Point((int)(x1 + i), (int)(y1 + i));

            }

            for (double i = 0; i <= 30; i += 0.2)
            {

                Task.Delay(1).Wait();
                sc_58029_Dane5.Location = new Point((int)(x5 - i), (int)(y5 + i));
                sc_58029_Dane4.Location = new Point((int)(x4 + i), (int)(y4 - i));

            }

            x5 = sc_58029_Dane5.Location.X;
            y5 = sc_58029_Dane5.Location.Y;
            x4 = sc_58029_Dane4.Location.X;
            y4 = sc_58029_Dane4.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {
                Task.Delay(1).Wait();
                sc_58029_Dane5.Location = new Point((int)(x5 - i), (int)(y5 - i));
                sc_58029_Dane4.Location = new Point((int)(x4 + i), (int)(y4 + i-1));

            }

            x2 = sc_58029_Dane2.Location.X;
            y2 = sc_58029_Dane2.Location.Y;
            x3 = sc_58029_Dane3.Location.X;
            y3 = sc_58029_Dane3.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {

                Task.Delay(1).Wait();
                sc_58029_Dane3.Location = new Point((int)(x3 - i), (int)(y3 + i));
                sc_58029_Dane2.Location = new Point((int)(x2 + i), (int)(y2 - i));

            }

            x2 = sc_58029_Dane2.Location.X;
            y2 = sc_58029_Dane2.Location.Y;
            x3 = sc_58029_Dane3.Location.X;
            y3 = sc_58029_Dane3.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {
                Task.Delay(1).Wait();
                sc_58029_Dane3.Location = new Point((int)(x3 - i), (int)(y3 - i));
                sc_58029_Dane2.Location = new Point((int)(x2 + i), (int)(y2 + i));

            }
            x5 = sc_58029_Dane5.Location.X;
            y5 = sc_58029_Dane5.Location.Y;
            x1 = sc_58029_Dane1.Location.X;
            y1 = sc_58029_Dane1.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {

                Task.Delay(1).Wait();
                sc_58029_Dane5.Location = new Point((int)(x5 - i), (int)(y5 + i));
                sc_58029_Dane1.Location = new Point((int)(x1 + i), (int)(y1 - i));

            }
            x5 = sc_58029_Dane5.Location.X;
            y5 = sc_58029_Dane5.Location.Y;
            x1 = sc_58029_Dane1.Location.X;
            y1 = sc_58029_Dane1.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {
                Task.Delay(1).Wait();
                sc_58029_Dane5.Location = new Point((int)(x5 - i), (int)(y5 - i));
                sc_58029_Dane1.Location = new Point((int)(x1 + i), (int)(y1 + i));

            }
            x5 = sc_58029_Dane5.Location.X;
            y5 = sc_58029_Dane5.Location.Y;
            x2 = sc_58029_Dane2.Location.X;
            y2 = sc_58029_Dane2.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {

                Task.Delay(1).Wait();
                sc_58029_Dane5.Location = new Point((int)(x5 - i), (int)(y5 + i));
                sc_58029_Dane2.Location = new Point((int)(x2 + i), (int)(y2 - i));

            }
            x5 = sc_58029_Dane5.Location.X;
            y5 = sc_58029_Dane5.Location.Y;
            x2 = sc_58029_Dane2.Location.X;
            y2 = sc_58029_Dane2.Location.Y;
            for (double i = 0; i <= 30; i += 0.2)
            {
                Task.Delay(1).Wait();
                sc_58029_Dane5.Location = new Point((int)(x5 - i), (int)(y5 - i));
                sc_58029_Dane2.Location = new Point((int)(x2 + i), (int)(y2 + i));

            }
        }

        private void sc_58029_Sortuj_Click(object sc_58029_Sender, EventArgs sc_5802_Y)
        {

            
            Control sc_58029_FindA = this.Controls.Find("SC_58029_A", true)[0];
            Control sc_58029_FindB = this.Controls.Find("SC_58029_B", true)[0];
            Control sc_58029_FindC = this.Controls.Find("SC_58029_C", true)[0];
            Control sc_58029_FindD = this.Controls.Find("SC_58029_D", true)[0];
            Control sc_58029_FindE = this.Controls.Find("SC_58029_E", true)[0];
            Label sc_58029_FindWynik = (Label)this.Controls.Find("SC_58029_WynikLabel", true)[0];
            
            int? sc_58029_A=null, sc_58029_B=null, sc_58029_C=null, sc_58029_D=null, sc_58029_F=null;
            try
            {
                sc_58029_A = Int32.Parse(sc_58029_FindA.Text);
                sc_58029_B = Int32.Parse(sc_58029_FindB.Text);
                sc_58029_C = Int32.Parse(sc_58029_FindC.Text);
                sc_58029_D = Int32.Parse(sc_58029_FindD.Text);
                sc_58029_F = Int32.Parse(sc_58029_FindE.Text);
            }
            catch
            {
                MessageBox.Show("Nie wprowadzono liczb");
            }
            int?[] sc_58029_Tablica = { sc_58029_A, sc_58029_B, sc_58029_C, sc_58029_D, sc_58029_F };
           
                SC_58029_Bubble.SC_58029_Sort(ref sc_58029_Tablica);
                sc_58029_FindWynik.Text = ("Posortowane liczby: \n" + string.Join(", ", sc_58029_Tablica));
          
            

        }
        #endregion
        #region kompresja
        private void sc_58029_KompLZW_Click(object sender, EventArgs e)
        {
            sc_58029_UstawOkno();


            GroupBox SC_58029_Gb002 = (GroupBox)this.Controls.Find("SC_58029_GbParameters", true)[0];

            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(505, 5, 450, 450, "", "SC_58029_GbKod", sc_58029_BackColor);
            sc_58029_Form.Controls.Add(SC_58029_Gb001);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 20;
            Label sc_58029_DaneLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 25, "Wprowadź ciąg znaków do kompresji:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneLabel);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 50;
            TextBox sc_58029_Ciag = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_Ciag", sc_58029_Location, 470, 115, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            SC_58029_Gb002.Controls.Add(sc_58029_Ciag);
            sc_58029_Ciag.Multiline = true;
            sc_58029_Ciag.Text = "DBCDDCBBBCDBADBADACBCABACBACDCBCACDACADDBAAADBDCBDDDABACBCCAAACBCDBCBDADDBBBBCCBDDDBBAADDCDCCDADBDCDCCACADCDCAADDCDBAAABBACCDBDABBDCDBCCBCADDDDACCCCCBCBADDCDDCDBBCDCCBDCDBDABDBBDAABBAACACABDACAAADACAABDBCAABADCCADDBCACACBAACA";
            sc_58029_Ciag.Leave += new EventHandler(SC_58029_StringEmpty);

            Button sc_58029_Komp = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Komp", 185, 170, 95, 25, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Kompresja");
            sc_58029_Komp.Click += new EventHandler(sc_58029_Kompresja_Click);
            sc_58029_Komp.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Komp.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Komp);


          
        }

        private void SC_58029_StringEmpty(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            TextBox SC_58029_Ciag = (TextBox)this.Controls.Find("SC_58029_Ciag", true)[0];
            if (String.IsNullOrEmpty(SC_58029_Ciag.Text))
            {
                SC_58029_Ciag.Text = "DBCDDCBBBCDBADBADACBCABACBACDCBCACDACADDBAAADBDCBDDDABACBCCAAACBCDBCBDADDBBBBCCBDDDBBAADDCDCCDADBDCDCCACADCDCAADDCDBAAABBACCDBDABBDCDBCCBCADDDDACCCCCBCBADDCDDCDBBCDCCBDCDBDABDBBDAABBAACACABDACAAADACAABDBCAABADCCADDBCACACBAACA";
            }
        }

        private void sc_58029_Kompresja_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

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
            Label sc_58029_Kod = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_Kod", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 430, "");
            SC_58029_Gb001.Controls.Add(sc_58029_Kod);
            

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 200;
            TextBox sc_58029_Dekom = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_Dekom", sc_58029_Location, 470, 115, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            SC_58029_Gb002.Controls.Add(sc_58029_Dekom);
            sc_58029_Dekom.Multiline = true;
            sc_58029_Dekom.ReadOnly = true;

            Button sc_58029_Reset = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Reset", 190, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Reset");
            sc_58029_Reset.Click += new EventHandler(sc_58029_KompLZW_Click);
            sc_58029_Reset.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Reset.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Reset);

            List<int> sc_58029_Kompresja = SC_58029_LZW.SC_58029_Kompresja(SC_58029_Ciag.Text);
            sc_58029_Kod.Text = ("Tak wygląda postać kodowa wpisanego ciągu znaków: \n"+ string.Join(", ", sc_58029_Kompresja)+ ", EOF");
            string sc_58029_Dekompresja = SC_58029_LZW.SC_58029_Dekompresja(sc_58029_Kompresja);
            sc_58029_Dekom.Text =(sc_58029_Dekompresja);
        }
        #endregion
        #region Równanie kwadratowe

        private void SC_58029_RowKwad_Click(object sender, EventArgs e)
        {
            sc_58029_UstawOkno();

            GroupBox SC_58029_Gb002 = (GroupBox)this.Controls.Find("SC_58029_GbParameters", true)[0];

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
            sc_58029_A.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            sc_58029_A.Leave += new EventHandler(SC_58029_ValueProtector);
            sc_58029_A.Text = "1";
            SC_58029_Gb002.Controls.Add(sc_58029_A);

            sc_58029_Location.X = 80;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneB = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneB", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "B:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneB);

            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_B = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_B", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_B.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            sc_58029_B.Leave += new EventHandler(SC_58029_ValueProtector);
            sc_58029_B.Text = "2";
            SC_58029_Gb002.Controls.Add(sc_58029_B);

            sc_58029_Location.X = 155;
            sc_58029_Location.Y = 80;
            Label sc_58029_DaneC = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_DaneC", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 25, 25, "C:");
            SC_58029_Gb002.Controls.Add(sc_58029_DaneC);
            
            sc_58029_Location.X = sc_58029_Location.X + 25;
            sc_58029_Location.Y = sc_58029_Location.Y - 5;
            TextBox sc_58029_C = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_C", sc_58029_Location, 50, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_C.KeyPress += new KeyPressEventHandler(SC_58029_KeyProtector);
            sc_58029_C.Leave += new EventHandler(SC_58029_ValueProtector);
            sc_58029_C.Text = "-3";
            SC_58029_Gb002.Controls.Add(sc_58029_C);

            Button sc_58029_Oblicz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Oblicz", 240, 75, 65, 25, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Oblicz");
            sc_58029_Oblicz.Click += new EventHandler(sc_58029_Oblicz_Click);
            sc_58029_Oblicz.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Oblicz.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Oblicz);

            Button sc_58029_Wymaz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Wymaz", 190, 390, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "Czyść");
            sc_58029_Wymaz.Click += new EventHandler(sc_58029_Wymaz_Click);
            sc_58029_Wymaz.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Wymaz.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Wymaz);

            sc_58029_Location.X = 5;
            sc_58029_Location.Y = 150;
            Label sc_58029_Wynik = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_WynikLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 440, 100, "");
            SC_58029_Gb002.Controls.Add(sc_58029_Wynik);

            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(505, 5, 450, 450, "", "SC_58029_GbWykres", sc_58029_BackColorW );
            sc_58029_Form.Controls.Add(SC_58029_Gb001);
   
        }

        private void SC_58029_ValueProtector(object sender, EventArgs e)
        {

            double? sc_58029_A =null, sc_58029_B, sc_58029_C;
            Control sc_58029_FindA = this.Controls.Find("SC_58029_A", true)[0];
            Control sc_58029_FindB = this.Controls.Find("SC_58029_B", true)[0];
            Control sc_58029_FindC = this.Controls.Find("SC_58029_C", true)[0];         
            try
            {   
                sc_58029_A = Int32.Parse(sc_58029_FindA.Text);

            }
            catch (Exception)
            {
                sc_58029_Timer.Interval = 2000;
                sc_58029_Timer.Enabled = true;
                MessageBox.Show("Wprowadz poprawne wartość dla parametru A.");
                sc_58029_FindA.Text = "1";
            }
            if(sc_58029_A == 0)
            {
                MessageBox.Show("W równaniu kwadratowym A nie może wynosić 0.");
                sc_58029_FindA.Text = "1";
            }

            try
            {
                sc_58029_B = Int32.Parse(sc_58029_FindB.Text);             
            }
            catch (Exception)
            {
                sc_58029_Timer.Interval = 2000;
                sc_58029_Timer.Enabled = true;
                MessageBox.Show("Wprowadz poprawne wartość dla parametru B.");
                sc_58029_FindB.Text = "2";
            }

            try
            { 
                sc_58029_C = Int32.Parse(sc_58029_FindC.Text);            
            }
            catch (Exception)
            {
                sc_58029_Timer.Interval = 2000;
                sc_58029_Timer.Enabled = true;
                MessageBox.Show("Wprowadz poprawne wartość dla parametru B.");
                sc_58029_FindC.Text = "-3";
            }
        }

        private void SC_58029_KeyProtector(object sc_58029_Sender, KeyPressEventArgs sc_58029_E)
        {
            if (!char.IsControl(sc_58029_E.KeyChar) && !char.IsDigit(sc_58029_E.KeyChar) &&
         (sc_58029_E.KeyChar != '-'))
            {
                sc_58029_E.Handled = true;
            }
            
        }

        private void sc_58029_Oblicz_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            double sc_58029_A, sc_58029_B, sc_58029_C, sc_58029_D, sc_58029_X1, sc_58029_X2, sc_58029_X, sc_58029_Y;
            
            Label sc_58029_FindWynik = (Label)this.Controls.Find("SC_58029_WynikLabel", true)[0];
            GroupBox sc_58029_FindWykres = (GroupBox)this.Controls.Find("SC_58029_GbWykres", true)[0];

                Control sc_58029_FindA = this.Controls.Find("SC_58029_A", true)[0];
                Control sc_58029_FindB = this.Controls.Find("SC_58029_B", true)[0];
                Control sc_58029_FindC = this.Controls.Find("SC_58029_C", true)[0];
               
                sc_58029_B = Int32.Parse(sc_58029_FindB.Text);
                sc_58029_C = Int32.Parse(sc_58029_FindC.Text);
                sc_58029_A = Int32.Parse(sc_58029_FindA.Text);

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
                    "Delta wynosi pierwiastek z: " + sc_58029_D + " = " + Math.Sqrt((double)sc_58029_D) + ", oraz posiada dwa rozwiązania (x1 = " + sc_58029_X1 + "), (x2 = " + sc_58029_X2 + ").";
                }
            }


            Bitmap sc_58029_P = new Bitmap(1, 1);
            sc_58029_P.SetPixel(0, 0, Color.White);
            Graphics sc_58029_G = sc_58029_FindWykres.CreateGraphics();
            int sc_58029_CenX = sc_58029_FindWykres.Width / 2;
            int sc_58029_CenY = sc_58029_FindWykres.Height / 2;
            for (double i = 0; i <= 600; i += 0.002)
            {
                sc_58029_X = i;
                sc_58029_Y = (sc_58029_A * (sc_58029_X * sc_58029_X)) + ((sc_58029_B * sc_58029_X) + sc_58029_C);
                sc_58029_G.DrawImageUnscaled(sc_58029_P, sc_58029_CenX + (int)sc_58029_X, sc_58029_CenY - (int)sc_58029_Y);
                sc_58029_G.DrawImageUnscaled(sc_58029_P, sc_58029_CenX - (int)sc_58029_X, sc_58029_CenY - (int)sc_58029_Y);
                if (sc_58029_Y >= sc_58029_CenY)
                    break; 
            }
            sc_58029_G.Dispose();

           
        }

        private void sc_58029_Wymaz_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            SC_58029_RowKwad_Click(sc_58029_Sender, sc_58029_E);
        }
        #endregion
        #region układ wygląd
        void sc_58029_UstawOkno()
        {
            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();
            sc_58029_Form = this;
            this.Width = (int)(980);
            this.Height = (int)(500);
       

            GroupBox SC_58029_Gb002 = sc_58029_Ctrl.SC_58029_Create_GroupBox(10, 5, 485, 450, "", "SC_58029_GbParameters", sc_58029_BackColor);
            sc_58029_Form.Controls.Add(SC_58029_Gb002);

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
        private void sc_58029_Wstecz_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();

            SC_58029_LoadControlls();

        }
        private void sc_58029_Exit_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            Application.Exit();
        }
        #endregion

        private void sc_58029_Timer_Tick(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            sc_58029_Timer.Enabled = false;
            SendKeys.Send("{ESC}");
        }
    }
}
