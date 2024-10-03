using System.Collections.Generic;
Console.WriteLine("While ile Cozumu ");

Console.Write("Bir Limit Giriniz: ");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("*****************************");
if (number < 0) // Girilen sayinin sifirdan kucuk oldugunun kontrolu
    Console.WriteLine("Girdiginiz sayi sifirdan kucuk");
else
{
    int i = 0;
    while (i <= number)
    {
        Console.WriteLine($"{i} Ben bir Patika'lıyım");
        i++;

    }
}
Console.WriteLine("*****************************");
Console.WriteLine("Do-While ile Cozumu ");

Console.Write("Bir Limit Giriniz: ");

int number1 = int.Parse(Console.ReadLine());
int b = 0;
Console.WriteLine("*****************************");
do
{

    Console.WriteLine(number1 < 0 ? "Girdiginiz sayi sifirdan kucuk." : $"{b} Ben bir Patika'lıyım");
    b++;

} while (b <= number1);

Console.ReadKey();