// Написать программу, которая обменивает элементы первой строки и последней строки
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(minValue,maxValue);
    return matrix;
}


void ChangeFirstAndLast(int[,] matrix)
{
    int start = 0;
    int finish = matrix.GetLength(0)-1;
    int index = 0;
    int[] temporary1 = new int[matrix.GetLength(1)];
    int[] temporary2 = new int[matrix.GetLength(1)];
    while(index<matrix.GetLength(1))
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            {
                temporary1[index] = matrix[finish,j];
                temporary2[index]=matrix[start,j];
                matrix[start,j]=temporary1[index];
                matrix[finish,j]=temporary2[index];
                index++;
            }
    }
}

Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix columns: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix columns: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,start,finish);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
Console.WriteLine();
ChangeFirstAndLast(matrix);
PrintMatrix(matrix);
