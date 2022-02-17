string[] vs = { "BT AKADEMİ", "C#" };

// elemanların yeri değişsin..
// tek bir değişken ile 

string temp = vs[0]; //BT AKADEMİ
vs[0] = vs[1];
vs[1] = temp;

// EKRANA C# BT AKADEMİ GELECEK ŞEKİLDE YAZDIRALIM.
foreach (string v in vs)
    Console.WriteLine(v);

int a = 3;
int b = 2;

int c = a; // 3
a = b; // 2
b = c; // 3

// beklediğim çıktıyı 3 bir değişken kullanmadan yapınız...

Console.WriteLine($"a'nın değeri {a}"); // 2
Console.WriteLine($"b'nin değeri {b}"); // 3

/*
 *    ___
   0 | A  |
     -----
   1 | B  |
     ______
 */