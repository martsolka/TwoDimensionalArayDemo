using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_example
{
    class Matrix2D
    {
        int[,] matrix;

        public Matrix2D(int rows, int cols)
        {
            matrix = new int[rows, cols];
            RowCount = matrix.GetLength(0);
            ColCount = matrix.GetLength(1);
        }
        public int RowCount { get; set; }
        public int ColCount { get; set; }
        public int this[int i, int j]
        {
            get
            {
                if (i < RowCount && i >= 0 && j < ColCount && j >= 0)
                    return matrix[i, j];
                else throw new IndexOutOfRangeException("Індекс виходить за межі масиву!");
            }
        }
        public void FillElementsRandom(int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < RowCount; i++)
                for (int j = 0; j < ColCount; j++)
                    matrix[i, j] = rand.Next(min, max + 1);
        }
    }
}