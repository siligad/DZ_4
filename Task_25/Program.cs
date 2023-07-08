/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int degree (int A, int B)
{
    int i, result=1;
    for(i=1 ; i<=B ; i++)
    {
        result=result*A;
    }
    return result;
}
int A,B, res=1;
Console.WriteLine("Введите два числа (A и B), я возведу число A в натуральную степень B");
Console.Write("A: ");
A=int.Parse(Console.ReadLine());
Console.Write("B: ");
B=int.Parse(Console.ReadLine());
res=degree(A,B);
Console.WriteLine($"Число A в натуральной степени B: {res}");