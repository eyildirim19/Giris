string[] isimler = new string[3]; // 3 adet string
isimler[0] = "Recep";
isimler[1] = "Ekrem";
isimler[2] = "Emre";

//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);

char[] karakterler = new char[5]; // 5 adet char
karakterler[0] = 'E';
karakterler[1] = 'k';
karakterler[2] = 'r';
karakterler[3] = 'e';
karakterler[4] = 'm';

bool[] durumlar = new bool[3]; // 3 adet
durumlar[0] = true;
durumlar[1] = false;
durumlar[2] = true;

string[] ogrenciler = new string[4]; // 4 adet
ogrenciler[0] = "Kaan";
ogrenciler[1] = "Bilal";
ogrenciler[2] = "Nur";
ogrenciler[3] = "Sümeyye";

byte[] bytler = new byte[500]; // 500 adet


for (int i = 0; i < 3; i++)
{
    Console.WriteLine(isimler[i]);
}
// c# dilinde sadece diziler için kullanılabilen bir döngü daha vardır...o da foreach döngüsüdür..
// isim değişkeni tanımlanır.in ifadesi ile dizinin sıradaki elemanı isim değişkenine atanır ve döngü içinde o değişken kullanılır....
// dizilerde ileri yönlü okuma yapmak için kullanır. Sadece dizinin elemanlarına erişmek için kullanılır..
foreach (string isim in isimler)
{
    Console.WriteLine(isim);
}

foreach (char k in karakterler)
{
    Console.WriteLine(k);
}

foreach (bool d in durumlar)
{
    Console.WriteLine(d);
}

foreach (string ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}


int[] sayilar = new int[5];
sayilar[2] = 3;
sayilar[4] = 5;
sayilar[1] = 2;
sayilar[3] = 4;
sayilar[0] = 1;

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);  // 
}

// dizide ekstra bir işlem yapmadan diziyi foreach döngüsü ile tersten okuyamayız.. 
// Length => dizinin uzunluğunu (eleman sayısı)verir..
Console.WriteLine($"Sayılar dizisinin uzunluğu {sayilar.Length}");

//for (int i = 4; i >= 0; i--)
for (int i = sayilar.Length; i > 0; i--)
{
    Console.WriteLine(sayilar[i - 1]);
}

int l = isimler.Length - 1; // 2
while (l >= 0)
{
    Console.WriteLine(isimler[l--]);
}

int ji = karakterler.Length;
while (ji > 0)
{
    Console.WriteLine(karakterler[ji - 1]);
    ji--;
}