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

int IndexOf(int[] collection, int find)
{
    int counte = collection.Length;
    int index = 0;
    int position = 0;
    while (index < counte)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index ++;
    }
        return position;
}

int[] array = new int[10];  

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);