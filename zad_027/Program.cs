// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// 1 вариант:
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (N > 0) 
{
    int num = N % 10; 
    sum = sum + num; 
    N = N / 10; 
}
Console.Write($"Сумма цифр равна {sum}");

// // 2 вариант:

// int x = Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for (int i=4; i>=0; i--)
// {
//     sum+=x/(int)Math.Pow(10.0,i);
//     x=x%(int)Math.Pow(10.0,i);
// }
// Console.WriteLine(sum);