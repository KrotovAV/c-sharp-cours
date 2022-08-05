//Задача 2: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


int[] arr = {-4, -8, 8, 2};
int nam = 2;

int[] Exist( int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i] == nam); 
    Console.WriteLine("Namber exist in array");
    break;
    }
    
}

Exist(arr, nam);
//Console.WriteLine(Revers(arr));

Console.WriteLine("Hello, World!");
