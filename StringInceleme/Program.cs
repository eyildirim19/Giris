/* 
 * String tipi aslında bir char dizisidir...birden fazla karakterden oluşur. Dizi gibi metotları vardır. elemanlarına index bazlı erişilebilir...
 * 
 * string bir dizi gibi düşünülebilir ama özel bir tiptir..
 */

string[] names = { "recep", "emre" };
string name1 = names[0]; // recep
string name2 = names[1]; // emre

char c = 'e';
string name = "ekrem";

Console.WriteLine(name.Length); // 5 name değişkeninin uzunluğu...

//char f = name; // tipler eşit değil tek char'a birden fazla char atanamaz
//char l = name; // tipler eşit değil tek char'a birden fazla char atanamaz

char f = name[0]; // name değişkeninin 0. karakterini ata...
char l = name[4]; // name değişkeninin 4. karakterini ata...

Console.WriteLine(f);
Console.WriteLine(l);

for (int i = 0; i < name.Length; i++)
    Console.WriteLine(name[i]);

Console.WriteLine("***");

for (int j = name.Length; j > 0; j--)
    Console.WriteLine(name[j - 1]);

string ogrenci = "Kaan";
//ogrenci[0] = 'k'; stringine index bazlı atama yapılamaz. çünkü read only (sadece okunabilir)'dir.
Console.WriteLine(ogrenci.ToUpper());
Console.WriteLine(ogrenci.ToLower());

Console.WriteLine("Lütfen adınızı yazınız..");
string ad = Console.ReadLine();

char[] ads = new char[0]; // 0 elemanlı bir karakter dizisi...
for (int i = 0; i < ad.Length; i++)
{
    Array.Resize(ref ads, ads.Length + 1); // dizinin uzunluğunu 1 arttır..
    ads[i] = ad[i];
}

for (int i = ads.Length; i > 0; i--)
    Console.Write(ads[i - 1]);

Console.WriteLine("********************************");

Console.WriteLine("Lütfen adınızı yazınız..");
string ad1 = Console.ReadLine();
char[] ch = ad1.ToCharArray(); // ToCharArray => string'i char dizisine çevirir...
Array.Reverse(ch); // terst çevir...
ad1 = new string(ch); // char dizisinden yeni bir string oluştur.
Console.WriteLine(ad1);
