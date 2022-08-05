// Демонстрация решения
//Задача 1: Напишите программу, которая принимает
//на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int SumNam(int nam)
{
    int all_sum= 0;
    for(int i = 1; i <= nam;i++)
        all_sum +=i;
    return all_sum;
}

Console.WriteLine(SumNam(4));

Console.WriteLine("Hello, World!");
