
//Geriye Değer Döndürmeyen Bir void metot.
using System.Reflection.Metadata;

WriteSongName();
Console.WriteLine("------------------------------------");
//Geriye Tamsayı Döndüren Bir metot
int kalan = ReturnInteger();
Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {kalan}");
Console.WriteLine("------------------------------------");
//Parametre Alan ve Geriye Değer Döndüren Bir Metot
int carpim = MultiplicationCalc(10, 4);
Console.WriteLine($"4 ile 10'un çarpımı: {carpim}");
Console.WriteLine("------------------------------------");
//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
NameSurname("Ezgi", "Gecimli");
static void WriteSongName()//Sarki sozu yazdiran methot
{
    Console.WriteLine("Kalbimin orta yerinde bu nasıl bir cumhuriyet seninki\r\nNasıl bir hakimiyet ben anlamadım\r\nSustum sustum sonunda dayanamadım");
}
static int ReturnInteger()//Random sayi ureten ve bu sayinin 2 ile bolumunu geri donduren methodt
{
    Random randomNumber = new Random();
    int number = randomNumber.Next(1, 100);
    return number % 2;
}

static int MultiplicationCalc(int a, int b)//Aldigi parametreleri carpan ve bu carpimi geri donduren methot
{
    return a * b;
}
static void NameSurname(string isim, string soyisim)//Kullanicinin adini soyadini yazdiran methot
{
    Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
}
Console.ReadKey();
