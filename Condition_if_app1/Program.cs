/*
kullanıcıdan 1 sayı istenecek.. EĞer sayı 1 ile 100 arasında ise "Sayı Pozitif" mesajı verilecek. Eğer 0'dan küçükse "sayı negatif" mesajı verilecek, eğer 0 ise "Sayı 0 " mesajı verilecek...
 */
int sayi = Convert.ToInt32(Console.ReadLine()); //-5
if (sayi <= 100) // girilen sayı 100den küçük mü ??
{
    if (sayi < 0)
    {
        Console.WriteLine("Negatif");
    }
    else if (sayi == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        Console.WriteLine("Pozitif");
    }
}
else
{
    Console.WriteLine("Sayıyı beğenmedim....");
}

// öğrencinin vize final notu alınsın...
// ortalaması 25'den büyük olan öğrencilerin;
// 85-100 arasında ise AA
// 70-84 arasında ise BA
// 60-69 arasında ise BB
// diğer aralıkları kendiniz belirleyiniz