// Написать программу, которая в двумерном массиве заменяеь строки на столбцы или сообщает, 
// что это не возможно, если матрица не квадратная
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(minValue,maxValue);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}

int[,] ChangeRowsOnColumns(int[,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for(int i=0; i<matrix.GetLength(0); i++)
        for(int j=0; j<matrix.GetLength(1); j++)
            matrix2[i,j]=matrix[j,i];
    return matrix2;
}


Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
if(rows==0 || columns==0) Console.WriteLine ("Incorrect value of rows or columns.");
else if(rows!=columns) Console.WriteLine ("Changes are impossible. Values of rows and columns are not equal.");
else if(rows==columns)
{
    Console.Write("Enter left side of matrix columns: ");
    int start = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter right side of matrix columns: ");
    int finish = int.Parse(Console.ReadLine() ?? "0");
    int[,] matrix = CreateMatrix(rows,columns,start,finish);
    Console.WriteLine("Your matrix: ");
    PrintMatrix(matrix);
    Console.WriteLine();
    int[,] matrixChanged = ChangeRowsOnColumns(matrix);
    PrintMatrix(matrixChanged);
}