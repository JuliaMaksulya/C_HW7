// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите какое кол - во чисел в ыхотите ввести: ");
// double size = Convert.ToDouble(Console.ReadLine());
// double [] array = new double [size];
// double count = 0;
// FillArray(array);
// PrdoubleArray(array);
// void FillArray (double [] array)
// {

// for (double i = 0 ; i < array.Length; i++)
// {
//   Console.WriteLine("Введите число: ");
//   array[i] = Convert.ToDouble(Console.ReadLine());
  
// }
// }

// void PrdoubleArray (double[] array)
// {
//     for (double i = 0; i < array.Length; i++)
//     {
//          Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// for (double i = 0; i < array.Length; i++)
// {
//     if (array[i]>0)
//     {
//         count = count + 1;
//     }
// }
// Console.WriteLine($"больше нуля {count} числа ");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double y = 0;
double x = 0;
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


x = -(b1 - b2) / (k1 - k2);
y = k1 * x + b1;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");


;