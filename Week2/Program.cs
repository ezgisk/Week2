// First Question
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
//Second Question
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}
//Third Question
for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}
//Fourth Question
int sum = 0;
for (int i = 50; i <= 150; i++)
{
    sum += i;
}
Console.WriteLine("Toplam:" + sum);
//Fifth Question
int oddTotal = 0;
int evenTotal = 0;
for (int i = 2; i < 120; i++)
{
    if (i % 2 == 0)//Check odd or even number
        evenTotal += i;
    else
        oddTotal += i;
}

Console.WriteLine("Cift sayilarin toplami " + evenTotal);
Console.WriteLine("Tek sayilarin toplami " + oddTotal);