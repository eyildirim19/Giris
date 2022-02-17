// Array Metotları => diziler üzerinde işlem yapmamızı sağlayan, bir çok problemde algoritma kurmadan sonuca ulaşmamızı sağlayan program paçalarıdır..

int[] nums = { 51, 6, 2, 11, 4, 43 };

Console.WriteLine($"dizin en büyüğü {nums.Max()}");
Console.WriteLine($"dizinin en küçüğü {nums.Min()}");
Console.WriteLine($"dizin ortalaması {nums.Average()}");
Console.WriteLine($"dizin toplamı {nums.Sum()}");


// Ayrıca diziler için Array sınıfının metotlarıda kullanılır..
Array.Sort(nums); // diziyi a-z sıralar...
foreach (int i in nums)
    Console.WriteLine(i);

Array.Reverse(nums); // diziyi terst çevirir


string[] names = { "ekrem", "recep", "kaan" };
// IndexOf => dizide arama işlemi yapar. Eğer aranan eleman dizide varsa index numarasını döner. Eğer eleman dizide yoksa -1 döner..
int result = Array.IndexOf(names, "kaan"); // kaan 2. indexte olduğu içn result'a 2 set eder..
int result2 = Array.IndexOf(names, "sümeyye"); // sümeyye elemanı dizide olmadığı için -1 döner...

// örnek1
char[] chars = new char[3];
chars[0] = 'A';
chars[1] = 'B';
chars[2] = 'C';
//chars[3] = 'D'; atama yapılamaz çünkü dizi 3 elemanlıdır. en büyük index 2 dir

char[] temp = chars; // charsı temp'e ata..
chars = new char[4]; // yeni 4 elemanı referans oluştur
for (int i = 0; i < temp.Length; i++) // eskiside dön. 
    chars[i] = temp[i]; //ilgili elemanı ilgili indexe ata..


chars[3] = 'D';
foreach (char cc in chars)
    Console.WriteLine(cc);

// örnek2
char[] karakter = new char[4];
karakter[0] = 'e';
karakter[1] = 'k';
karakter[2] = 'r';
karakter[3] = 'e';

//karakter = new char[5]; // eski refaransı kaybeymemek için new ifadesini kullanmıyoruz..
Array.Resize(ref karakter, 5); // burada ki ref ifadesi karakter dizisinin referansını ifader. mevcut referans korunarak dizinin uzunluğu 5 yapılır

karakter[4] = 'm';
foreach (char ck in karakter)
    Console.WriteLine(ck);

string[] kisiler = { "ekrem", "emre", "recep" }; // dizinin uzunluğu 3
Array.Resize(ref kisiler, 2); // yeni uzunluk 2... 2. elemandan sonrası gider...

// ekrem ile emrenin yerini değiştirelim
Array.Reverse(kisiler); // diziyi ters çevirelim...
foreach (string k in kisiler)
    Console.WriteLine(k);

Console.WriteLine("selam");


// anonim tip(anonymous types) => belirsiz tipler. tip değer atandığında oluşur. anonim tip kullanmak için değer atanması zorunludur..

int z = 1;
string s = "deneme";
var a = "deneme"; // anonim a değişkeni. değer atandığı a'nınd değeri string oldu..
var b = 1; // int
var c = false;// bool
var d = 'D'; // char
var e = 3.1;// double
var f = 3.1f; // float
var ogrencis = new string[] { "Recep", "Bilal", "NUr", "Sümeyye" }; // string dizisi
var numbers = new int[] { 10, 20, 30, 40 }; // int dizisi..

// Not : anonim tipler ileride anlık tipler oluşturmak zorunda kaldığımızda hayat kurtarır. Genelde böyle işler için tercih edilir...
foreach (var item in kisiler)
    Console.WriteLine(item);

foreach (var item in chars)
    Console.WriteLine(item);

foreach (var item in nums)
    Console.WriteLine(item);
