//Задача 3: Напишите программу, которая выводит
//массив из 8 элементов, заполненный нулями и
//единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

void Array(int nam)
{
    int[] array = new int[nam];
    for (int i = 0; i < nam; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]}  ");
    }
}

Array(8);

