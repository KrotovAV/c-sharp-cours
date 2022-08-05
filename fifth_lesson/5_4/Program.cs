// Задача 4: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


int[] DialArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

int[] ProdPanNum(int[] arr)
{
    int length = arr.Length;
    int newLength = length/2+length%2;
    int[] newArr = new int[newLength];

    for (int i = 0; i < length/2; i++)
        {
            newArr[i]=arr[i]*arr[length-i-1];
        }
    if(arr.Length%2>0)
        {
            newArr[newLength-1]=arr[(length-1)/2];
        }
return newArr;
}

Console.WriteLine();
Console.WriteLine("Write array size");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Write namber from");
int f = int.Parse(Console.ReadLine());

Console.WriteLine("Write namber to");
int t = int.Parse(Console.ReadLine());


Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
int[] newarr = ProdPanNum(arr);
Console.Write("New array : ");

PrintArray(newarr);
Console.WriteLine();




