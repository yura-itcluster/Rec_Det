using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DETERMINANT
{
    class Program
    {
        static float[,] Method(float[,] ARRAY, int j, int p)
        {
            float[,] array = new float[p - 1, p - 1];
            for (int I = 0; I < p - 1; I++)
            {
                for (int J = 0; J < p - 1; J++)
                    if (J < j) { array[I, J] = ARRAY[I + 1, J]; }
                    else { array[I, J] = ARRAY[I + 1, J + 1]; }
            }
            return array;
        }
        static float DETERMINANT(float[,] V, int N)
        {
            if (N == 1) { return V[0, 0]; }
            float S = 0; int K = 1;
            for (int i = 0; i < N; i++)
            {
                S = S + V[0, i] * DETERMINANT(Method(V, i, N), N - 1) * K;
                K = -K;

            }
            return S;

        }
        static void Main(string[] args)
        {
            float[,] H = new float[3, 3];

            {
                H[0, 0] = 2; H[0, 1] = -1; H[0, 2] = 0; H[1, 0] = 3; H[1, 1] = 1; H[1, 2] = 21;
                H[2, 0] = 5; H[2, 1] = 7; H[2, 2] = 11;
                ;
            }

            float B = DETERMINANT(H, 3);
            Console.WriteLine("Determinant={0}", B);
            Console.ReadKey();
        }
    }
}
