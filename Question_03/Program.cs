// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] CreateIntTable()
{
    Console.Write("Lines: ");
    int line = int.Parse(Console.ReadLine()!);

    Console.Write("Colons: ");
    int colon = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[,] table = new int[line, colon];
    return table;
}
int[,] FillTable(int[,] table)
{
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(0, 10);
        }
    }
    return table;
}
void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(" " + table[i, j]);
        }
        Console.WriteLine();
    }
}
void AverageOfColon(int[,] table)
{
    double sum = 0;
    int minIndex = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        sum = sum + table[0,i];
    }
    Console.WriteLine($"Average of Line 1 = " + sum / table.GetLength(1));
    double minSum = sum;
    for (int i = 1; i < table.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum = sum + table[i,j];
        }
        if(sum / table.GetLength(1) < minSum)
        {
            minSum = sum / table.GetLength(1);
            minIndex = i + 1;
        }
            
        Console.WriteLine($"Average of Line {i + 1} = " + sum / table.GetLength(1));
    }
    Console.WriteLine($"Minimal Line is: {minIndex}");
}
int[,] table = CreateIntTable();
FillTable(table);
PrintTable(table);
AverageOfColon(table);