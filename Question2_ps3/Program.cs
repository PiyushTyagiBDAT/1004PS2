using System;

namespace Question2_ps3
{
    class Program
    {
        static void Main(string[] args)
        {
         
                int x = 1, r = 0, j = 0, count = 0;
                int[] d = new int[101];
                for (x = 1; x < 101; x++)
                {
                    int c = 0;
                    for (int i = 0; i < a.length; i++)
                    {
                        if (x % a[i] == 0 && x >= a[i])
                        {
                            c++;
                        }
                    }
                    if (c == a.length)
                    {
                        d[j] = x;
                        r++;
                        j++;
                    }
                }
                for (j = 0; j < r; j++)
                {
                    int c = 0;
                    for (int i = 0; i < b.length; i++)
                    {
                        if (b[i] % d[j] == 0)
                        {
                            c++;
                        }
                    }
                    if (c == b.length)
                    {
                        count++;
                    }
                }
                return count;
            
        }
    }
}
