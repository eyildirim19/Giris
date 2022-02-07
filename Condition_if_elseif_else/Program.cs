/*
    else if => birbirine bağlı koşullar yazmak için kullanılır....
 */
Console.WriteLine("1. Sayıyı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı Giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

// programın performans kaybı olmaması ve doğru çalışması için ifleri birbirine bağlamak gerekir. çünkü burada tek koşul sağlanabilir...
if (sayi > sayi2)
{
    Console.WriteLine("1. Sayı büyüktür");
}
else if (sayi2 > sayi)
{
    Console.WriteLine("2. Sayı büyüktür");
}
else
{
    Console.WriteLine("Sayılar eşit");
}

Console.WriteLine("Program doğru sonucu buldu...");