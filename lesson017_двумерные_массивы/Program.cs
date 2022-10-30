// string[,] table = new string[2, 5]; //2 строчки и 5 столбцов [,]- определение двумерного массива
// // String.empty-инициализация происходит такой константой пустая строка 
// // table[0, 0] table[0,1] table[0, 2]...table[0, 4] -max, потоиу что с "0"
// // table[1, 0] table[1, 1] ...table[1, 4]

// table[1, 2] = "слово"; //Обращаемся к массиву table  1 строка 2 столбец

// for (int rows = 0; rows < 2; rows++) //для распечатывания таблицы- нужен цикл
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"|{table[rows, columns]}|"); //table- массив[индекс строки- rows, индекс столбца columns]
//     }
    
// }


 
void PrintArray(int[,] matr) // метод, для заполнения таблицы числами
{
    for (int i = 0; i < matr.GetLength(0); i++) // мщжно вместо 3 написать matr.GetLength(0)- (обращаеися к опреднлению массива)
    {
        for (int j = 0; j < matr.GetLength(1); j++) //matr.GetLength(1) -- равносильно значению 4
        {
            Console.Write($"|{matr[i, j]}|"); //без line- что бы печатало в строчку
        }
    Console.WriteLine(); //принудительно переход на новую строчку после вывода 
    }
}

void FillArray(int[,] matr)// метод, для заполнения табдицы числами

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // интервал от  1...10 случайные числа
        }
    }
}
int[,] matrix = new int [3, 4];//[,]определение двумерного массива

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);