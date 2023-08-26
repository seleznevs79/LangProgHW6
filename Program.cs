// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь. (Можно изучить метод Split.
// Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, где первый аргумент 
// это разделитель чисел, второе обработчик введеной последовательности)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


// Console.Write("Введите числа (через пробел): ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// Console.WriteLine($"[{String.Join(",", array)}]");
// int chetsum = 0;
 
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         chetsum++;
//     }
// }
 
// Console.WriteLine($"Кол-во чисел больше 0 : {chetsum}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 Console.Write("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine()!);

 Console.Write("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine()!);

 Console.Write("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine()!);

 Console.Write("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine()!);

var x = (b2-b1) / (k1-k2);
var y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");