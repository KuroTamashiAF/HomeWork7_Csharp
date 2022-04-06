// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
//(в случае, если матрица не квадратная).
void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = rand.Next(0, 10);

}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void ReplaceStringsAndColumns(int[,] matr, int NumberString, int NumberColumn)
{
    int[,] Rematr = new int[NumberString, NumberColumn];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Rematr[i, j] = matr[j, i];
        }
    }
    Console.WriteLine();
    for (int i = 0; i < Rematr.GetLength(0); i++)
    {
        for (int j = 0; j < Rematr.GetLength(1); j++)
        {
            Console.Write($"{Rematr[i, j]}  ");
        }
        Console.WriteLine();
    }
}


Console.Write("Enter the number of strings: ");
int NumberStrings = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int NumberColumns = Convert.ToInt32(Console.ReadLine());
if (NumberStrings != NumberColumns)
{
    Console.Write("Replace strings on columns Animposible");
}
else
{
    int[,] matrix = new int[NumberStrings, NumberColumns];
    FillArray(matrix);
    PrintArray(matrix);
    ReplaceStringsAndColumns(matrix, NumberStrings, NumberColumns);
}
