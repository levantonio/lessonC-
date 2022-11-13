// написать программу, считающее растояние до следующего км в метрах
Console.Write("Введите пройденное расстояние в метрах: ");
int n = Convert.ToInt32(Console.ReadLine());
int f = 1000-(n%1000);
Console.WriteLine(f);