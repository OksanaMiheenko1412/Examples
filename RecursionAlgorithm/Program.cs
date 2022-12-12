// Алгоритм рекурсии. Индексы меняются от 0

//string[,] table = new string[2, 5];// таблица строк 2 строки, 5 столбцов
//table[1, 2] = "слово"; // для обращения к нужному элементу массива: 
//1 -индекс строки[1,0],[1,2],[1,3],[1,4];2 -индекс столбца [0,1][0,2][0,3][0,4]
// String.Empty - инициализация пустой строки

// двумерный массив с числами

//int[,] matrix = new int[3, 4];

//for (int i = 0; i < 3; i++)//счетчик строк,вместо 3 можно указать matrix.GetLength(0)
//{
 //for (int j = 0; j < 4; j++)//счетчик столбцов,вместо 4 - matrix.GetLength(1)
    //{
      //  Console.Write($"{matrix[i, j]}");
    //}
  //  Console.WriteLine();
//}


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write($"{matr[i, j]} ");
        }
    }    
    Console.WriteLine();
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);// [1,10) полуинтервал
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);