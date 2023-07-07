//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int rows = ReadInt("Введите колличество строк: ");
int cols = ReadInt("Введите колличество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 2, 9);
PrintMatrix(matrix);
NumberMatrix(matrix);
// ---------
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}
void PrintMatrix(int[,] matrixPrint)
{
    for (int i = 0; i < matrixPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixPrint[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
void NumberMatrix(int[,] matrixPrint)
{
    Random rand = new Random();
    int x = rand.Next(-10, 1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == x || j == x)
            {
                System.Console.WriteLine(x + " есть в матрице");
            }
            else
            {
                System.Console.WriteLine(x + " нет в матрице");
            }
        }
    }

}