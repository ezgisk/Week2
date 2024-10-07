string anotherHoliday;// En basta tanimlamamin sebebi kodun bircok yerinde kullanilip gorunur olmasi.
do
{
    Console.Write("Nereye gitmek istiyorsunuz (Bodrum/Marmaris/Cesme):");
    string city = Console.ReadLine().ToLower();

    if (city != "marmaris" && city != "bodrum" && city != "ceşme")//Yanlis bir tatil yeri secip semedigini kontrol ettigim yer
    {
        Console.Write("Yanlis sehir sectiniz!! Lutfen tekrar Bodrum/Marmaris/Cesme lokasyonlarindan birini seciniz:");
        city = Console.ReadLine().ToLower();

    }

    Console.Write("Kac kisilik bir tatil planliyorsunuz?");
    int personCount = Convert.ToInt32(Console.ReadLine());
    string toDoList;//Secilen yere gore yapilicaklar icin olusturulan degisken
    if (city == "marmaris")
    {
        toDoList = " Öncelikle, güzel plajlarında güneşlenip denizin tadını çıkarabilirsiniz. " +
            "Su sporları, özellikle jet ski ve banana bot gibi aktiviteler oldukça popülerdir. " +
            "Ayrıca, Marmaris Kalesi’ni ziyaret ederek tarihi ve kültürel zenginlikleri keşfedebilir, " +
            "akşamları da hareketli barlar sokağında eğlenceli vakit geçirebilirsiniz.";
    }
    else if (city == "bodrum")
    {
        toDoList = " Öncelikle, muhteşem plajlarında güneşlenip deniz keyfi yapabilirsiniz. " +
            "Bodrum Kalesi’ni ziyaret ederek tarihi kalıntıları keşfedebilir ve harika manzaralar eşliğinde fotoğraflar çekebilirsiniz." +
            " Ayrıca, akşamları canlı müzik ve eğlence mekanlarında keyifli vakit geçirerek Bodrum’un gece hayatını deneyimleyebilirsiniz.";
    }
    else
    {
        toDoList = "Öncelikle, ünlü plajlarında yüzme ve güneşlenme imkanı bulabilir, su sporları ile adrenalin dolu anlar yaşayabilirsiniz. " +
            "Ayrıca, Çeşme Kalesi’ni ziyaret ederek tarihi dokusunu keşfedebilir ve güzel manzaraların tadını çıkarabilirsiniz. " +
            "Akşamları ise, canlı müzik eşliğinde restoranlarda ve barlarda lezzetli yerel yemeklerin tadını çıkararak eğlenceli bir gece geçirebilirsiniz.";
    }
    Console.WriteLine($"Gitmek istediginiz lokasyon {city}.{personCount} kisilik bir tatil planladiniz.{city}'de yapilicak aktiviteler: {toDoList}");
    Console.Write("Tatile hangi sekilde gitmek istiyorsunuz?\r\n\r\n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)\r\n\r\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\r\n\r\nSecim:");
    String choosenWay = Console.ReadLine();//Hangi yolla gidiliceginin atandigi degisken
    if (choosenWay != "1" && choosenWay != "2")//1 ya da 2 haricinde bir secim yapildigini kontrol ettigim yer
    {
        Console.Write("Yanlis secim yaptiniz. Lutfen  1 ya da 2 numarali secimi yapiniz.");
        choosenWay = Console.ReadLine();
    }
    else
    {
        int totalPrice;
        if (choosenWay == "1")//Secilen yere gore total ucreti buldugum kisim
        {
            totalPrice = personCount * 1500;
            Console.WriteLine($"Gitmek istediginiz lokasyon {city}.{personCount} kisilik bir tatil planladiniz.Toplam maaliyet: {totalPrice}");
        }
        else
        {
            totalPrice = personCount * 4000;
            Console.WriteLine($"Gitmek istediginiz lokasyon {city}.{personCount} kisilik bir tatil planladiniz.Toplam maaliyet: {totalPrice}");
        }

    }
    Console.Write("Baska bir tatil planlamak istiyor musunuz?(Y/N)");
    anotherHoliday = Console.ReadLine().ToUpper();
} while (anotherHoliday == "Y");
Console.WriteLine("İyi günler dileriz!");

Console.ReadKey();