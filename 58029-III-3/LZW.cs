
using System.Collections.Generic;

using System.Text;


namespace _58029_III_3
{
    class SC_58029_LZW 
    {

        public static List<int> SC_58029_Kompresja(string sc_58029_Zrodlo)
        {

            Dictionary<string, int> sc_58029_Slownik = new Dictionary<string, int>();
            for (int sc_58029_I = 0; sc_58029_I < 256; sc_58029_I++)
                sc_58029_Slownik.Add(((char)sc_58029_I).ToString(), sc_58029_I);

            string sc_58029_Slowo = string.Empty;
            List<int> sc_58029_Skompresowane = new List<int>();

            foreach (char sc_58029_Znak in sc_58029_Zrodlo)
            {
                string sc_58029_Slowo2 = sc_58029_Slowo + sc_58029_Znak;
                if (sc_58029_Slownik.ContainsKey(sc_58029_Slowo2))
                {
                    sc_58029_Slowo = sc_58029_Slowo2;
                }
                else
                {

                    sc_58029_Skompresowane.Add(sc_58029_Slownik[sc_58029_Slowo]);
                    sc_58029_Slownik.Add(sc_58029_Slowo2, sc_58029_Slownik.Count);
                    sc_58029_Slowo = sc_58029_Znak.ToString();
                }
            }


            if (!string.IsNullOrEmpty(sc_58029_Slowo))
                sc_58029_Skompresowane.Add(sc_58029_Slownik[sc_58029_Slowo]);

            return sc_58029_Skompresowane;
        }

        public static string SC_58029_Dekompresja(List<int> sc_58029_Zrodlo)
        {

            Dictionary<int, string> sc_58029_Slownik = new Dictionary<int, string>();
            for (int sc_58029_I = 0; sc_58029_I < 256; sc_58029_I++)
                sc_58029_Slownik.Add(sc_58029_I, ((char)sc_58029_I).ToString());

            string w = sc_58029_Slownik[sc_58029_Zrodlo[0]];
            sc_58029_Zrodlo.RemoveAt(0);
            StringBuilder sc_58029_Dekomp = new StringBuilder(w);

            foreach (int sc58029_Kod in sc_58029_Zrodlo)
            {
                string sc_58029_Wejs = null;
                if (sc_58029_Slownik.ContainsKey(sc58029_Kod))
                    sc_58029_Wejs = sc_58029_Slownik[sc58029_Kod];
                else if (sc58029_Kod == sc_58029_Slownik.Count)
                    sc_58029_Wejs = w + w[0];

                sc_58029_Dekomp.Append(sc_58029_Wejs);


                sc_58029_Slownik.Add(sc_58029_Slownik.Count, w + sc_58029_Wejs[0]);

                w = sc_58029_Wejs;
            }

            return sc_58029_Dekomp.ToString();

        }
    }
}
