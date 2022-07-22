int a = 56125;

if ( a % 10 == (a-a % 10000)/10000 || (a % 100 - a % 10)/10 == ((a-a % 1000) - (a-a % 10000))/1000)
Console.WriteLine("Polindrome");
