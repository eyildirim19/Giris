// jump deyimleri;
// continue : döngü içeriisnde kullanılır. döngü ile continue komutu arası kodlar tekrar çalıştırılır. Yani continue komutu execute edilirken döngü koşulana tekrar dönüşür..yani koşuş ifadesini tekrar çalışrırır.
// break    : döngü içerisinde ve switch ifadelerindde kullanılır. bulunduğu scope'ı sonlandırır
// return   : daha sonra konuşuruz... (her yerde kullanılır). olayı sonlandırır...
// 3 ifadeninde ortak noktası altındaki hiç bir kodu çalıştırmaz...

// not : jump deyimleri sizi ekstra ifler'den vs. kurtarır...

// continue örnek...

int sayac = 0;
while (sayac < 100)
{
    sayac++;
    // % mod operatörü => bölümden kalanı verir...
    if (sayac % 2 != 0)
        continue;

    Console.WriteLine(sayac);
}




int n;
int i = 0;

Console.WriteLine("Kaç adet öğrencin notu girilecek???");
n = Convert.ToInt32(Console.ReadLine());
double gOrt = 0, gToplam = 0;
int enbi = 0, enki = 0;
double enb = 0, enk = 100; // vize ile final 0 ile 100 arasında olacağı için ters atama yaparsanız enb ve enk'i bulursunuz...

// veya
int vizeECount = 0;

enb = Double.MinValue;
enk = Double.MaxValue;


// break ifadesi döngü içerisinde kullanıldığında bulundğu döngü'yü kırar..Not break ifadesi switch ve döngü içerisinde kullanılabilir
//if ("a" == "a")
//{
//    break;
//}

//while (i < n)
//{

//    double vize = 0, final = 0;
//    do
//    {
//        if (vizeECount == 3)
//        {
//            Console.WriteLine("Hakkın bitti");
//            break;
//        }

//        Console.WriteLine($"{i + 1} öğrencinin vize notu?");
//        vize = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine($"{i + 1} öğrencinin final notu?");
//        final = Convert.ToDouble(Console.ReadLine());

//        vizeECount++;
//    } while (vize < 0 || final < 0);

//    if (vizeECount == 3)
//    {
//        break;
//    }

//    double ort = vize * 0.4 + final * 0.6;
//    gToplam += ort;

//    if (ort > enb)
//    {
//        enbi = i + 1;
//        enb = ort;
//    }

//    if (ort < enk)
//    {
//        enki = i + 1;
//        enk = ort;
//    }

//    i++;
//}

//gOrt = gToplam / n;
//Console.WriteLine($"Sınıf genel ortalaması {gOrt}");
//Console.WriteLine($"En büyük ortalama {enb} ile {enbi} .ci öğrencinindir");
//Console.WriteLine($"En küçük ortalalama {enk} ile {enki} .ci öğrencinindir");



while (i < n)
{
    double vize = 0, final = 0;

    Console.WriteLine($"{i + 1} öğrencinin vize notu?");
    vize = Convert.ToDouble(Console.ReadLine());

    if (vize < 0 || vize > 100)
        continue;

    Console.WriteLine($"{i + 1} öğrencinin final notu?");
    final = Convert.ToDouble(Console.ReadLine());

    if (final < 0 || final > 100)
        continue;


    double ort = vize * 0.4 + final * 0.6;
    gToplam += ort;

    if (ort > enb)
    {
        enbi = i + 1;
        enb = ort;
    }

    if (ort < enk)
    {
        enki = i + 1;
        enk = ort;
    }

    i++;
}

gOrt = gToplam / n;
Console.WriteLine($"Sınıf genel ortalaması {gOrt}");
Console.WriteLine($"En büyük ortalama {enb} ile {enbi} .ci öğrencinindir");
Console.WriteLine($"En küçük ortalalama {enk} ile {enki} .ci öğrencinindir");

