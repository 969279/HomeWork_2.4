// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

double result = 1;

if(degree < 0)
{
        degree *= -1;
        result = 1 / CalcDeg(number, degree);
}
else 
{
        CalcDeg(number, degree);   
}
Console.WriteLine($"{number}^{degree} = {result}");

double CalcDeg(double number, int degree)
{
        for(int i = 0; i < degree; i++)
        {
        result *= number;
        }
        return result;
}

