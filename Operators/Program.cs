
// Operatorler;

//  = atama operatörü, sağdaki değeri sola atar...
int a = 3;

// atama opetörülerinde kural sağdak tip ile soldaki tip birbirine eşit olmalıdır

//int b = "1";  değerin tipi string olduğu için int tipindeeki bir değişkene atanamaz...
byte b = 1;
int c = b; // b tipi int tipi ile ortak olduğu için bu atama işlemi yapılabilir..

// aritmatic operatörler;
int sonuc = 3 + 4; // toplama operatörü
Console.WriteLine(sonuc);

sonuc = sonuc + 5; // değişkeni kendisiyle topluyorsun...
sonuc += 5; // topla ve ata....bir üst satırın kısa yoludur.....

sonuc = 3 * 4;
sonuc = sonuc * 5;
sonuc *= 5;

Console.WriteLine(sonuc);


sonuc = 3 - 1;
sonuc -= 1;

Console.WriteLine(sonuc);

sonuc = 3 / 1;
sonuc /= 1;
Console.WriteLine(sonuc);


// karşılaştırma operatörleri.... iki değeri karşılaştırmak için kullanılır...

Console.WriteLine(3 > 1);
Console.WriteLine(3 < 1);

int i = 1, j = 4;
Console.WriteLine(i > j); // false
bool snc = i > j; // false
Console.WriteLine(snc);

Console.WriteLine(i >= j); // büyükeşit operatörü
Console.WriteLine(i <= 1);

// eğişlik
Console.WriteLine(i == j); // i j'ye eşitmi // false
Console.WriteLine("a" == "b"); // false
Console.WriteLine('b' == 'd'); // false
Console.WriteLine("ekrem" == "ekrem"); // true

// eşit değil
Console.WriteLine(i != j); //true
Console.WriteLine("a" != "b");// true
Console.WriteLine('b' != 'd'); // true
Console.WriteLine("ekrem" != "ekrem"); // false

int z = 1;
string s = "1";
//bool d = z == s;  // tipler birbirine eşit olmadığı için karşılaştırma yapılamaz....

// mantıksal operatörler // birden fazla değeri karşılaştırmak için kullanılır
// karşılaştırmalardan ikisininde true olması gerekir...
// mantıksal ve (and) && (shift + 6)
int k = 1, l = 5, m = 3;
bool durum = k < l && k < m;
durum = "a" == "a" && "b" == "d";// false
durum = "a" == "a" && "b" != "d"; // true
durum = "1" == s && k == l; // false

// veya (or) operatörü
// karşılaştırmalardan birisinin true olması yeterlidir... 
durum = k < l || k < m;
durum = "a" == "b" || "b" == "d";// false
durum = "a" == "a" || "b" != "d"; // true
durum = "1" == s || k == l; // true