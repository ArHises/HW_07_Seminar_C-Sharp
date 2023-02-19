// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
    for (int i = 0; i < table.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < table.GetLength(0); j++)
        {
            sum += table[j,i];
        }
        Console.WriteLine($"Average of colon {i + 1} = " + sum / table.GetLength(1));
    }
}
int[,] table = CreateIntTable();
FillTable(table);
PrintTable(table);
AverageOfColon(table);