/*
 * string metotları....
 */
string isim = "   ekrem     ";
string isim1 = "recep";

//Trim()=> string metinin sağ ve solundaki boşlukları siler
Console.WriteLine(isim + isim1);

//isim = isim.Trim();
Console.WriteLine(isim.Trim() + isim1);

string isim2 = "ekrem yıldırım";
string a = isim2.Substring(0, 5); // ekrem
string b = isim2.Substring(6, 8); // yıldırım

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine("Adınız SoyAdınız");
string FullName = Console.ReadLine(); // ekrem yıldırım

// IndexOf => metin içerisinde karakter arar..
int i = FullName.IndexOf(' ');
string Name = FullName.Substring(0, i);

Console.WriteLine($"Hoş geldin {Name}");

// Split => metni belirtilen karakterte göre parçalar ve dizi döner
string FullName2 = FullName;
string[] temp = FullName2.Split(' '); // boşluk karakterine parçala( dizi yap)
Console.WriteLine($"Hoş geldin {temp[0]}");

string aaaa = "ekrem,emre,ahmet";
string[] ogrenciler = aaaa.Split(',');

// Replace => metin içeirinde karakter değiştirir..
string metin = "ekrem yıldırım";
metin = metin.Replace("ı", "i");

// METOTLAR KONUSA GİRİYORUZ..