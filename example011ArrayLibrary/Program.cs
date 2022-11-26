void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {   collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[]  col)
{
    int counte = col.Length;
    int position = 0;
    while (position < counte)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
    
}
int[] array = new int[10];
