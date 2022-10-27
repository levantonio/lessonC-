
// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо гашего милого Винцегероде,"
            + "вы бы взяли приступом согдасие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"- строка
//             012345 - индекс
// s[3] // r - индекс 3 = r

string Replace(String text, char oldValue, char newValue) //oldValue- символ(char) который будем менять на newValue
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}


string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

