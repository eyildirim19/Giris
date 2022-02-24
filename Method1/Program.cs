class Program // class konusuna oop gireceğiz...
{
    // static konusu class yapılında ve static üyelerde işlenecek 
    // Main => ana program...
    // .net 6'dan önce console uygulamalarında bu yapı hazır gelirdi bizlerde kodlarımızı main içerisine yazardık.. bu yapıyı manuel oluşturduk...
    static void Main(string[] arg)
    {
        #region tanim

        // METOD => belirli bir isim altında toplanmış kod parçacıklarıdır(belirli bir işi yapmak için bir araya getirilmiş kod blokları).. metotlar uygulamayı modüllere bölmek için kullanılır.. Program içerisinde işleri parçalamak ve daha kolay yönetmek için kullanılır..

        // uygulama içierisinde kullandığımız komutları farklı yerlerde de kullanmak isteyebiliriz. gidip farklı yerlede kod tekrarı yapmaktansa birkere yazıp bunu sürekli kullanmayı tercih ederiz...



        // Metotlar önce tanımlanır. metotları kullanmak için çağrılması gerekir..Örneğin bizler ön tanımla metotları kullanmak çağrırırz..
        int a = Convert.ToInt32("2");
        int[] nums = new[] { 1, 7, 3, 6, 2 };
        Array.Sort(nums); // berlitilen diziyi sırala...

        /*
            <erisimSevisiye> <donusTipi> <MetotAdi>()
            {
                    <metotGovdesi>
            }
            erisimSeviyesi => metoda nereden erişlecek? (detaylarına oop konusunda değinilecektir..) private,protected,internal, protected internal, public. şimdilik private ile devam ediyoruz...
            donusTipi => metot işini bitirdikten sonra doneceği değer
            metotAdi => alt programın adı
            metotGovdesi => yapılacak iş(kodlar)

           metotlar ile 2 tip dönüş yapılabilir. iş bittikten sonra boş dönen metotlar ve dolu (değer) metotlardır.
        Bir metot eğer geriye değer dönmeyecekse dönüş tipi void olarak belirlenir..eğer değer dönecekse dönüş tipi bilgiğimiz tiplerden birisi olarak belirlenir.. 
        // dönüş tipimiz void => metot boş dönecek
        private void MyMetot()
        {
        }
        Not : metot dönüş tipimiz eğer void değilse metodun gövdesinde return ifadesi ile değer dönmek zorunludur...Donecek değer donustipi ile aynı olmak zorundadır...
        // dönüş tipimiz int.
        private int Topla()
        {
            return 1;
        }     

        metotlar parametre alabilen varlıklardır. Parametre => metot govdesine metot dışından değer geçirmek için kullanılır.. Örneğin Sort,Reverse, ToInt32, Split,WriteLine gibi metotlara parametre gönderilir ve buna göre işlem yapılır.
         */
        Console.WriteLine("test");
        #endregion

        Console.WriteLine("Selam");

        MesajVer();
        MesajVer();

        // parametre değerlerine arguman denir..
        Mesaj("Recep");
        Mesaj("Emre");
        string name = "Kaan";
        Mesaj(name);

        Mesaj2("Merhaba", "Ahmet");
        Mesaj2("Hello", "Nur");
        Mesaj2("Selam", "Alper");

        Message();
        Message("Ahmet");
        Message("Bilal");
        Message("Selam", "Recep");
        Message("Hello", "Kaan");
        Message("Naber", "Emre");
        //Message("Selam", "Bilal", "Nasılsın"); 3 argümanlı metot tanımlı olmadığı için hata alırsınız...
    }

    private static void MesajVer()
    {
        Console.WriteLine("Merhaba ben metot");
    }
    private static void Mesaj(string isim) // msj string tipinde Mesaj metodumuzun parametresdir.. parametre metot dışında metoda değer göndermedir...
    {
        Console.WriteLine($"Merhaba {isim}");
    }
    private static void Mesaj2(string msj, string isim)
    {
        Console.WriteLine($"{msj} {isim}");
    }
    // c# dilinde varlık isimleri unique (benzersiz) olmalıdır..Metotlarda ise bu durum farklıdır. metotlarda aynı isimler kullanılabilir.Örnek Convert.ToInt32 metodunda f12 ile detayına giderek görebilirsiniz.. Bu yapıya metot overload (aşırı yükleme) denir...
    // metot overload => aynı isimdeki metotların farklı parametreler (tipler) ile tanımlanmasıdır.. aynı modülün farklı versiyonlarını yazmak için kullanılır.. Overloadda sadece paremetreler farklı olabilir..
    private static void Message()
    {
        Console.WriteLine("Merhaba ben metot");
    }
    private static void Message(string name)
    {
        Console.WriteLine($"Merhaba {name}");
    }
    private static void Message(string msj, string name)
    {
        Console.WriteLine($"{msj} {name}");
    }
}