/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int summa (int number)
{
    int sum=number%10;
    while (number > 10)
    {
        sum=sum+(number/10%10);
        number=number/10;
    }
    return sum;
}
int number, sum;
Console.WriteLine("Введите число, а я посчитаю сумму всех цифр в нём: ");
number=int.Parse(Console.ReadLine());

sum=summa(number);
Console.WriteLine($"Сумма цифр = {sum}");