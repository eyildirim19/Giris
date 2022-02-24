class Program
{

    static void Main(string[] args)
    {
        string cumle = "bu gün hava çok güzel arkadaşlar ile pinkik yapmaya gittik orada kavak ağaçları vardı çıkmadan önce elbiselerime ütü yaptım";

        string[] palindroms = new string[0];
        // todo: isPalindrome metodu ile cümle içerisindeki palindrome kelimleri bulup palindroms dizine ekleyen programı yazınız...


        // todo listler view menüsü altında task listlerde bulunur...


        // palindrome kelimleri yazdıralım...
        foreach (var item in palindroms)
        {
            Console.WriteLine(item);
        }
    }

    static bool IsPalindrome(string kelime)
    {
        bool isp = true; // geçici true değeri verdik. 

        // eğer kelime palindromesa isp true, değilse false atanmalı

        return isp; // ispi dön.
    }
}