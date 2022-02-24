class Program
{
    static void Main()
    {
        // iki sayının toplamını veren metot
        int a = 1, b = 4;
        int sonuc = Topla(a, b); // topla ve dönen değeri sonuca ata...
        int sonuc2 = Topla(sonuc, 1);
        int sonuc3 = Topla(Topla(1, 1), 2); // 4

        int[] numbers = { 4, 1, 3, 2 };
        int result = Topla(numbers);
        //int k = Topla(1); => 1'in tipi dizi olmadığı için hata verir.. tek int parametresi alan metodumuz yok...
        Console.WriteLine($"İşlem sonucu {sonuc}");
        Console.WriteLine($"İşlem sonucu {sonuc2}");
        Console.WriteLine($"İşlem sonucu {sonuc3}");
        Console.WriteLine($"dizinin toplamı {result}");

        int buyuk = Karsilastir(3, 5);
        Console.WriteLine($"Sayıların büyüğü {buyuk}");

        buyuk = Karsilastir(sonuc, sonuc3);
        Console.WriteLine($"Sayıların büyüğü {buyuk}");
    }
    static int Karsilastir(int s1, int s2)
    {
        int enb;
        if (s1 > s2)
            enb = s1;
        else
            enb = s2;
        return enb;
    }
    static int Topla(int s1, int s2)
    {
        return s1 + s2;
    }

    static int Topla(int[] nums)
    {
        return nums.Sum();
    }
}