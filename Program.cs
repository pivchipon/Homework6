/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

/*int[] GetRandomArray(int length, int min, int max)
{
Console.WriteLine("Enter the number that will be the size of array");
length = int.Parse(Console.ReadLine());
int[] array = new int[length];
for (int i = 0; i < array.Length; i++)
    {
Console.WriteLine("Enter a random number");
array[i] = int.Parse(Console.ReadLine());
    }
return array;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
    {
Console.Write(array[i]);
if (i < array.Length - 1)
        {
Console.Write(", ");
        }
    }  
Console.WriteLine("]");
}

int NumberGreaterThanZero(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] > 0)
    {
count++;
    }
return count;
}

int[] EndArray = GetRandomArray(10, 1, 1500);
Console.WriteLine();
PrintArray(EndArray);
int NumberGreatZero = NumberGreaterThanZero(EndArray);
Console.WriteLine();
Console.WriteLine($"The number of numbers greater than 0 - {NumberGreatZero}");*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


Console.WriteLine("Enter the B1");
double B1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the K1");
double K1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the B2");
double B2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the K2");
double K2 = Convert.ToInt32(Console.ReadLine());

double x = (-B2 + B1)/(-K1 + K2);
double y = K2 * x + B2;

Console.WriteLine($"Two straight lines will intersect at a point with coordinates - X: {x} and Y: {y}");
