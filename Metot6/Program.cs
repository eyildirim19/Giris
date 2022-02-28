class Program
{
    static void Main()
    {
        string[] gelenStr = Str().Split(' ');
        string[] gelenStr2 = Strs();

        string aa, bb;
        Deneme(out aa, out bb);
        Console.WriteLine(aa, bb);


        int a;
        bool durum = int.TryParse("3", out a); // TryParse metodu => eğer dönüşüm yapabilirse out ile dönen değeri, return ilede işlemin başarılı olup olmadığını döner.. // durum true, a 3'tür...

        // birden fazla değer dönmeye TryParse metodu güzel bir örnektir..

        durum = int.TryParse("aa", out a); // durum = false , a 0'dır.

        // OOP konusunu araştırın...

        bool isConvert = false;
        int sayi1;
        do
        {
            Console.WriteLine("Lütfen bir sayı giriniz");

            isConvert = int.TryParse(Console.ReadLine(), out sayi1);
        } while (!isConvert); // isConvert==false demektir

        int kalan;
        int result = Hesap(5, 2, out kalan);
        Console.WriteLine($"Bölüm = {result}, Kalan = {kalan}");

        // metoda paremtrenin değerini değil referansı göndermek için kullanılır...

        string j = "a"; //  referans gönderilecğei için ref parametrelin değerleri olmak zorundadır..
        RefMetot(ref j);// j'yi referansı (bellekteki adresi) ile gönder...
        Console.WriteLine($" j'nin değeri {j}");

        string k = "demo";
        RefsizMetot(k);
        Console.WriteLine($"k'nin değeri {k}"); // demo
    }

    static int Hesap(int sayi1, int sayi2, out int sonuc)
    {
        sonuc = sayi1 % sayi2;// bölümden kalanı ver...
        return sayi1 / sayi2;
    }

    // ref ve out parameterler.. diziden birden fazla değer dönmek istedindiğinde kullanlır
    // out =>metodun gövdesinden metot dışında değer taşımak için kullanılır... (Not birden fazla değer dönmek durumunda kalındığında kullanılır)

    // ref => metota değer yerine referans gönderir..
    static void RefMetot(ref string a)
    {
        a = "bu gün günlerden metot parametre tipleri...";
    }

    static void RefsizMetot(string a)
    {
        a = "bu gün günlerden metot parametre tipleri";
    }
    static void Deneme(out string a, out string b)
    {
        // NOT : out parameterlera metot gövdesinden değer atamak zorundayız...
        a = "Ekrem";
        b = "Yıldırım";
    }

    // Not : metotlar geriye sadece tek değer dönerler...
    static void Denem()
    {
        return;
    }
    static string Str()
    {
        return "A B";
    }
    static string[] Strs()
    {
        //string[] vs = new string[2];
        //vs[0] = "A";
        //vs[1] = "B";
        //return vs;
        return new string[] { "A", "B" };
    }
    static int ABC()
    {
        return 1;
    }
    static char Ch()
    {
        return 'A';
    }
}