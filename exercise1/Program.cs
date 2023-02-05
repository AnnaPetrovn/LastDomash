/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int SumOfNaturalInIntervalBetweenNAndM(int m, int n)
{
    int sum = 0;
    int sum1 = 0;
    if (m <= n)
    {
        sum = SumOfNaturalInIntervalBetweenNAndM(m + 1, n);
        sum = sum + m;
        Console.WriteLine($"sum= {sum} m= {m}");
    }
     return sum;
}
Console.WriteLine("Используйте, пожалуйста, значения для ввода в виде натуральных чисел. Первое значение m должно быть больше n. ");
int sum = SumOfNaturalInIntervalBetweenNAndM(1, 5);
Console.WriteLine("Результат суммы натуральных чисел от m до n равен " + sum);