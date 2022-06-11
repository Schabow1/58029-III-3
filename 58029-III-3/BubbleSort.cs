using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58029_III_3
{
    class BubbleSort
    {
        public static void Sort( ref int[] sc_58029_Tablica )
        {
         
           
            int n = sc_58029_Tablica.Length;
            do
            {
               
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
        }
    }
}
