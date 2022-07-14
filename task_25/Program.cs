Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;
for (int i = 1; i < b; i++)
{
res = res * a;
}

Console.WriteLine(res);
