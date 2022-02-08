/*
     Switch Case yapısı => daha sade ifadler(koşullar) yazmak için kullanılır..
     
    switch(deger){
        case sabitdeger1:
            <kosulluKod>
        break;
        case sabitdeger2:
            <kosulluKod>
        break;
        case sabitdeger3:
            <kosulluKod>
        break;
        default:
        break;
    }
    deger sabitdegerler ile karşılaştırılır. hangi sabitdegere eşitse o case bloğu çalışır...casedeki koşullu kod sonrasında break ifadesi ile switch sonlandırılır...eğer deger sabitdegerlere eşit değilse default(else) bloğu çalışır...

 */

int a = 5;
switch (a)
{
    case 1:
        Console.WriteLine("bir");
        break;
    case 2:
        Console.WriteLine("iki");
        break;
    case 4:
        Console.WriteLine("dört");
        break;
    default:
        Console.WriteLine("caselerden birisi değil");
        break;
}


// a ile 5 karşılaştırılır eğer a'ten küçükse if bloğu çalışır

a = 3;
// if ile
if (a > 5)
{
    Console.WriteLine("a büyük 5'ten");
}
else
{
    Console.WriteLine("a küçük 5'ten");
}

bool b = a > 5;
// switch ile
//switch (b)
switch (a > 5)
{
    case true:
        Console.WriteLine("a büyük 5'ten");
        break;
    case false:
        Console.WriteLine("a küçük 5'ten");
        break;
}

Console.WriteLine("Harf notunu giriniz size taban puan verelim");

string harfNotu = Console.ReadLine();
int not = 0;
switch (harfNotu)
{
    case "AA":
        not = 85;
        break;
    case "BA":
        not = 75;
        break;
    case "BB":
        not = 65;
        break;
    case "CC":
        not = 55;
        break;
    case "DC":
        not = 40;
        break;
    //case "DC":  // not : case'ler unique(benzersiz) olmalıdır
    //    not = 25;
    //    break;
    case "DD":
        not = 25;
        break;
}
//Console.WriteLine("BB notunun taban puanı 65");
//Console.WriteLine("65 taban puanı BB harf notunun karşılığıdır");
// metin birleştirme 1. yol
//Console.WriteLine(harfNotu + " notunun taban puanı " + not);
//Console.WriteLine(not + " taban puanı " + harfNotu + " harft notunun karşılığıdr");
// $ stringe dışarıdan parametre (değer) verileceğiniz, { }  ise parametreleri(deger) ifade eder...
// metin birleştirme 2. yol 
Console.WriteLine($"{harfNotu} notunun taban puan {not}");
Console.WriteLine($"{not} taban puanı { harfNotu} harf notunun karşılığıdır");


