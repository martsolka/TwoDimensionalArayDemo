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
        int[] absolutRowsSum;

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

        //Шукає перший стовпець, що не містять відємних елементів
        //повертає індекс стовпця або -1, якщо такого стовпця не знайдено
        public int IndexOfFirstPositiveColumn()
        {
            for (int i = 0; i < ColCount; i++)
            {
                int positiveElementsCount = 0;
                for (int j = 0; j < RowCount; j++)
                {
                    if (matrix[j, i] >= 0)
                        positiveElementsCount++;
                    else
                        break;
                }
                if (positiveElementsCount == RowCount)
                    return i;
            }
            return -1;
        }
        // Сортування рядків матриці за зростанням
        // суми абсолютних значень елементів рядків
        public void SortRowsByCharacteristic()
        {
            if (absolutRowsSum == null)
                СomputeAbsolutRowsSum();
            for (int i = 0; i < RowCount; i++)
                for (int j = i + 1; j < RowCount; j++)
                    if (absolutRowsSum[i] > absolutRowsSum[j])
                    {

                        for (int k = 0; k < ColCount; k++)
                            Swap(ref matrix[i, k], ref matrix[j, k]);
                        Swap(ref absolutRowsSum[i], ref absolutRowsSum[j]);
                    }
        }
        // Обчислення абсолютної суми елементів кожного рядка
        // повертає одновимірний масив зі значенням суми у кожному рядку
        public void СomputeAbsolutRowsSum()
        {
            absolutRowsSum = new int[RowCount];
            for (int i = 0; i < RowCount; i++)
                for (int j = 0; j < ColCount; j++)
                    absolutRowsSum[i] += Math.Abs(matrix[i, j]);
        }
        // Міняє місцями значення двох змінних
        private void Swap(ref int firstElement, ref int secondElement)
        {
            int tempElement = firstElement;
            firstElement = secondElement;
            secondElement = tempElement;
        }
    }
}