// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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


void SortingRowsNumbers(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
        for(int j=0; j<matrix.GetLength(1); j++)
            for(int k=j+1; k<matrix.GetLength(1); k++)
        {
            int temporary = 0;
            if(matrix[i,j] < matrix[i,k]) 
            {
                temporary = matrix[i,j];
                matrix[i,j] = matrix[i,k];
                matrix[i,k] = temporary;
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
PrintMatrix(matrix);
Console.WriteLine();
SortingRowsNumbers(matrix);
PrintMatrix(matrix);