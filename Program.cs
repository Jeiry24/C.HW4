// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: "); 
int B = Convert.ToInt32(Console.ReadLine()); //
int sum = 1; 

for (int i = 1; i <= B; i++)
{
    sum *= A;  // result = result * i;
}
Console.WriteLine(sum);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Получили А 
int numsum = 0; // Количество чисел 
int copyNumber = number; // Копия числа number

while (number >0)
{
    numsum += number % 10;
    number /= 10;

}
Console.WriteLine($"В сумма всех цифр в числе {copyNumber}: {numsum} ");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Или массив из 8 элементов вводится с консоли (каждый элемент вводит человек)
Console.Write("генерация случайных числе в массив ");
int size = 8;
int minValue = 10;
int maxValue = 1000;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue,maxValue +1);
    Console.Write(array[i] + " ");
}

