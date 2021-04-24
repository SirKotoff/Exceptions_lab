using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_lab
{
    class Matrix
    {
        public double[,] Arr_Matrix;  // матрица
        public int RC { get; private set; } //кол-во рядов
        public int CC { get; private set; } //кол-во колонок




        public Matrix(int RowsCount, int ColumnsCount)
        {
            Arr_Matrix = new double[RowsCount, ColumnsCount];
            this.RC = RowsCount;
            this.CC = ColumnsCount;
        }




      //метод для сложения матриц
        public static Matrix Plus(Matrix A, Matrix B)
        {
            if (A.RC != B.RC || A.CC != B.CC)
            {
                throw new MatrixEx($"Ошибка\nРазмерность первой матрицы {A.RC}x{A.CC}, " +
                    $"Размерность второй матрицы {B.RC}x{B.CC}");
            }

            Matrix MatrixC = new Matrix(A.RC, A.CC);

            for (int i = 0; i < MatrixC.RC; i++)
            {
                for (int j = 0; j < MatrixC.CC; j++)
                {
                    MatrixC.Arr_Matrix[i, j] = A.Arr_Matrix[i, j] + B.Arr_Matrix[i, j];
                }
            }
            return MatrixC;
        }



        //метод для вычитания матриц
        public static Matrix Minus(Matrix A, Matrix B)
        {
            if (A.RC != B.RC || A.CC != B.CC)
            {
                throw new MatrixEx($"Ошибка\nРазмерность первой матрицы {A.RC}x{A.CC}, " +
                    $"Размерность второй матрицы {B.RC}x{B.CC}");
            }

            Matrix MatrixC = new Matrix(A.RC, A.CC);

            for (int i = 0; i < MatrixC.RC; i++)
            {
                for (int j = 0; j < MatrixC.CC; j++)
                {
                    MatrixC.Arr_Matrix[i, j] = A.Arr_Matrix[i, j] - B.Arr_Matrix[i, j];
                }
            }
            return MatrixC;
        }




        
        //метод для умножения матриц
        public static Matrix Multiplication(Matrix A, Matrix B)
        {
            if (A.CC != B.RC)
            {
                throw new MulMEx($"Ошибка\nРазмерность первой матрицы {A.RC}x{A.CC}, " +
                    $"Размерность второй матрицы {B.RC}x{B.CC}");
            }

            Matrix MatrixC = new Matrix(A.RC, B.CC);

            for (int i = 0; i < A.RC; i++)
            {
                for (int j = 0; j < B.CC; j++)
                {
                    for (int k = 0; k < A.CC; k++)
                    {
                        MatrixC.Arr_Matrix[i, j] += A.Arr_Matrix[i, k] * B.Arr_Matrix[k, j];
                    }
                }
            }
            return MatrixC;
        }




        //метод для получения нулевой матрицы
        public static Matrix GetEmpty(int RowsCount, int ColumnsCount)
        {
            return new Matrix(RowsCount, ColumnsCount);
        }

    }


    //
   

   

}
