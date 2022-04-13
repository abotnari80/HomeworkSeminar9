Console.WriteLine("Введите количество строк в треугильнике");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    for (int j = num; j > i; j--)
    {
        Console.Write(" ");
    }
    int value = 1;
    for (int j = 0; j <= i; j++)
    {
        Console.Write(value + " ");
        value = value * (i - j) / (j + 1);
    }
    Console.WriteLine();
}