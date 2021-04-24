using System;


namespace Exceptions_lab
{
    class Program
    {
        static void Main()
        {
            Run();

            Console.ReadKey();
        }

        public static void Run()
        {
            Console.Write("[Введите кол-во строк 1 матрицы: ]");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("[Введите кол-во столбцов 1 матрицы:]");
            int m = Convert.ToInt32(Console.ReadLine());

            Matrix matrix1 = new Matrix(n, m);
            Write(matrix1);

            Console.Write("[Введите кол-во строк 2 матрицы:]");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("[Введите кол-во столбцов 2 матрицы:]");
            m = Convert.ToInt32(Console.ReadLine());

            Matrix matrix2 = new Matrix(n, m);
            Write(matrix2);

            Console.WriteLine("[1 матрица:]");
            Print(matrix1);
            Console.WriteLine("[2матрица:]");
            Print(matrix2);

            try
            {
                Console.WriteLine("[Результат сложения матриц]: ");
                Print(Matrix.Plus(matrix1, matrix2));
            }
            catch (MatrixEx e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("[Результат вычитания матриц]: ");
                Print(Matrix.Minus(matrix1, matrix2));
            }
            catch (MatrixEx e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("[Результат умножения матриц]: ");
                Print(Matrix.Multiplication(matrix1, matrix2));
            }
            catch (MulMEx e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Кол-во строк нулевой матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кол-во столбцов нулевой матрицы: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"[Нулевая матрица]: ");
            Print(Matrix.GetEmpty(n, m));
        }

        static void Print(Matrix m)
        {
            for (int i = 0; i < m.RC; i++)
            {
                for (int j = 0; j < m.CC; j++)
                {
                    Console.Write($"[{m.Arr_Matrix[i, j]}]");
                }
                Console.WriteLine();
            }
        }

        static void Write(Matrix m)
        {
            Console.WriteLine("Заполните матрицу: ");
            for (int i = 0; i < m.RC; i++)
            {
                for (int j = 0; j < m.CC; j++)
                {
                    Console.Write($"M[{i + 1},{j + 1}] = ");
                    m.Arr_Matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.Clear();
        }
    }
}
