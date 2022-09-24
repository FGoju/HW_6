/*
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m = 5;
Console.Write($"Введите {m} целых чисел через пробел: ");
string new_str = Console.ReadLine();

while (new_str.Split().Length != m)
{   
    Console.WriteLine($"Введено неверное количество чисел - {new_str.Split().Length} ");
    Console.WriteLine($"Пожалуйста, обратите внимание, что необходимо ввести {m} чисел: ");
    Console.Write($"Введите {m} целых чисел через пробел: ");
    new_str = Console.ReadLine();
}

int[] arr = Array.ConvertAll(new_str.Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Из них {count} больше 0 ");
*/

/*
// 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

// double x = ((b2-b1) / (k1 - k2));
// почему-то вышеприведенную формулу считает как 0, а не - 0,5

double q=b2-b1;
double w = k1-k2;
double x = q/w;

double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения [{x}, {y}]");
*/
