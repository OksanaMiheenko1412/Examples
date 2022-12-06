// example014 - программа упорядочивания данных массива - алгоритм сортировки методом
// выбора или алгоритм сортировки методом макса("танец с номерами" - от 1 до 8)

int[]arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)// метод вывода элементов массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr); 

void SelectionSort(int[] array) // метод сортировки(упорядочивания) элементов массива
{ 
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) 
            {
                minPosition = j;
            }    
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);