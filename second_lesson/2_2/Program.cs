int MaxFig(int a)
{
    int c = a % 10;
    int b = (a - c) / 10;

    if (b == c) 
    {
    Console.Write(" First figure ");
    Console.Write(b);
    Console.Write(" = ");
    Console.Write(c);
    Console.WriteLine(" second figure");
    Console.WriteLine(" !!! Please, try again. !!!");
    System.Environment.Exit(0);
    }


    int max = b;
    if (c > b) max = c;
    return max;
}

int a = new Random().Next(10, 99);

Console.WriteLine(" -------------------- ");
Console.Write("Random namber = ");
Console.WriteLine(a);


int max = MaxFig(a);
Console.Write("Highest figure of namber =  ");
Console.WriteLine(max);
Console.WriteLine(" ---------------------- ");