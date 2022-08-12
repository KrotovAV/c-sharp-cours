// Задача 3: Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

// Fibanachi
// f(0) = 0;
// f(1) = 1
// F(2) == 1
// F(n) = f(n-1) + f(n-2)


void PrintArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

int[] FiboArray(int a)
{
        int[] arr = new int[a];
        arr[0]=0;
        //Console.Write($"{arr[0]} ");
        arr[1]=1;
        //Console.Write($"{arr[1]} ");
        
    for (int i = 2; i < a; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
        //Console.Write($"{arr[i]} ");
    }
    return arr;
}

Console.WriteLine();
Console.WriteLine("Write namber for Fibanachi:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("------------");

FiboArray(a);
int[] arr = FiboArray(a);

Console.Write("Fifonachi nambers: ");
PrintArray(arr);

//Console.WriteLine("----------------");

Console.WriteLine();