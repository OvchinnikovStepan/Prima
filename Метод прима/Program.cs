using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_прима
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader T = new StreamReader("1.txt");
            int a = Convert.ToInt32(T.ReadLine());
            int[,] A = new int[a, 2];
            A[0, 1] = 1;
            int b = Convert.ToInt32(T.ReadLine());
            int[,] B = new int[b, 4];
            for (int i = 0; i < a; i++) { A[i, 0] = i+1; }
            for (int i = 0; i < b; i++)
            {
                B[i, 0] = Convert.ToInt32(T.ReadLine());
                B[i, 1] = Convert.ToInt32(T.ReadLine());
                B[i, 2] = Convert.ToInt32(T.ReadLine());
                Console.Clear();
            }
            int sum = 0;int x=1000;int n=0;
            for (int h = 0; h < a-1; h++)
            {
                x = 1000;
                for (int i = 0; i < a; i++)
                {
                    if (A[i, 1] == 1)
                    {
                        for (int t = 0; t<b; t++)
                        {
                            if (((A[i, 0] == B[t, 0])||(A[i, 0] == B[t,1])) && ((A[B[t, 0] - 1, 1] + A[B[t, 1] - 1, 1]) != 2))
                            {
                                if ((x > B[t, 2]) && (B[t,3]!=1))
                                {
                                    x = B[t, 2];
                                    n = t;
                                }
                            }
                        }
                    }
                }
                B[n, 3] = 1;
                A[B[n, 0] - 1, 1] = 1;
                A[B[n, 1] -1, 1] = 1;
            }
            for (int i = 0; i < b; i++)
            {
                if (B[i,3]==1) { sum = sum + B[i, 2]; }
            }
            for (int i = 0; i < b; i++)
            {
                if (B[i, 3] == 1)
                {
                    Console.WriteLine("{0}-{1}", B[i, 0], B[i, 1]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
