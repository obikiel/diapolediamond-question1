using System;

namespace task_a
{
    class Program
    {

        private static void SetAllZeroes(ref int[][] matrix)
        {
            bool[] row = new bool[matrix.Length];
            bool[] column = new bool[matrix[0].Length];
            
            //loop through each row
            for (int r=0; r < matrix.Length; r++)
            {
                //loop through each column
                for (int c= 0; c< matrix.Length; c++)
               {
                        if(matrix[r][c] == 0)
                    {
                        row[r] = true;
                        column[c] = true;
                    }
               }
            }
            //loop through again
            //loop through eacg row
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    if (row[r] || column[c])
                    {
                        matrix[r][c] = 0;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            int[][] Matrix = new int[3][]
            {
                new int[] {1,2,3,4,5},
                new int[] {0,7,8,9,0},
                new int[] {0,2,4,6,8}
            };
        
            PrintMatrix(Matrix);
            SetAllZeroes(ref Matrix);
            PrintMatrix(Matrix);

            Console.ReadLine();
        }
        
        private static void PrintMatrix(int[][] matrix);
    }
}
