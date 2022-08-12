//Задача 1: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
Console.WriteLine();
Console.WriteLine("Start programm");
Console.WriteLine();
Console.WriteLine("Enter positive or negative numbers.");
Console.WriteLine();
Console.WriteLine("To stop dial - enter an empty line and press ENTER5.");
Console.WriteLine();

string WriteReadLine()
{
    Console.WriteLine("Write namber ");
    string a = (Console.ReadLine());
    return a;
}

void PrintArray(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

double[] DialArray()
{
    int n = 0;
    string c;
    //double[] arr;
    double[] arr = new double[n+1];
    do
    {
        c = WriteReadLine();
        if ( c == string.Empty)
            {
            Console.WriteLine("Stop. OK.");
            Console.WriteLine();
            break;
            }
            else
            {
            double k = Convert.ToDouble(c);
            arr[n] = k;
            }
        n = n +1;
        Array.Resize(ref arr, n+1);
    } while(true);
    Array.Resize(ref arr, n);
    return arr;
}

int FindNeg(double[] arr)
{
    int check = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) check = check +1;
    }
    return check;
}

double[] newArr = DialArray();
Console.Write("Array: ");
PrintArray(newArr);

Console.WriteLine();
int ch = FindNeg(newArr);
Console.Write("Check of negative nambers: ");
Console.WriteLine(ch);

Console.WriteLine();