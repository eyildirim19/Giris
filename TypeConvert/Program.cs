// github araştırınız ve hesap açınız..

/*
 Convert => farklı tiplerin birbirine dönüşümüdür... 
 veri formatı uygun formatta olmalıdır
 */

string s = "10";
byte say1 = Convert.ToByte(s); // byte çevir...
int say2 = Convert.ToInt32(s); // inte çevir...

Console.WriteLine(1 + say1);

// tip adı  Dönüşüm metodu
// short    Convert.ToInt16 
// int      Convert.ToInt32
// long     Convert.ToInt64
// float    Convert.ToSingle
// bool     Convert.ToBoolean
// byte     Convert.ToByte
// string   Convert.ToString

int a = 300;
byte b = (byte)a;


byte t = Convert.ToByte(a);  // a'yı byte dönüştür çalışma zamanı hatası verir..çünkü a'nın değeri byte için büyüktür...

//byte bt = Convert.ToByte("aaa"); // aaaa değerini byte dönüştürürken runtime exception alır çünkü aaaa değeri format olarak satır değildir..
int d = Convert.ToInt32("22");
bool durum = Convert.ToBoolean("false");
Console.WriteLine(d);
Console.WriteLine(durum);
