Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());
double [] newArray = new double[columns];
int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-100, 100);
        Console.Write(array[i, j] + "\t");
        newArray [j] += Convert.ToDouble(array[i,j])/array.GetLength(0);
    }
    Console.WriteLine();
}
Console.Write(" ");
for (int i = 0; i < array.GetLength(1); i++)
{
    Console.Write(Math.Round(newArray[i],2) + "; ");
}