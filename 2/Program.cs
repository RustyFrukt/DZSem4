/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = Sum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {summa}");

int Sum(int num)
{
    int summa = 0;
    while (num > 0)
    {
        summa += num % 10;
        num /= 10;
    }
    return summa;
}
