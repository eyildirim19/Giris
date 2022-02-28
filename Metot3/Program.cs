class Program
{

    static void Main(string[] args)
    {
        string cumle = "bu gün hava çok güzel arkadaşlar ile pinkik yapmaya gittik orada kavak ağaçları vardı çıkmadan önce elbiselerime ütü yaptım";
        string[] palindroms = new string[0];
        // todo: isPalindrome metodu ile cümle içerisindeki palindrome kelimleri bulup palindroms dizine ekleyen programı yazınız...

        string[] kelimler = cumle.Split(' '); // boşluklara göre metni parçala ve diziye ata...
        foreach (var item in kelimler)
        {
            if (IsPalindrome(item))  //if (IsPalindrome(item) == true)
            {
                Array.Resize(ref palindroms, palindroms.Length + 1);
                palindroms[palindroms.Length - 1] = item;
            }
        }
        // todo listler view menüsü altında task listlerde bulunur...
        // palindrome kelimleri yazdıralım...
        foreach (var item in palindroms)
        {
            Console.WriteLine(item);
        }
    }
    static bool IsPalindrome(string kelime)
    {
        // eğer kelime palindromesa isp true, değilse false atanmalı
        int b = 0;
        int s = kelime.Length - 1;
        while (b < s)
            if (kelime[b++] != kelime[s--])
                return false;

        return true; // ispi dön.
    }
    static bool IsPalindromeV2(string kelime)
    {
        char[] chars = kelime.ToCharArray();
        Array.Reverse(chars);
        string revers = new string(chars); // chars'tan string oluştur...
        if (kelime == revers)
            return true;

        return false;
    }
}