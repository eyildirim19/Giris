//int[] sayilar = new int[3];
//sayilar[0] = 10;
//sayilar[1] = 20;
//sayilar[2] = 30;

int[] sayilar = { 10, 20, 30, 1, 4, 2 }; // 3 elemanlı sayılar dizisi
string[] kisiler = { "nur", "sümeyye", "kaan", "emre" };
char[] ka = { 'e', 'k', 'r', 'e', 'm' };

int a = 11, b = 6, c = 20, d = 30, e = 2;
int[] nums = { a, b, c, d, e };
int min = nums[0], max = nums[0]; // 11

foreach (int num in nums)
{
    if (num > max)
    {
        max = num;
    }

    if (num < min)
    {
        min = num;
    }
}

Console.WriteLine($"min = {min} & max = {max}");