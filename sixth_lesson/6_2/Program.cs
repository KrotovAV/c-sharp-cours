// Задача 2: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

int[] DialArray(int a)
{
    int check = 0;
    int c = a;
for (int i = 0; c > 0; i++)
{
    c = c / 2;
    check = check + 1;
}
//Console.WriteLine(check);
    
    int[] arr = new int[check];
    for (int i = 0; i < check; i++)
    {
        int b = a % 2;
        arr[i] = b;
        a = a / 2;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

int[] ReversArray(int[] arr)
{
    int vrem = 0;
    int n = arr.Length-1;
    
    for (int i = 0; i < arr.Length/2; i++)
    {
        vrem = arr[i];
        arr[i] = arr[n - i];
        arr[n-i] = vrem;

        //arr[i] = arr[i] + 1;
    }
    return arr;
}

int ArrToNam(int[] arr)
{
    int a = 1;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        a = a*10;
    }
    
    for (int i = 0; i < arr.Length; i++)
    {
        a = a/10;
        sum = sum + arr[i]*a;
    }
return sum;
}

Console.WriteLine();
Console.WriteLine("Decimal number:");
int a = int.Parse(Console.ReadLine());

DialArray(a);

int[] arr = DialArray(a);

Console.WriteLine("----------------");
int[] newArr = ReversArray(arr);
Console.Write("Binary number : ");
//PrintArray(newArr);
ArrToNam(newArr);

Console.WriteLine(ArrToNam(newArr));
Console.WriteLine();
