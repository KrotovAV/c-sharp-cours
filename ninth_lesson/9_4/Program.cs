//Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8 

Console.WriteLine();
int a = 2;
int b = 3;
int powerNamber = 1;

int PowerNatural(int nam, int pow)
{
if(pow == 0) return powerNamber;
//powerNamber = nam * 2;
powerNamber = nam * PowerNatural(nam, pow-1);
return powerNamber;
}

//PowerNatural(a, b);
Console.WriteLine($"namber {a} powered in {b} degree = {PowerNatural(a, b)}");


Console.WriteLine();
