//Задача 3: Напишите программу, которая задаёт массив из
//8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции
//(пригодится в следующих задачах)

Console.WriteLine();
Console.WriteLine("Write array size");
string s_n = Console.ReadLine();
int n = int.Parse(s_n);

Console.WriteLine("----------------");
Console.Write("Array : ");

void DialArray(int[] n)
{
    int lenght = n.Length;
    for (int i = 0; i < lenght; i++)
    {
        n[i] = new Random().Next(1,1000);
    }
}

void PrintArray(int[] n)
{
    int lenght = n.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{n[i]}, ");
    }
}

int[] arr = new int[n];

DialArray(arr);
PrintArray(arr);

Console.WriteLine();
Console.WriteLine();

//PrintArray(arr);