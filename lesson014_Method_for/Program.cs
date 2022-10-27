string Method4(int count, string Text) //char - символ!!!! будем text друг за дружкой компоновать count раз
{
    
    string result = String.Empty; //либо ""- пустая строка
    for( int i = 0; i < count; i++ )//инициализация счетчика

    {
        result = result + Text;
    
    }
    return result;
}

string res = Method4(100, "asdf"); //положили в res результад работы 4 метода asdf выведется 10 раз
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)// таблица умножения
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine(); // разрыв пустой строкой
}