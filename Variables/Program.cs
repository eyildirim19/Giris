//Algoritma... problem çözme tekniğidir..

// Veri        =>
// Değişkenler =>
/* 
 * 
 *  Veriler Disk'te (Kalıcı) veya ram'de(geçici) saklanır... 
 *  
 *  Değişken Nedir ? => ramde veri saklamak için kullanılan alanlardır. Bellekteki adres işaretçileridir...
 *  
 *  Değişken oluşturabilmek için veritiplerine ihtiçaç vardır...
 *  Veri Tipleri 3 ana grupta inceleriz;
 *  1) Metinsel Veri Tipleri (char,string)
 *  2) Sayısal Veri Tipleri = tam sayı(byte,sbyte,short,ushort,int,uint,long,ulong) ondalıklı (float,decimal,double)
 *  3) Mantıksal Veri Tipi  (bool)
 *  
 *  
 *  object => c#'taki bütün tipleirn atasıdır.....
 *  
 *  Ornek;
 *  <veriTipi> <degiskenAdi>;   (Not: komut satırı ; ile sonlandırılmalıdır.)
 *  veya
 *  <veriTipi> <degiskenAdi> = <ilkDeger>;
 *  Not :  = c# dilinde atama operatörüdür. sağdaki değeri sola atar (set eder)...
 *  
*/
int sayi; // int tipinde sayı değişkeni ...

int a = 1;

int b = 100;
a = b; // b'nin değerini a'ya koplaya...

b = 5;
// a ??
Console.WriteLine($"b'nin değeri {b}"); // ekrana mesaj vermek için Console sınıfının WriteLine komutu kullanılır...
Console.WriteLine($"$a'nın deperi {a}");

// eğer tip ortak ise tek satırda fazla değişken tanımı yapabilir....
int i, j; // int tipinde i ve j değişkenleri
int k = 1, l;
int o = 1, z = 200;

// değişken tanımlarken;
//1 ) değişken  isimleri benzersiz (unique) olmalıdır...
int yas;
//int yas; yas değişkeni 46'ıncı satırda tanımlı olduğu için bu satır hata verecektir...
// 2) değişkenler tanım satırlarından sonra kullanılabilir
// 3) değişken isimleri ön tanımlı kod isimleri kullanılamaz...
// 4) değişken isimleri rakamla başlayamaz.. örnek (int 1sayi); 
// 5) değişken ömürleri tanımlı oldukları scope kadardır..
// scope { } bunları açmak için altGr 7 { kapatmak için altGr 0 }
{
    int r;
}

byte v1 = 255; // byte tipli v1 değişkeni 
sbyte v2; // sbyte tipli v2 değişkeni 
int v3; // int tipli v3 değişkeni
char v4 = 'b'; // char tipli v4 değişkeni 
string v5 = "bt"; // string tipli v5 değişkeni
// char tek karakter string birden fazla karakter yazılabilir.

bool v6 = true; // True veya False değeri alabilir...
double v7 = 3.1; // ondalıklı sayılar double olarak yorumlanır...

/*
    10 tam sayı // sbtye,byte,short,ushort,int,uint,long,ulong
    11.1 ondalıklı sayı  // double
    ' ' tek karakter // char
    " " metin // string
    true/false bool
 */
float f = 3.1f; // f ekini float olarka yorumlar
decimal d = 3.1m; //  m ekini decimal olarak yorumlar..
char c = 'c';
c = 'a';
c = 'e';
c = 'd';

char i1 = 'e';
char i2 = 'k';
char i3 = 'r';
char i4 = 'e';
char i5 = 'm';
string isim = "ekrem";

string s = "Merhaba C# veritipleri";

Console.WriteLine("Merhaba C# veritipleri");
Console.WriteLine(v1); // v1'in değerini ekrana yazdır..
Console.WriteLine(v4);
Console.WriteLine(v5);
Console.WriteLine(v6);
Console.WriteLine(v7);
Console.WriteLine(f);
Console.WriteLine(d);