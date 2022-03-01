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

            int adet = ElemanAdet(nums, item); // item nums dizisinde kaç tane? bul ve numscount'in i. ci ata...
            Array.Resize(ref uniqueNums, uniqueNums.Length + 1); // dizide yeni alan aç
            Array.Resize(ref numsCount, numsCount.Length + 1); // dizide yeni alana aç

            uniqueNums[uniqueNums.Length - 1] = item; // elamnı benzersiz diye ata..
            numsCount[numsCount.Length - 1] = adet; // elemanın adetini count dizisine at..
        }

        for (int i = 0; i < uniqueNums.Length; i++)
        {
            Console.WriteLine($"{uniqueNums[i]} elemanından {numsCount[i]} adet var...");
        }
    }

    // todo: char[] harfler ={'A','B','C','d','E',z,P,U,K,n} harfler dizinindeki büyük harfleri yeni bir diziye ekleyiniz...beklediğimiz dizi yeniHarfler = {'A','B','C','E','P','U','K'} => ipucu büyük harfleri bulurken ascii code karşılığını kullanabilirsiniz....
    // ascii table araştırınız...
    // PERŞEMBE GÜNÜ OOP KONUSUNA BAŞLIYORUZ.. (ARAŞTINIZ...)

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