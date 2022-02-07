

Console.WriteLine("Adınız???");

string ad = Console.ReadLine(); // Console'dan veri almak için kullanılır.... // satırı oku ad değişkenine ata..
Console.WriteLine("Hoş geldin " + ad);



// kullanıcıdan iki sayı girmesini isteyelim...
int sayi1, sayi2;
Console.WriteLine("1. Sayıyı giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine()); // stringi int'd çevir ve ata...

Console.WriteLine("2. Sayıyı giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = sayi1 + sayi2;
Console.WriteLine("İşlem sonucu " + sonuc);

float vize, final, ortalama;

Console.WriteLine("Vize notunuz??");
vize = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Final notunuz???");
final = Convert.ToSingle(Console.ReadLine());

ortalama = vize * 0.3f + final * 0.6f;

Console.WriteLine("Ortalama Notunuz = " + ortalama);


Console.WriteLine("Cinsiyeniz???");
char c = Convert.ToChar(Console.ReadLine());
