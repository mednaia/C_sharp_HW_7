// В прямоугольной матрице найти строку с наименьшей суммой элементов

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

void SearchLessRow(int[,] matrix)
{
    int minI = 0;
    int minSum = 0;
    int tmpSum1 = 10000000;
    for(int i = 0; i < matrix.GetLength(0); i++) 
    {
        int tmpSum2 = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
            tmpSum2 += matrix[i, j];
        if(tmpSum2 < tmpSum1)
        {   
            minSum = tmpSum2; 
            minI = i;
        }
        tmpSum1 = tmpSum2;
    }
    Console.WriteLine($"The least value in row with index {minI} with sum {minSum}.");
}
//Не очень довольна этим кодом. Для первой строки всегда выдает значение суммы 0, 
//хотя определяет строку с минимальной суммой верно.

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
SearchLessRow(matrix);

