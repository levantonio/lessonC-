﻿
// вид1 ничего не принимают и ничего не ворачивают---------------------------------------


//void Method1()
{
    //console.WriteLine("Автор...");//например в конце программы указать автора
}
//Method1();//вызывание метода-- скобки обязательны!!!



//вид2 принимают аргументы но ничего не ворачивают------------------------------------------------------------------------------------


//void Method2(String msg)// в скобках аргументы msg = message
{
    //console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");// присвоили аргументу msg параметр- текст сообщения msg = message

//void Method21(String msg, int count)// в скобках аргументы
//{
   // int i = 0;
   // while (i < count)
    //{
      //  console.WriteLine(msg); //msg = message
        //count++;
    //}
    
//}
//Method21(count: 4, msg: "Текст сообщения");//параметры msg присвоили "текст сообщения". а count(итерацию)- 4раза



//вид 3-ворачивают но не принимают аргументы----------------------------------------------------------------------------------------------

//int Method3() //обязательно укащать тип возвпащаемых данных - string, int, doble...
//{
    //return DateTime.Now.Year; // ворачиваем значение текущего года 
//}
//int year = Method3(); // присваеваем значение метода3 - а точнее текыщий год в переменную year
//console.WriteLine(year); // выводим значение результата работы метода

//вид4 метод, который и принимает аргумент и что то ворачивает---------------------------------------------------------------------

string Method4(int count, string Text) //char - символ!!!! будем text друг за дружкой компоновать count раз
{
    int i = 0;
    string result = String.Empty; //либо ""- пустая строка

    while (i < count)
    {
        result = result + Text;
        i++;
    }
    return result;
}

string res = Method4(100, "asdf"); //положили в res результад работы 4 метода asdf выведется 10 раз
Console.WriteLine(res);