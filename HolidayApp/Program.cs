using System;

class Program
{
    static void Main()
    {
        int totalPrice;
        int initialPrice = 0;
        string anotherHoliday; // En başta tanımlamanın sebebi kodun birçok yerinde kullanılıp görünür olması.

        do
        {
            Console.Write("Nereye gitmek istiyorsunuz (Bodrum/Marmaris/Çeşme)" +
                "\r\n\r\n1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\r\n\r\n2 - Marmaris (Paket başlangıç fiyatı 3000 TL)\r\n\r\n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)\r\n\r\nSeçim:");

            string city = Console.ReadLine().ToLower();
            while (city != "marmaris" && city != "bodrum" && city != "cesme") // Yanlış bir tatil yeri seçip seçmediğini kontrol ettiğim yer
            {
                Console.Write("Yanlış şehir seçtiniz!! Lütfen tekrar Bodrum/Marmaris/Çeşme lokasyonlarından birini seçiniz: ");
                city = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Kaç kişilik bir tatil planlıyorsunuz?");
            int personCount;
            while (!int.TryParse(Console.ReadLine(), out personCount) || personCount <= 0) // Geçerli bir kişi sayısı kontrolü
            {
                Console.WriteLine("Lütfen geçerli bir kişi sayısı girin.");
            }

            string toDoList; // Seçilen yere göre yapılacaklar için oluşturulan değişken
            switch (city)
            {
                case "marmaris":
                    toDoList = "Öncelikle, güzel plajlarında güneşlenip denizin tadını çıkarabilirsiniz. " +
                               "Su sporları, özellikle jet ski ve banana bot gibi aktiviteler oldukça popülerdir. " +
                               "Ayrıca, Marmaris Kalesi’ni ziyaret ederek tarihi ve kültürel zenginlikleri keşfedebilir, " +
                               "akşamları da hareketli barlar sokağında eğlenceli vakit geçirebilirsiniz.";
                    initialPrice = 3000;
                    break;
                case "bodrum":
                    toDoList = "Öncelikle, muhteşem plajlarında güneşlenip deniz keyfi yapabilirsiniz. " +
                               "Bodrum Kalesi’ni ziyaret ederek tarihi kalıntıları keşfedebilir ve harika manzaralar eşliğinde fotoğraflar çekebilirsiniz. " +
                               "Ayrıca, akşamları canlı müzik ve eğlence mekanlarında keyifli vakit geçirerek Bodrum’un gece hayatını deneyimleyebilirsiniz.";
                    initialPrice = 4000;
                    break;
                default: // "çeşme"
                    toDoList = "Öncelikle, ünlü plajlarında yüzme ve güneşlenme imkanı bulabilir, su sporları ile adrenalin dolu anlar yaşayabilirsiniz. " +
                               "Ayrıca, Çeşme Kalesi’ni ziyaret ederek tarihi dokusunu keşfedebilir ve güzel manzaraların tadını çıkarabilirsiniz. " +
                               "Akşamları ise, canlı müzik eşliğinde restoranlarda ve barlarda lezzetli yerel yemeklerin tadını çıkararak eğlenceli bir gece geçirebilirsiniz.";
                    initialPrice = 5000;
                    break;
            }

            Console.WriteLine($"Gitmek istediğiniz lokasyon: {city}. {personCount} kişilik bir tatil planladınız. {city}'de yapılacak aktiviteler: {toDoList}");
            Console.Write("Tatile hangi şekilde gitmek istiyorsunuz?\r\n\r\n1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)\r\n\r\n2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\r\n\r\nSeçim: ");
            string choosenWay = Console.ReadLine(); // Hangi yolla gidileceğinin atandığı değişken

            while (choosenWay != "1" && choosenWay != "2") // 1 ya da 2 haricinde bir seçim yapıldığını kontrol ettiğim yer
            {
                Console.Write("Yanlış seçim yaptınız. Lütfen 1 ya da 2 numaralı seçimi yapınız: ");
                choosenWay = Console.ReadLine();
            }

            // Seçilen yere göre toplam ücreti bulduğum kısım
            int transportationCost = (choosenWay == "1") ? 1500 : 4000;
            totalPrice = personCount * (transportationCost + initialPrice);
            Console.WriteLine($"Gitmek istediğiniz lokasyon: {city}. {personCount} kişilik bir tatil planladınız. Toplam maliyet: {totalPrice} TL");

            Console.Write("Başka bir tatil planlamak istiyor musunuz? (Y/N): ");
            anotherHoliday = Console.ReadLine().ToUpper();
        } while (anotherHoliday == "Y");

        Console.WriteLine("İyi günler dileriz!");
        Console.ReadKey();
    }
}
