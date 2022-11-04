Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") //.ToLower() == "маша"-- тогда все будет верно работать
{
    Console.WriteLine("Ура это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
