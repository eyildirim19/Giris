

// 1) 
// N adet öğrencinin vize final notu istenecek..
// vize ve finalden n. öğrencinin ortalama hesaplanacak
// n adet öğrenciden En büyük ve En düşük ortalamıy notu ekrana yazdırınız..
// Sınıf ortalamasını ekrana yazdırınız...

//int n;
//int i = 0;

//Console.WriteLine("Kaç adet öğrencin notu girilecek???");
//n = Convert.ToInt32(Console.ReadLine());
//double gOrt = 0, gToplam = 0;

//double enb = 0, enk = 0;
//// 5 
//while (i < n)
//{
//    Console.WriteLine($"{i + 1} öğrencinin vize notu?");
//    double vize = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine($"{i + 1} öğrencinin final notu?");
//    double final = Convert.ToDouble(Console.ReadLine());

//    double ort = vize * 0.4 + final * 0.6;
//    gToplam += ort;

//    if (i == 0) // ilk bulunan ortalmanın en büyük ve en küçük kabul edilmesi için....
//    {
//        enb = ort;
//        enk = ort;
//    }

//    if (ort > enb)
//        enb = ort;

//    if (ort < enk)
//        enk = ort;

//    i++;
//}

//gOrt = gToplam / n;
//Console.WriteLine($"Sınıf genel ortalaması {gOrt}");
//Console.WriteLine($"En büyük ortalama {enb}");
//Console.WriteLine($"En küçük ortalalama {enk}");


int n;
int i = 0;

Console.WriteLine("Kaç adet öğrencin notu girilecek???");
n = Convert.ToInt32(Console.ReadLine());
double gOrt = 0, gToplam = 0;
int enbi = 0, enki = 0;
double enb = 0, enk = 100; // vize ile final 0 ile 100 arasında olacağı için ters atama yaparsanız enb ve enk'i bulursunuz...

// veya

enb = Double.MinValue;
enk = Double.MaxValue;

while (i < n)
{
    Console.WriteLine($"{i + 1} öğrencinin vize notu?");
    double vize = Convert.ToDouble(Console.ReadLine());



    Console.WriteLine($"{i + 1} öğrencinin final notu?");
    double final = Convert.ToDouble(Console.ReadLine());

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
