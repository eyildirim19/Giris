class Program
{
    static void Main(string[] args)
    {
        double sayi1, sayi2, sonuc;
        Console.WriteLine("1. Sayıyı Gir");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2. Sayı Gir");
        sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, /, *)");
        char islem = Console.ReadLine()[0]; // girilen ilk karakteri al...
        sonuc = Hesapla(islem, sayi1, sayi2);
        Console.WriteLine($"işlem sonucu = {sonuc}");
    }

    static double Hesapla(char islem, double s1, double s2)
    {
        if (islem == '+')
            return s1 + s2;
        else if (islem == '-')
            return s1 - s2;
        else if (islem == '*')
            return s1 * s2;
        else if (islem == '/')
            return s1 / s2;
        else
            return 0;
    }
}