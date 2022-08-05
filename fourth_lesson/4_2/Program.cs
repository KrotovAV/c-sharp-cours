// Задача 2: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int Factorial(int nam)
{
    int prod = 1;
    for (int i = 1; i <= nam; i++)
        prod = prod * i;
    return prod;
}

Console.WriteLine(Factorial(5));
