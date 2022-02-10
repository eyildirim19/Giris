
// Klavyaden a tuşuna basana kadar kullanıcıdan harf isteyen program...

string str = "";
while (str != "a")
{
    Console.WriteLine("Lütfen birşeyler yaz...");
    str = Console.ReadLine(); // a
}

string parola = "";
while (str != "şafak")
{
    Console.WriteLine("Parola Nedir??????");
    parola = Console.ReadLine(); // a
}

// 1'den 100 kadar n adet sayının toplamı...
Console.WriteLine("kaç adet sayı giriyorsun...");
int n = Convert.ToInt32(Console.ReadLine());

int gToplam = 0;
int j = 0;
while (j < n)
{
    Console.WriteLine($"{j + 1} . sayıyı giriniz");
    int girilenSayi = Convert.ToInt32(Console.ReadLine()); // 50

    if (girilenSayi >= 0 && girilenSayi <= 100)
    {
        gToplam += girilenSayi;
        j++; // j sadece girilen sayı belirtilen aralıkta ise o zaman arttırılır. Diğer ihtimalde j arttrılmayacağı için döngü tekrar dönecektir. Bu sayede kullanıcı doğru değer(leri) girene kadar kullanıdan sayı istenecektir...
    }
}


Console.WriteLine($"Girilen Sayıların Toplamı = {gToplam}");

// 1) 
// N adet öğrencinin vize final notu istenecek..
// vize ve finalden n öğrencinin ortalama hesaplanacak
// n adet öğrenciden En büyük ve En düşük ortalamıy notu ekrana yazdırınız..
// Sınıf ortalamasını ekrana yazdırınız...


// 2)
// Kullanıcı ve şifre istenecek, kullanıcı adı admin ve şifre 123 ise hoş geldin admin mesajı verilip döngü bir daha dönemeyecek şekilde sonlandırılacak. Not : öğrettiklerim dışında birşey kullanmayın...
// Eğer kullanıcıadı veya şifre yanlış ise kullanıcıya bilgileriniz yanlış mesajı verilecek. Kullanıcı bilgileri en fazla 3 kez hatalı girebilecek. Eğer 3'kezde hatalı girerse hesabınız bloke oldu mesajı verilip yine döngü sonlandırılacak..