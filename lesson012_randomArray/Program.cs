void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}


void PrintArray(int[] col) // void- метод, который ничего не возвращает( нельзя употреблять return)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // типа такой элемент не найден, иначе будет"0"
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index ++;
    } 
    return position;    
}

int[] array = new int[10]; //new int array - создаёт новый массив из 10 элементов по умолчанию "0"

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos); // ищет позицию числа 4