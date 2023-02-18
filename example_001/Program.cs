using System;

namespace Serpinski 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Power of 2: ");
            int depth = Convert.ToInt32(Math.Pow(2d, Convert.ToDouble(Console.ReadLine())));

            int[][] pascaltriangle = new int[depth][];
            for (int i = 0; i < pascaltriangle.Length; i++)
            {
                pascaltriangle[i] = new int[depth];
                for (int j = 0; j < pascaltriangle[i].Length; j++)
                    pascaltriangle[i][j] = 0;
                pascaltriangle[i][0] = 1;
                pascaltriangle[i][i] = 1;
            }

            for (int i = 1; i < pascaltriangle.Length; i++)
                for (int j = 1; j < pascaltriangle[i].Length; j++)
                    pascaltriangle[i][j] = (pascaltriangle[i - 1][j - 1] + pascaltriangle[i - 1][j]) % 2;

            for (int i = 0; i < pascaltriangle.Length; i++)
            {
                for (int j = 0; j < pascaltriangle[i].Length; j++)
                    Console.Write(pascaltriangle[i][j] == 1 ? "#" : " ");
                Console.WriteLine();
            }
            
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}