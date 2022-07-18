// Вид 1 -ничего не принимает, ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор сего текста");
}

Method1();

// Вид 2 - ничего не возвращает, но может принимать

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
         Console.WriteLine(msg);
        i++;
    }
    
}

Method21("Текст сообщения21", 3);


// Вид 3 - что-то возвращает, но ничего не принимает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Вид 4 - что-то принимают и что-то возвращают

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = string.Empty;
//    while(i<count)
//    {
//        result = result + text;
//        i++;
//    }
//
//    return result;
//}
string Method4(int count, string text)
{
string result = string.Empty;

for (int i = 0; i < count; i++)
    {
    result = result + text;
    }
return result;
}

string res = Method4(5, "Tex");

Console.WriteLine(res);
