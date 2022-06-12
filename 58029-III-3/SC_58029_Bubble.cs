
namespace _58029_III_3
{
    class SC_58029_Bubble
    {
        public static void SC_58029_Sort( ref int?[] sc_58029_Tablica )
        {
         
           
            int n = sc_58029_Tablica.Length;
            do
            {
               
                for (int i = 0; i < n - 1; i++)
                {
                    if (sc_58029_Tablica[i] > sc_58029_Tablica[i + 1])
                    {
                        int? temp = sc_58029_Tablica[i];
                        sc_58029_Tablica[i] = sc_58029_Tablica[i + 1];
                        sc_58029_Tablica[i + 1] = temp;
                    }
                }
                n--;
            }
            while (n > 1);
        }
    }
}
