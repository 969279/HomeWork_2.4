// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rnd = new Random();

void ReadArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(0,100);
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

// collection[index] = new Random().Next(1, 100);
// Random() rnd = new Random(); 
// rnd.Next(1,100); 