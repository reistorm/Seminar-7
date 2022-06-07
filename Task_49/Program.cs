// задайте двумерный массив.Найдите элементы, у которых
// оба индекса четные и замените эти элементы 
// на их квадраты

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
}
int[,] arrayResult = GetArray(rows, cols);
PrintArray(arrayResult);
