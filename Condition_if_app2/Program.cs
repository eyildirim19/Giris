// öğrencinin vize final notu alınsın...
// ortalaması 25'den büyük olan öğrencilerin;
// 85-100 arasında ise AA
// 70-84 arasında ise BA
// 60-69 arasında ise BB
// diğer aralıkları kendiniz belirleyiniz
double d = 3.1;
float f = 3.1f; // float olarak yorumla
decimal m = 3.1m; // decimal olarak yorumla
int a = Convert.ToInt32(3.1);
Console.WriteLine("anın değeri" + a);
float vize, final, ortalama;
Console.WriteLine("Vize Notunuz");
vize = Convert.ToSingle(Console.ReadLine());

// Not : eğer if bloğunu içerisinde tek satırlık kod varsa scope aç kapaya gerek yoktur...
if (vize < 0 || vize > 100)
    Console.WriteLine("Geçersiz Vize");

Console.WriteLine("Final Notunuz");
final = Convert.ToSingle(Console.ReadLine());

if (final < 0 || final > 100)
    Console.WriteLine("Geçersiz Final");

ortalama = vize * 0.4f + final * 0.6f;

if (ortalama >= 25)
{
    // not : else if ifadesi (koşullardan birisi) çalıştıktan sonra diğer koşullara bakılmaz...
    string harfNot = "";
    if (ortalama >= 85)
        harfNot = "AA";
    else if (ortalama >= 75)
        harfNot = "BA";
    else if (ortalama >= 65)
        harfNot = "BB";
    else if (ortalama >= 55)
        harfNot = "CB";
    else if (ortalama >= 45)
        harfNot = "CC";
    else if (ortalama >= 25)
        harfNot = "DD";
    //Console.WriteLine("Harf Notunuz = " + harfNot);
    // String Format...
    Console.WriteLine($"Harf Notunuz \"{harfNot}\"");
}
else
{
    Console.WriteLine("Harf Notu Hesaplanamadı...");
    Console.WriteLine("Kaldın .....");
}