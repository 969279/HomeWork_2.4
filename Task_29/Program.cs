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
/*
void setValue(int[] syb, int index)
 {
     Console.WriteLine("Введите значение индекса " + index);
     syb[index] = Convert.ToInt32(Console.ReadLine());
 }

 int[] syb = new int[9];
 for (int index = 0; index < syb.Length; index++) 
 {
     setValue(syb, index);
 }
 string output = $"{syb[0]}";
 for (int index = 1; index < syb.Length - 1; index++)
  {
     output += $", {syb[index]}";
  }
 output += $", {syb[8]}";

 Console.WriteLine("Массив: " + output);
*/

/*
Console.Write ("Введите A: ");
int a = int.Parse (Console.ReadLine ()!); 
Console.Write ("Введите B: ");
int b = int.Parse (Console.ReadLine ()!);
int syb = a;
for (int i = 1; i < b; i++) 
  syb = syb * a;
 Console.WriteLine($"Число {a} в степени {b} равно {syb}");
*/