
//1 - Aşağıdaki çıktıyı yazan bir program.
Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?");

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
string name = "Ezgi";
int age = 27;
Console.WriteLine("---------------------------------------");
Console.WriteLine($"Adiniz : {name} Yasiniz : {age}");
Console.WriteLine("---------------------------------------");

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random random = new Random(); //Random sayi ureten methot
Console.WriteLine($"{random.Next(1, 101)}");
Console.WriteLine("---------------------------------------");

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random rnd = new Random();
Console.WriteLine($"{rnd.Next(1, 101) % 3}");// 3 ile bolumunden kalani kontrol eden kisim
Console.WriteLine("---------------------------------------");

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("Yasinizi Girin:");
int userAge;
if (int.TryParse(Console.ReadLine(), out userAge))
{
    // Yaş kontrolü
    if (userAge > 18)
    {
        Console.WriteLine("+");
    }
    else
    {
        Console.WriteLine("-");
    }
}
else
{
    Console.WriteLine("Geçersiz bir yaş girdiniz.");
}
Console.WriteLine("---------------------------------------");

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("---------------------------------------");

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.Write("En sevdiginiz unlunun adi ve soyadinizi girin :");
string celebrity1 = Console.ReadLine();
Console.Write("Ikinci en sevdiginiz unlunun adi ve soyadinizi girin :");
string celebrity2 = Console.ReadLine();
ChangeString(ref celebrity1, ref celebrity2);//Stringleri degistiren fonksiyon
Console.WriteLine($"Stringlerin degistirilmis hali {celebrity1} {celebrity2}");
void ChangeString(ref string a, ref string b)
{
    string temp = a;
    a = b; b = temp;

}
Console.WriteLine("---------------------------------------");

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
BenDegerDondurmem();
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
Console.WriteLine("---------------------------------------");

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int sayi1 = 10;
int sayi2 = 15;
int toplam = AddNumber(sayi1, sayi2);
Console.WriteLine($"Toplam : {toplam}");
int AddNumber(int sayi1, int sayi2)//Degerleri toplayan fonksiyon
{
    return sayi1 + sayi2;
}
Console.WriteLine("---------------------------------------");

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

Console.Write("True ya da False degeri secin : ");
bool choice;
if (bool.TryParse(Console.ReadLine().ToLower(), out choice))
{
    string returnValue = GetBooleanInput(ref choice);
    Console.WriteLine($"{returnValue}");

}
else
{
    Console.WriteLine("Geçersiz bir boolean değeri.");
}

string GetBooleanInput(ref bool choice)
{
    string value = $"Girdiginiz deger " + choice.ToString();
    return value;
}

Console.WriteLine("---------------------------------------");

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.Write("1.Kişinin Yaşını Giriniz: ");
int personAge1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2.Kişinin Yaşını Giriniz: ");
int personAge2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3.Kişinin Yaşını Giriniz: ");
int personAge3 = Convert.ToInt32(Console.ReadLine());
int yasli = EnYasliKisiYasiAl(personAge1, personAge2, personAge3);// yas kontorlunun yapildigi fonksiyon
Console.WriteLine($"En yasli {yasli}");
int EnYasliKisiYasiAl(int personAge1, int personAge2, int personAge3)
{

    return Math.Max(Math.Max(personAge1, personAge2), personAge3);
}
Console.WriteLine("---------------------------------------");

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int enBuyuk = EnBuyukSayiyiBul();
Console.WriteLine($"En büyük sayı: {enBuyuk}");
static int EnBuyukSayiyiBul()
{
    int? enBuyuk = null;
    string input;

    while (true)
    {
        Console.Write("Bir sayı girin (çıkmak için 'exit' yazın): ");
        input = Console.ReadLine();

        if (input.ToLower() == "exit")
        {
            break;
        }

        if (int.TryParse(input, out int sayi))
        {
            if (enBuyuk == null || sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
        }
    }

    return enBuyuk ?? 0; // Eğer hiç sayı girilmemişse 0 döner
}
Console.WriteLine("---------------------------------------");

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.Write("Bir isim giriniz :");
string name1 = Console.ReadLine();
Console.Write("Bir isim daha giriniz :");
string name2 = Console.ReadLine();
ChangeName(ref name1, ref name2);
Console.WriteLine($"Isimlerin degistirilmis hali {name1} {name2}");
void ChangeName(ref string a, ref string b)
{
    string temp = a;
    a = b; b = temp;

}
Console.WriteLine("---------------------------------------");
//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.Write("Bir sayi giriniz :");
int number;
if (int.TryParse(Console.ReadLine(), out number))
{
    bool oddOrEven = OddOrEven(number);
    Console.WriteLine(oddOrEven ? "Cift sayi girdiniz" : "Tek sayi girdiniz");
}
else
{
    Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");

}
bool OddOrEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("---------------------------------------");

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
double yol = HesaplaYol();
Console.WriteLine($"Gidilen yol: {yol} km");

double HesaplaYol()
{
    Console.Write("Lütfen hızı (km/saat) girin: ");
    double hiz = Convert.ToDouble(Console.ReadLine());

    Console.Write("Lütfen zamanı (saat) girin: ");
    double zaman = Convert.ToDouble(Console.ReadLine());

    // Yol hesaplama
    double yol = hiz * zaman;
    return yol;
}
Console.WriteLine("---------------------------------------");

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

double yaricap = 2.4;
double alan = YaricapHesapla( yaricap );
Console.WriteLine($"Dairenin alani :{alan}");

double YaricapHesapla(double yaricap)
{
    return Math.PI * Math.Pow(yaricap, 2);
}
Console.WriteLine("---------------------------------------");

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string toLower = "Zaman bir GeRi SayIm";
string toUpper = "Zaman bir GeRi SayIm";
Console.WriteLine(toLower.ToLower());
Console.WriteLine(toUpper.ToUpper());

Console.WriteLine("---------------------------------------");

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string degisken = "    Selamlar   ";
Console.WriteLine(degisken.Trim());
Console.ReadKey();
