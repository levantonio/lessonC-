// ИГДЕКСАЦИЯ  0  1   2   3   4   5   6   7
int[] array = {1, 25, 36, 47, 58, 69, 85, 258, 47};

int n = array.Length; //количество элементов в массиве array))
int find = 47;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //если несколько одинаковых значений- укажет первое!!!! и остановит цикл
    }
    index += 1;                     

}
