


/*
 *  LOOPS (DÖNGÜLER) => kod satırlarını tekrar çalıştırmak için kullanılan yapılara denir... bir döngünün çalışabilmesi için bir koşulun olması birde koşullu kodun olması gerekir...
 *  c# dilinde 4 adet döngü vardır. Bunlar;
 * 1) for
 * 2) while
 * 3) do while 
 * diziler konusunda inceleyeceğimiz;
 * 4) foreach
 */

/*
    i++ ifadesi i = i + 1'in kısatmasıdır...
 */
// for adımlar;
//1) başlangıç değeri belirlenir;
//2) koşula bakılır
//3) koşullu komut çalıştırılır
//4) artım işlemi yapılır
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Introductionı C# ile öğreniyoruz..");
}
int j = 0;
while (j < 3)
{
    Console.WriteLine("Introductionı C# ile öğreniyoruz..");
    j++;
}
// Do while => diğer iki döngünün aksine önce işlem yapılır sonra koşula bakılır.. Çok tercih edilen bir döngü değildir...
int k = 0;
do
{
    Console.WriteLine("Introduction C# ile öğreniyoruz...");
    k++;
} while (k < 3);