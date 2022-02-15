// new ifadesi ile bellekte instance(örnek) alınır.
// instance almak => bellekte kullanılabilir yeni bir alan açmaktır..
//tip[] diziAdi = new tip[diziUzunluk];
int[] sayilar = new int[1];
int s = 1;

sayilar[0] = 10;

//sayilar[1] = 2; böyle bir index olmadığı için atama yapılamaz...

int[] tempSayi = sayilar;
int a;

sayilar = new int[2];

Console.WriteLine(sayilar[0]); // çıktısı => 0 çünkü 11. satırda new int ifadesi ile yeni bir instance aldık..
Console.WriteLine(tempSayi[0]); // çıktısı => 10 çünkü 8. satırda sayilar dizisini temp dizisine atadık. Aslında sayılar dizisinin referansını (bellekteki alanı) tempdizisine atamış olduk...
string[] isimler = new string[5];
isimler[4] = "Recep";
isimler[0] = "Sümeyye";
isimler[1] = "Alper";
isimler[2] = "Kaan";
isimler[3] = "Emre";

string isim = "ekrem";
string name = isimler[4]; // name => Recep
int r = 0;
name = isimler[r++]; // =>  Sümeyye . çünkü r++ ifade o satır sıfır, alt satırda 1 olarak yansır..
name = isimler[++r];   // => Kaan

// 0 1 2 3 4 
for (int i = 0; i < 5; i++)
    Console.Write(isimler[i]);

// int sayi    => değişken (tek bir değer tutmak için kullanılır)
// int[] sayis => dizi değişken (birden fazla değer tutmak için kullanılır)

// new int[20] =>  20 tane int...
// string[1000] => 1000 tane string
// char[4] => 4 tane char...


int sayi = 25;

int[] sayis = new int[2];
sayis[0] = 10;
sayis[1] = 20;

// 
//sayi = sayis; // iki int bir inte atanamaz...
//sayis = sayi; // bir int iki inte atanamaz...
sayi = sayis[1]; // sayiların birincisni sayi değişkenine ata..
sayis[1] = sayi; // sayiların birinciine sayi'yi ata..
