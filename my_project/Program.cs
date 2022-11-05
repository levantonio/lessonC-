// написать программу, считающее растояние до следующего км в метрах
Console.Write("Введите пройденное расстояние в метрах: ");
n = Console.ReadLine();
int x = 0;

Int32.TryParse(TextBoxD1.Text, out x);
f = 1000-(n%1000);
Console.WriteLine(f);