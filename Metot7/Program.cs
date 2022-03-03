class Program
{
    static void Main()
    {
        // dizinin toplam ve ortalamasını veren metot...
        int[] sayilar = { 5, 6, 2, 1, 8, 9 };

        double ort;
        int toplam = ToplamVeOrtalama(sayilar, out ort);
        Console.WriteLine($"Toplam= {toplam}, ortalama= {ort}");

        int min, max;
        min = MinveMax(sayilar, out max);
        Console.WriteLine($"dizinin mininum değeri {min} maximum değeri {max}");


        // a'nın ve b'nin  a[n] > b[n] elemanını karşılaştırıp büyük elemanlardan oluşan yeni bir dizi oluşturunuz...
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] b = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] buyukler = new int[0];
        for (int i = 0; i < 9; i++)
        {
            int enb = 0;
            // uygun metodu yazınız ve burada çağırınız...(iki diziin i. ci elemanını karşılaşturan ve enb değişkenine atayan metodu)
            enb = Karsilastir(a[i], b[i]);

            Array.Resize(ref buyukler, i + 1);
            buyukler[i] = enb;
        }

        foreach (var item in buyukler)
            Console.WriteLine(item);


        // nums dizisi içerisindeki elamanları benzersiz yeni bir diziye eklenecek, adetleri yeni bir diziyi eklenecek...



        int[] nums = { 1, 2, 2, 3, 3, 3, 4, 5, 8, 8, 8, 8 };
        // {1,2,3,4,5,8}
        // {1,2,3,1,1,4}
        int[] uniqueNums = new int[0]; // dizideki benzersiz elemanlar burada tutulsun
        int[] numsCount = new int[0]; // dizideki benzer elemanların adeti burada tutulsun

        for (int i = 0; i < nums.Length; i++) // dizi'yi açıyoruz...
        {
            //uygun kodu yazınız....
            int item = nums[i]; // sıradaki eleman...

            if (Array.IndexOf(uniqueNums, item) > -1) // sıradaki eleman unique dizimizde var mı?.Eğer varsa -1 büyük dön;
                continue; // sonraki eleman geç...

            // int adet = ElemanAdet(nums, item); // item nums dizisinde kaç tane? bul ve numscount'in i. ci ata...
            int adet = ElemanAdetV2(nums, item);
            Array.Resize(ref uniqueNums, uniqueNums.Length + 1); // dizide yeni alan aç
            Array.Resize(ref numsCount, numsCount.Length + 1); // dizide yeni alana aç

            uniqueNums[uniqueNums.Length - 1] = item; // elamnı benzersiz diye ata..
            numsCount[numsCount.Length - 1] = adet; // elemanın adetini count dizisine at..
        }

        for (int i = 0; i < uniqueNums.Length; i++)
        {
            Console.WriteLine($"{uniqueNums[i]} elemanından {numsCount[i]} adet var...");
        }


        int[] sirasizlar = { 100, 5, 50, 2, 10, 99, 8, 4, 2 };
        int[] siralanmis = Sirala(sirasizlar); // sırasızlar dizinin siralanmış halini siralnamış dizisine atar...
        foreach (var item in siralanmis)
        {
            Console.WriteLine(item);
        }

        //
        char[] harfler = { 'A', 'B', 'C', 'd', 'E', 'z', 'P', 'U', 'K', 'n' };
        char[] bHarfler = new char[0];
        foreach (var item in harfler)
        {
            if (!IsBuyuk(item))
                continue;

            Array.Resize(ref bHarfler, bHarfler.Length + 1);
            bHarfler[bHarfler.Length - 1] = item;
        }

        char[] bHarfler2 = new char[0];
        foreach (var item in harfler)
        {
            char temp = char.ToLower(item); // küçük harfe çevir... // d

            if (item == temp) // d = d
                continue;

            Array.Resize(ref bHarfler2, bHarfler2.Length + 1);
            bHarfler2[bHarfler2.Length - 1] = item;
        }

    }
    // A (65) B(66) C(67).......Z(90)
    static bool IsBuyuk(char c)
    {
        // (int)c => char'in sayısal karşılığını alalım..
        int k = (int)c;
        if (k >= 65 && k <= 90)
            return true;
        else
            return false;
    }

    // todo: char[] harfler ={'A','B','C','d','E',z,P,U,K,n} harfler dizinindeki büyük harfleri yeni bir diziye ekleyiniz...beklediğimiz dizi yeniHarfler = {'A','B','C','E','P','U','K'} => ipucu büyük harfleri bulurken ascii code karşılığını kullanabilirsiniz....
    // ascii table araştırınız...
    // PERŞEMBE GÜNÜ OOP KONUSUNA BAŞLIYORUZ.. (ARAŞTINIZ...)

    static int[] Sirala(int[] arr)
    {
        int[] sirali = new int[0];
        // todo: karışık elemanlı arr dizisini sıralı bir şekilde sirali dizisine ekleyerek dönünüz.. Bu işlemi yaparken bubble sort algoritmasını kulllanınız...
        // izleyiniz..https://www.youtube.com/watch?v=semGJAJ7i74&list=PLOmdoKois7_FK-ySGwHBkltzB11snW7KQ&index=2

        return sirali;
    }

    static int BinarySearch(int[] arr, int eleman)
    {
        int counter = 0;
        //todo : Binary Search algoritması ile aranan elemanın adetini bulunur...
        // 8

        // A=  1,2,2,3,3,3
        // B = 4,5,8,8,8,8

        // 8
        // 1,2,2,3,3,3,4,5,8,8,8,8
        return counter;
    }

    static int ElemanAdetV2(int[] arr, int eleman)
    {
        int counter = 0;
        int index = Array.IndexOf(arr, eleman);  // eleman varsa indexi'ini döner, yoksa -1 döner..
        while (index > -1)
        {
            counter++;
            // startIndex parametresi ile dizinin belirlenen indexinde arama yapılır...
            index = Array.IndexOf(arr, eleman, index + 1); // bulnan indexden sonra  
        }
        return counter;
    }
    static int ElemanAdet(int[] arr, int eleman)// aranaca dizi, aranacak elemean...
    {
        // todo: Bu bölümü Array sınıfının indexOf metodunu kullarak yapınız.. 01.03.2022
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
            if (eleman == arr[i])  // eleman dizinin i. eşit mi  
                count++; // adeti 1 arttır
        return count;
    }

    static int Karsilastir(int sayi1, int sayi2)
    {
        if (sayi1 > sayi2)
            return sayi1;
        else
            return sayi2;
    }


    static int ToplamVeOrtalama(int[] arr, out double ortalama)
    {
        ortalama = arr.Average();
        return arr.Sum(); // 
    }
    static int MinveMax(int[] arr, out int max)
    {
        max = arr.Max();
        return arr.Min();
    }
    // return, break ve continue ifadelerinin ortak özelliği alt satırındaki kommutları çalıştırmamasıdır..
    // continue => sadece döngü içeriisnde kullanılır...döngüde bir sonraki adıma geçer..
    // break => sadece switch ve döngülerde kullanılabilir...bulunduğu scope'tan çıkar...
    // return istenilen heryerde kullanılır. return metottan çıkar...
}