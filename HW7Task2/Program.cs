// Найти произведение двух матриц

void FillMatrix(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] ProductOfMatrices(int[,] matrA, int[,] matrB)
{
    int[,] C = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                C[i, j] += matrA[i, k] * matrB[k, j];
                                                                   // по этапный разбор циклов для себя
                    //i = 0, j<(количества столбцов матрицы B(4)), k<(количества строк матрицы B(3))

                    //с[0,0]=  0 + matrA[0, 0] * matrB[0, 0] = 0 + 0 * 7 +  
                    //       + 0 + matrA[0, 1] * matrB[1, 0] = 0 + 1 * 5 + 
                    //       + 5 + matrA[0, 2] * matrB[2, 0] = 5 + 1 * 5  = 10

                    //c[0,1] = 0 + matrA[0, 0] * matrB[0, 1] = 0 + 0 * 0 +
                    //       + 0 + matrA[0, 1] * matrB[1, 1] = 0 + 1 * 1 +
                    //       + 1 + matrA[0, 2] * matrB[2, 1] = 1 + 1 * 7 = 8

                    //c[0,2] = 0 + matrA[0, 0] * matrB[0, 2] = 0 + 0 * 0 = 
                    //       + 0 + matrA[0, 1] * matrB[1, 2] = 0 + 1 * 9 = 
                    //       + 9 + matrA[0, 2] * matrB[2, 2] = 9 + 1 * 1 = 10

                    //c[0,3] = 0 + matrA[0, 0] * matrB[0, 3] = 0 + 0 * 9 = 
                    //       + 0 + matrA[0, 1] * matrB[1, 3] = 0 + 1 * 4 = 
                    //       + 4 + matrA[0, 2] * matrB[2, 3] = 4 + 1 * 4 = 8

                    //i = 1, j<(количества столбцов матрицы B(4)), k<(количества строк матрицы B(3))
                    //C[i, j] += matrA[i, k] * matrB[k, j];

                    //c[1,0] = 0 + matrA[1, 0] * matrB[0, 0] = 0 + 0 * 7 + 
                    //       + 0 + matrA[1, 1] * matrB[1, 0] = 0 + 6 * 5 + 
                    //      + 30 + matrA[1, 2] * matrB[2, 0] =30 + 9 * 5 = 75
                    
            }
        }
    }
    return C;
}
Console.Write("Enter number Rows matrices A and number Columns matrices A ");
int RowsA = Convert.ToInt32(Console.ReadLine());
int ColumnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number Rows matrices B and number Columns matrices B ");
int RowsB = Convert.ToInt32(Console.ReadLine());
int ColumnsB = Convert.ToInt32(Console.ReadLine());
if (ColumnsA == RowsB)
{
    int[,] A = new int[RowsA, ColumnsA];
    int[,] B = new int[RowsB, ColumnsB];
    FillMatrix(A);
    FillMatrix(B);
    Console.Write("Matrix A is \n");
    PrintMatrix(A);
    Console.WriteLine();
    Console.Write("Matrix B is \n");
    PrintMatrix(B);
    int[,] FinalC = ProductOfMatrices(A, B);
    Console.WriteLine();
    Console.Write("Matrix C = Matrix A * Matrix B \n");
    PrintMatrix(FinalC);
}
else
{
    Console.Write("Matrix data cannot be multiplied because the number");
    Console.Write(" of columns of matrix A is not equal to the number of rows of matrix B");
}