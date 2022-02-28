class Program
{
    static void Main(string[] args)
    {
        int a = Topla(1, 2);
        int[] nums = { 11, 5, 1 };
        int b = Topla(nums);
        int c = Topla2(1, 2, 4, 10, 50, 30, 40, 20);

        string[] kisiler = { "ekrem", "emre" };
        KisiYazdir(kisiler);
        KisiYazdir("recep", "bilal", "ahmet");
    }
    static int Topla(int s1, int s2)
    {
        int result = s1 + s2;
        return result;
    }
    static int Topla(int[] numbers)
    {
        int result = numbers.Sum();
        return result;
    }
    // params ifadesi => dizi tipinde parametre almamızı sağlar. tek fark argumanlar , ile gönderilir... birden fazla aynı tipte parametre göndermek istedindiğinde kullanılır...

    // n adet parametre göndermek için kullanılır...
    static int Topla2(params int[] numbers)
    {
        int result = numbers.Sum();
        return result;
    }
    static void KisiYazdir(params string[] items)
    {
        foreach (var item in items)
            Console.WriteLine(item);
    }
}