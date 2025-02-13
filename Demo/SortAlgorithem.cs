using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    delegate TResult Sort_Compare<T1,T2,TResult>(T1 x, T2 y);
    internal class SortAlgorithem<T>
    {
        public static void BubbelSort(T[] num, Sort_Compare<T,T,bool> fun)
        {
            if (num is null) return;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (fun.Invoke(num[j], num[j + 1]))
                        Swap(ref num[j], ref num[j + 1]);
                }
            }
        }

        private static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
        class So0rt_Comparer
        { 
            public static bool les(int x,int y)  => x < y; 
            public static bool gre(int x,int y) => x > y; 
        }

    
}
