// girilen harf sesli mi değil mi???

// Char.ToUpper(c) // c'nin değerini Büyüğe çevirir
// Char.ToLower(c) // c'nin değerini küçüğe çevirir
Console.WriteLine(char.ToUpper('a'));
Console.WriteLine(char.ToLower('A'));

Console.WriteLine("Bir harf giriniz");
char c = Convert.ToChar(Console.ReadLine());

//if (Char.ToUpper(c) == 'A')
//if (Char.ToLower(c) == 'a')
//if(c == 'a' || c== 'A')
if (Char.ToUpper(c) == 'A' || Char.ToUpper(c) == 'E' || Char.ToUpper(c) == 'I' || Char.ToUpper(c) == 'İ' || Char.ToUpper(c) == 'U' || Char.ToUpper(c) == 'Ü' || Char.ToUpper(c) == 'O' || Char.ToUpper(c) == 'Ö')
    Console.WriteLine("Sesli harf girdiniz");
else
    Console.WriteLine("Sessiz harf girdiniz");

Console.WriteLine("Switch ile .......");
// birden fazla case ifadesi tek bir koşullu kod için yazılabiir.. burada case'leri veya karşışaştırması gibi düşünebilirsiniz...
switch (Char.ToUpper(c))
{
    case 'A':
    case 'E':
    case 'I':
    case 'İ':
    case 'U':
    case 'Ü':
    case 'O':
    case 'Ö':
        Console.WriteLine("Sesli harf girdiniz");
        break;
    default:
        Console.WriteLine("Sessiz harf girdiniz");
        break;
}

// c'deki değer k değişkenine atanarak işlem yapılır.. 
// char k ifadesi char tipindeki k değişkenine c'nin değerini atar...
// case when yapısı...
switch (Char.ToUpper(c))
{
    case char k when k == 'A' || k == 'E' || k == 'I' || k == 'İ' || k == 'U' || k == 'Ü' || k == 'O' || k == 'Ö':
        Console.WriteLine("Sesli Harf Girdiniz");
        break;
    //case char k when k == 'U' || k == 'Ü' || k == 'O' || k == 'Ö':
    //    Console.WriteLine("Sesli Harf Girdiniz");
    //    break;
    default:
        Console.WriteLine("Sessiz harf girdiniz");
        break;
}