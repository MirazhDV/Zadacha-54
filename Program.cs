// Задача 54: Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] Sortirovka(int[,] matrix)
{
    int count = 0;
    int temporary = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int countSort = 0;
        while (countSort < matrix.GetLength(1))
        {
            int max = -1;
            for (int j = countSort; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    count = j;
                }
            }
            temporary = matrix[i, count];
            matrix[i, count] = matrix[i, countSort];
            matrix[i, countSort] = temporary;
            countSort++;
        }
    }
    return matrix;
}

int line = 5;
int column = 5;

int[,] matrix = InitMatrix(line, column);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newMatrix = Sortirovka(matrix);
PrintMatrix(newMatrix);