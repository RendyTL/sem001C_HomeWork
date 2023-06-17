//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int iMax;

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

iMax = number1;

if (iMax < number2) iMax = number2;
if (iMax < number3) iMax = number3;

Console.Write(iMax);