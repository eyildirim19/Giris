byte b = 200;
int a;

a = b;

// Type Casting (dönüşüm)
// tipler eşit olmalıdır...

// 1 ) implicit  (kapalı dönüşüm) otomatik dnüşümdür. küçük tipin büyük tipe atanma işlemedir..
// byte > short > int > long > float > decimal > double

short s = b;
a = s;

// 2 ) explicit
// açık dönüşüm büyüğün küçüğe dönüşümüdür...
float f = 100;
int i = 100;
byte j = (byte)i; // casting
i = (int)f;

Console.WriteLine(j);
Console.WriteLine(i);

// Not : Type casting dikkatli kullanılması gerekir. Eğer değer cast edilen tip değer aralığında büyükse veri kaybı yaşanır....

sbyte sb;
int k = 257;
byte l = (byte)k;

Console.WriteLine(k); // normal hali
Console.WriteLine(l); // dönüştürülmüş hali 

l = 128;
sb = (sbyte)l;
Console.WriteLine(l); // normal hali 
Console.WriteLine(sb); // dönüştürülmüş hali

k = 515;
l = (byte)k;

Console.WriteLine(k); // normal hali
Console.WriteLine(l);// dönüştürülmüş hali

string ad = "1";
//k = (int)ad; dönüşüm işlemi geçersizdir...tiplerin ortak bir yanı yoktur...