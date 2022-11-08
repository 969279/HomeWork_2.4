// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void ReadArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0,100);
    }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < (numbers.Length - 1); i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
    Console.WriteLine($"{numbers[numbers.Length - 1]} ");
}

ReadArray(array);
PrintArray(array);
