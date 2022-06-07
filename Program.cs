// Задайте двумерный массив размера m на n 
// каждый элемент в массиве находится по формуле
// A[m,n] = m+n. Вывести массив на экран
// m = 3 n = 4 
// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col) 
{
    int [,] array = new int[row,col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); i++)
        {
            array[i,j] = i+ j;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); i++)
        {
            Console.WriteLine(array[i,j] + " ");
        }
        Console.WriteLine();

}
int[,] arrayResult = GetArray(rows, cols);
PrintArray(arrayResult);
