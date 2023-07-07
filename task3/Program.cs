// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int rows = ReadInt("Введите колличество строк: ");
int cols = ReadInt("Введите колличество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
int[] array = new int[cols];
PrintMatrix(matrix);
System.Console.WriteLine();
PrintArray(array);
//------------------------------
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
void PrintArray(int[] arraycols)
{
    for (int i = 0; i < arraycols.Length; i++)
    {
        for(int j=0; j<arraycols.Length; j++)
        {
            arraycols[i] = (matrix[j, i] + arraycols[i]);
        
        }
        double numbersA = Convert.ToDouble(arraycols[i]);
        numbersA=numbersA/cols;
        System.Console.Write(numbersA + " ");
    }
}
