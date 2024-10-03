// First Question
int i = 1;
while (i < 21)
{
    Console.WriteLine($"{i} - Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
Console.WriteLine("------------------------------------------------- ");
//Second Question
int a = 1;
while (a < 21)
{
    Console.WriteLine(a);
    a++;
}
Console.WriteLine("------------------------------------------------- ");
//Third Question
int b = 2;
while (b < 21)
{
    if (b % 2 == 0)
        Console.WriteLine(b);
    b++;
}
Console.WriteLine("------------------------------------------------- ");
//Fourth Question
int sum = 0;
int c = 50;
while (c <= 150)
{
    sum += c;
    c++;
}
Console.WriteLine("Toplam:" + sum);
Console.WriteLine("------------------------------------------------- ");
//Fifth Question
int oddTotal = 0;
int evenTotal = 0;
int d = 2;//1-120 arasında dedıgı ıcın 2'den baslattım
while (d < 120) { 
    if (d % 2 == 0)//Check odd or even number
        evenTotal += d;
    else
        oddTotal += d;
    d++;
}

Console.WriteLine("Cift sayilarin toplami " + evenTotal);
Console.WriteLine("Tek sayilarin toplami " + oddTotal);