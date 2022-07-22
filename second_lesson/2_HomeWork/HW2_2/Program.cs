// Задача 2: Напишите программу, которая выводит
//случайное трёхзначное число и удаляет вторую цифру
//этого числа.

int a = new Random().Next(99, 1000);

Console.WriteLine(a);

//int b = (a-a %100) / 10 + a %10;
int DigitFT(int a)
{
return (a-a %100) / 10 + a %10;
}


Console.WriteLine (DigitFT(a));
