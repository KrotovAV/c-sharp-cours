// Задача 1: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.

Console.WriteLine("");

Console.WriteLine("Write naturele namber");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

Console.WriteLine("Write power namber");
string s_p = Console.ReadLine();
int p = int.Parse(s_p);

Console.WriteLine("-------");

int PowerMethod (int a, int p)
{
    int res = a;
    for (int i = 0; i < p - 1; i++)
    {
        res = res * a;
    }
    return res;
}

Console.WriteLine($"Rowered namber: {PowerMethod(a, p)}");

Console.WriteLine("");
