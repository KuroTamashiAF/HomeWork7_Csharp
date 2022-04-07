// Сформировать трехмерный массив не повторяющимися двузначными числами показать 
//его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[,,] arr)
{
    int k = 10;
    for (int n = 0; n < arr.GetLength(0); n++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                arr[n,i,j]=k;
                k++;

            }
        }
    }
}
void PrintArray(int[,,] arr)
{
    for (int n = 0; n < arr.GetLength(0); n++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                Console.Write($"{'['}{n} ");
                Console.Write($"{i} ");
                Console.Write($"{j}{']'} ");
                Console.Write(arr[n, i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Write("Enter the height of the array: ");
int HeightArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the lenght of the array: ");
int LenghtArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the width of the array: ");
int WidthArray = Convert.ToInt32(Console.ReadLine());
int[,,] ThreeDimensionalArray = new int[WidthArray, HeightArray, LenghtArray];
FillArray(ThreeDimensionalArray);
PrintArray(ThreeDimensionalArray);
//AnalisArray(ThreeDimensionalArray);



