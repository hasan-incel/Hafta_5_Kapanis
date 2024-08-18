using Hafta_5_Kapanis;

List<Araba> arabalar = new List<Araba>();

while (true)
{
    // Kullanıcıya araba üretmek isteyip istemediği soruluyor
    Console.WriteLine("\nAraba üretmek istiyor musunuz? (e/h)");
    string cevap = Console.ReadLine().Trim().ToLower();

    // Eğer kullanıcı 'e' cevabını verirse, yeni bir araba üretimi başlatılır
    if (cevap == "e")
    {
        Araba yeniAraba = new Araba(); // Yeni bir araba nesnesi oluşturuluyor
        yeniAraba.UretimTarihi = DateTime.Now; 

        // Kullanıcıdan arabayı tanımlayan bilgileri alıyoruz
        Console.Write("Seri Numarası: ");
        yeniAraba.SeriNumarasi = Console.ReadLine().Trim();

        Console.Write("Marka: ");
        yeniAraba.Marka = Console.ReadLine().Trim();

        Console.Write("Model: ");
        yeniAraba.Model = Console.ReadLine().Trim();

        Console.Write("Renk: ");
        yeniAraba.Renk = Console.ReadLine().Trim();

    // Kapı sayısını alırken kullanıcıdan geçerli bir sayı girmesi isteniyor
    GirisKapiSayisi:
        Console.Write("Kapı Sayısı: ");
        string kapiSayisiStr = Console.ReadLine().Trim();

        // Eğer girilen değer sayısal bir değerse, kapı sayısını atıyoruz
        if (int.TryParse(kapiSayisiStr, out int kapiSayisi))
        {
            yeniAraba.KapiSayisi = kapiSayisi;
        }
        else
        {
            // Eğer girilen değer geçersizse, kullanıcı uyarılıyor ve aynı bilgiyi yeniden girmesi isteniyor
            Console.WriteLine("Geçersiz kapı sayısı, lütfen tekrar girin.");
            goto GirisKapiSayisi; // Kapı sayısını yeniden girmeye yönlendiriyoruz
        }

        // Yeni araba nesnesi arabalar listesine ekleniyor
        arabalar.Add(yeniAraba);
        
        // Üretilen arabaların seri numaralarını ve markalarını ekrana yazdırıyoruz
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (Araba araba in arabalar)
        {
            Console.WriteLine($"\nSeri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
    // Eğer kullanıcı 'h' cevabını verirse, program sonlandırılıyor
    else if (cevap == "h")
    {
        Console.WriteLine("Program sonlandırılıyor...");
        break; // Döngüyü kırarak programı sonlandırıyoruz
    }
    // Geçersiz cevap durumunda kullanıcı bilgilendiriliyor ve döngü tekrar başa dönüyor
    else
    {
        Console.WriteLine("Geçersiz cevap, lütfen 'E' veya 'H' girin.");
        continue; // Döngünün başına dönerek tekrar cevap bekliyoruz
    }
}

