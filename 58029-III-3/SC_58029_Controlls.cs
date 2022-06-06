using System.Drawing;
using System.Windows.Forms;

namespace _58029_III_3
{
    class SC_58029_Controlls
    {

        //Cała kalasa odpowiedzialna jest za tworzenie obiektów Button CheckBox GroupBox Label TextBox do każdego wymagane jest przypisanie stanu początkowego najbardziej porzebnych rzeczy.
        public Button SC_58029_Create_Button(string sc_58029_Name, int sc_58029_X, int sc_58029_Y, int sc_58029_Width, int sc_58029_Height, Font sc_58029_Czcionka, Color sc_58029_ForeColor, Color sc_58029_BackColor, string sc_58029_Text)
        {
            Button sc_58029_Button = new Button
            {
                Name = sc_58029_Name,
                Location = new Point(sc_58029_X, sc_58029_Y),
                Width = sc_58029_Width,
                Height = sc_58029_Height,
                AutoSize = false,
                Font = sc_58029_Czcionka,
                ForeColor = sc_58029_ForeColor,
                BackColor = sc_58029_BackColor,
                Text = sc_58029_Text,
                TextAlign = ContentAlignment.MiddleCenter
            };
            return sc_58029_Button;
        }

        public GroupBox SC_58029_Create_GroupBox (int sc_58029_X,int sc_58029_Y, int sc_58029_Width, int sc_58029_Height, string sc_58029_Text,string sc_58029_Name, Color sc_58029_BackColor)
        {
            GroupBox sc_58029_GroupBox = new GroupBox
            {
                Location = new Point(sc_58029_X, sc_58029_Y),
                Width = sc_58029_Width,
                Height = sc_58029_Height,
                Text = sc_58029_Text,
                Name = sc_58029_Name,
                BackColor = sc_58029_BackColor
            };
            return sc_58029_GroupBox;
        }
        public Label SC_58029_Create_Label(string sc_58029_Name, Point sc_58029_Location, Font sc_58029_Czcionka, Color sc_58029_BackColor, Color sc_58029_ForeColor, int sc_58029_Width, int sc_58029_Height, string sc_58029_Text)
        {
            Label sc_58029_Label = new Label
            {
                Location = sc_58029_Location,
                AutoSize = false,
                Width = sc_58029_Width,
                Height = sc_58029_Height,
                Font = sc_58029_Czcionka,
                BackColor = sc_58029_BackColor,
                ForeColor = sc_58029_ForeColor,
                Name = sc_58029_Name,
                Text = sc_58029_Text
            };
            return sc_58029_Label;
        }
        public TextBox SC_58029_Create_TextBox(string sc_58029_Name, Point sc_58029_Location, int sc_58029_Width, int sc_58029_Height, Font sc_58029_Czcionka, Color sc_58029_BackColor, Color sc_58029_ForeColor)
        {
            TextBox sc_58029_TextBox = new TextBox
            {
                Location = sc_58029_Location,
                Width = sc_58029_Width,
                Height = sc_58029_Height,
                Name = sc_58029_Name,
                Font = sc_58029_Czcionka,
                BackColor = sc_58029_BackColor,
                ForeColor = sc_58029_ForeColor,
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle
            };
            return sc_58029_TextBox;
        }
    }
}
