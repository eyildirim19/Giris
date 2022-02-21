Console.WriteLine("Bu uygulama girilen sayıların toplam ve ortalama değerlerini verir. Sende oynamk istermisin? (E/H");
string cevap = Console.ReadLine();

int[] nums = new int[0];

while (cevap.ToUpper() == "E")
{
    Console.WriteLine("Lütfen sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    Array.Resize(ref nums, nums.Length + 1); // uzunluğuna + 1 ekle...
    nums[nums.Length - 1] = sayi;

    Console.WriteLine("Tekrar eklemek istermisin???");
    cevap = Console.ReadLine();
}

Console.WriteLine($"Girilen sayıların toplamı = {nums.Sum()}");

if (nums.Length > 0)
    Console.WriteLine($"Girilen sayıların ortalaması = {nums.Average()}"); // Average eleman sayısı 0 olduğu zaman hata veriyor. 
