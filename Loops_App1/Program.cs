Console.WriteLine("Hangi Mesajı Vermek İstersin???");
string mesaj = Console.ReadLine();

Console.WriteLine("Kaç Defa Yazdıralım???");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    //Console.WriteLine( (i + 1) + mesaj);
    Console.WriteLine($"{i + 1} . {mesaj}");
}

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// 10'dan 1'e kadar olan sayıları ekrana yazdırınız...
for (int j = 10; j > 0; j--)
{
    Console.WriteLine(j);
}

int s1 = 4;
//s1 = s1 + 1;
s1++; // bir arttır
int a = s1++; // ata ve arttır

Console.WriteLine($"a = {a} s1 = {s1}");

int b = 2;
int c = 2 + b++;
Console.WriteLine($"c = {c} b = {b}");

int k = 10;
while (k > 0)
    Console.WriteLine(k--);

Console.WriteLine("*****************************");


for (string az = "A"; az != "z"; az = "z")
{
    Console.WriteLine("en saçma bir döngüyüm....");
}

string za = "A";
while (za != "z")
{
    Console.WriteLine("en saçma bir döngüyüm....");
    za = "z";
}



// ASCII TABLE => 0- 255 arası her bir sayının karakter karşılığı vardır. A

// \n => new line
// \t => tab

//https://www.asciitable.com/

// sayısal bir değer char'a dönüştürüldüğünde asciitable'daki karakter karşılığına dönüştürülür....

for (int ascii = 0; ascii < 255; ascii++)
{
    Console.Write(Convert.ToChar(ascii));
}

for (char i = 'A'; i < 'Z'; i++)
{
    Console.Write($"{i} \t");
}