
// 2)
// Kullanıcıadı ve şifre istenecek, kullanıcı adı admin ve şifre 123 ise hoş geldin admin mesajı verilip döngü bir daha dönemeyecek şekilde sonlandırılacak. 
// Eğer kullanıcıadı veya şifre yanlış ise kullanıcıya bilgileriniz yanlış mesajı verilecek. Kullanıcı bilgileri en fazla 3 kez hatalı girebilecek. Eğer 3'kezde hatalı girerse hesabınız bloke oldu mesajı verilip yine döngü sonlandırılacak..

string kadi, sifre;
int eCount = 3;
do
{
    Console.WriteLine("Kullanıcı adı giriniz");
    kadi = Console.ReadLine();

    Console.WriteLine("Şifre giriniz");
    sifre = Console.ReadLine();

    //if ((kadi == "admin" || kadi == "ADMİN") && sifre == "123")
    if (kadi.ToUpper() == "ADMİN" && sifre == "123")
    {
        Console.WriteLine("Hoş geldin admin");
        break;
    }
    else
    {
        Console.WriteLine($"Bilgiler hatalı. Kalan hakkınız {--eCount}");
    }
} while (eCount > 0);


Console.WriteLine("BLA BLA....");