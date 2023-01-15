/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 

Console.Write("Введите число А: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b=Convert.ToInt32(Console.ReadLine());
int result=Number(a, b);
Console.Write($"{a} в степени {b} = {result}");

int Number(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}