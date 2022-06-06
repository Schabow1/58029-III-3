
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
            throw new NotImplementedException();
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
            this.Width = (int)(800);
            this.Height = (int)(400);

            Font sc_58029_Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            string SC_58029_Text;

           
            GroupBox SC_58029_Gb002 = sc_58029_Ctrl.SC_58029_Create_GroupBox(10, 5, 385, 350, "Parameters", "SC_58029_GbParameters", sc_58029_BackColor);  
            sc_58029_Form.Controls.Add(SC_58029_Gb002);

            Button sc_58029_Exit = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Exit", 275, 290, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "EXIT");
            sc_58029_Exit.Click += new EventHandler(sc_58029_Exit_Click);
            sc_58029_Exit.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Exit.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Exit);

            Button sc_58029_Wstecz = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Wstecz", 10, 290, 100, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "WSTECZ");
            sc_58029_Wstecz.Click += new EventHandler(sc_58029_Wstecz_Click);
            sc_58029_Wstecz.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Wstecz.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Wstecz);
            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(405, 5, 370, 350, "", "SC_58029_GbWykres", sc_58029_BackColor = Color.Black);
            sc_58029_Form.Controls.Add(SC_58029_Gb001);
        }

        private void sc_58029_Wstecz_Click(object sender, EventArgs e)
        {
            if (sc_58029_Form.Controls.Count > 0)
                sc_58029_Form.Controls.Clear();

            SC_58029_LoadControlls();

        }
    }
}
