/*1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/
int userNumberA = new int();
int userNumberB = new int();
Console.WriteLine("Введите два числа: ");
userNumberA = Convert.ToInt32(Console.ReadLine());
userNumberB = Convert.ToInt32(Console.ReadLine());

int result = userNumberA * userNumberA;

if (userNumberB == result)
{
    Console.WriteLine("Является ли второе число квадратом первого? ответ: Да");
}
else
{
    Console.WriteLine("Является ли второе число квадратом первого? ответ: Нет");
}