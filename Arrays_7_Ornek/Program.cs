

int a = 1, b = 2;
int[] nums = { a, b };

Array.Reverse(nums);

a = nums[0];
b = nums[1];

Console.WriteLine($"a = {a} & b = {b}");

a = a + b; // a'ya b'yi ekle... 3
b = a - b; //  2
a = a - b; // 1

Console.WriteLine($"a = {a} & b = {b}");

// Kullanıcıdan 5 adet benzersiz sayı alalım..
// bu sayıların;
// en büyüğünü
// en küçüküğünü
// ortalamasını ekrana yazdıralım..

// Ödev: bu örneğin aynısını for döngüsü ile yapınız.. Not : for'un yapısını bozmadan...
//for(int i=0; i<sayis.Length;i++)
int n = 5;
int[] sayis = new int[n];

int i = 0;
/*
while (i < sayis.Length)
{
    Console.WriteLine($"Lütfen ({i + 1}). sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (Array.IndexOf(sayis, sayi) == -1) // sayi'yi sayisde ara..
    {
        sayis[i] = sayi;
        i++;
    }
}
*/
// While ile koşul sağlandığında i arttığı için indexler boş geçilmez...For ile koşul sağlansın sağlanmsın i arttığı için indexler boş geçilir...
for (i = 0; i < sayis.Length; i++)
{
    Console.WriteLine($"Lütfen ({i + 1}). sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (Array.IndexOf(sayis, sayi) == -1) // sayi'yi sayisde ara..
    {
        sayis[i] = sayi;
    }
    else
    {
        i--; // i'yi azalt...
    }
}
Console.WriteLine("***********");
// Array sınıfı ForEach metodu döngü kurmadan elemanlara erişmemizi sağlar. buradaki => ifadesi lambda ifadesidir.(İleride çok sık kullanılacaktır.) sayis dizisindeki elemanları c'ye ata, c ile işlem yap..
Array.ForEach(sayis, c => Console.WriteLine(c));
Console.WriteLine("***********");


Console.WriteLine($"en büyüğü {sayis.Max()}");
Console.WriteLine($"en küçüüğü {sayis.Min()}");
Console.WriteLine($"ortalaması {sayis.Average()}");



