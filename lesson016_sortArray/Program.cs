

// найти позицию min элемента в неотсортированной части массива
// произвести обмен этого значения со значением первой неотсортированной позиции
// повторять пока есть неосортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{

    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++) // -1 потоиу что ниже в цикле for + 1 
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)// этот блок кода только ищет минимальный элемент 
        {
            if(array[j] < array[minPosition]) 
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