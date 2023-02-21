// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
int[,] OrderingLowToHigh(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < table.GetLength(1) - j - 1; k++)
            {
                if (table[i, k] > table[i, k + 1])
                {
                    int save = table[i, k];
                    table[i, k] = table[i, k + 1];
                    table[i, k + 1] = save;
                }
            }
        }
    }
    return table;
}

int[,] table = CreateIntTable();
FillTable(table);
PrintTable(table);
Console.WriteLine();

OrderingLowToHigh(table);
PrintTable(table);