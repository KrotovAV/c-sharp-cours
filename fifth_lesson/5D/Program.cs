int[] arr = {1, 2, 3, 5, 6, 5, 3, 2, 1};

    int length = arr.Length;
    int newLength = length/2+length%2;
    int[] newArr = new int[newLength];
    Console.WriteLine(length/2);
    Console.WriteLine("-------");
    for (int i = 0; i < length/2; i++)
    {
        newArr[i]=arr[i]*arr[length-i-1];
        Console.WriteLine(newArr[i]);
    }
if(arr.Length%2>0)
{
    newArr[newLength-1]=arr[(length-1)/2];
    Console.WriteLine(newArr[newLength-1]);
}

//newArr[newLength-1] = arr[(length-1)/2];
//Console.WriteLine(newArr[newLength-1]);

//Console.WriteLine("Hello, World!");
